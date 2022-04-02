using GDBackup.Properties;
using Ionic.Zip;
using System;
using System.IO;
using System.Management.Automation;
using System.Net;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class Form1 : Form
    {
        private bool configurado;
        public Form1()
        {

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            InitializeComponent();
            InitTimer();
            notifyIcon1.Visible = true;
            if (Settings.Default.Diretorio_ftp != ""
                && Settings.Default.Endereco_ftp != ""
                && Settings.Default.FileName != ""
                && Settings.Default.Format != ""
                && Settings.Default.Path != ""
                && Settings.Default.Script_Path != ""
                && Settings.Default.Script_Name != "")
            {
                lbl_status.Text = "SISTEMA CONFIGURADO";
                configurado = true;
            }
            else
            {
                configurado = false;
                lbl_status.Text = "NÃO CONFIGURADO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            configuracoes configuracoes = new configuracoes();
            configuracoes.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
        }
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            switch (Settings.Default.TimeFormat)
            {
                case "Minutos":
                    timer1.Interval = Convert.ToInt32(Settings.Default.Intervalo) * (60000);
                    timer1.Start();
                    break;
                case "Horas":
                    timer1.Interval = Convert.ToInt32(Settings.Default.Intervalo) * (3600000);
                    timer1.Start();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (configurado)
            {
                try
                {
                    using (ZipFile zip = new ZipFile())
                    {
                        string zipdiretorio = String.Format(@"{0}/{1}.{2}", Settings.Default.Path, Settings.Default.FileName, Settings.Default.Format);
                        string zipname = String.Format(@"{0}/{1}.zip", Settings.Default.Path, Settings.Default.FileName);
                        zip.AddFile(zipdiretorio, "BACKUP");
                        zip.Save(zipname);
                    }
                    notifyIcon1.BalloonTipText = "Backup iniciado, não desligue o computador";
                    notifyIcon1.ShowBalloonTip(5000);
                    PowerShell ps = PowerShell.Create();
                    string script = String.Format(@"{0}/{1}.ps1", Settings.Default.Script_Path, Settings.Default.Script_Name);
                    ps.AddScript(File.ReadAllText(script), true).Invoke();
                    /*
                                DateTime dt = new DateTime();
                                switch (dt.DayOfWeek)
                                {
                                    case DayOfWeek.Sunday:
                                        StreamReader sourceStream = new StreamReader(@"C:\Users\marce\Downloads\Teste.txt");
                                        byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                                        sourceStream.Close();
                                        request.ContentLength = fileContents.Length;
                                        Stream requestStream = request.GetRequestStream();
                                        requestStream.Write(fileContents, 0, fileContents.Length);
                                        requestStream.Close();
                                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                                        Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);
                                        break;
                                    default:
                                        break;
                                }
                    */
                    string PureFileName = new FileInfo(Settings.Default.FileName).Name;
                    String uploadUrl = String.Format("ftp://{0}/{1}/{2}.zip", Settings.Default.Endereco_ftp, Settings.Default.Diretorio_ftp, PureFileName);
                    FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(uploadUrl);
                    req.Proxy = null;
                    req.Method = WebRequestMethods.Ftp.UploadFile;
                    req.Credentials = new NetworkCredential("Teste", "1234");
                    req.UseBinary = true;
                    req.UsePassive = true;
                    String FilePath = String.Format(@"{0}\{1}.zip", Settings.Default.Path, Settings.Default.FileName);
                    byte[] data = File.ReadAllBytes(FilePath);
                    req.ContentLength = data.Length;
                    Stream stream = req.GetRequestStream();
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                    FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                    notifyIcon1.BalloonTipText = "Backup finalizado";
                    notifyIcon1.ShowBalloonTip(5000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    notifyIcon1.BalloonTipText = "Erro ao efetuar backup, contate o suporte";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
        }
    }
}

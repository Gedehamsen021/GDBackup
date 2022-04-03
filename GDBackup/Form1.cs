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
                && Settings.Default.Segunda_path != ""
                && Settings.Default.Terca_path != ""
                && Settings.Default.Quarta_path != ""
                && Settings.Default.Quinta_path != ""
                && Settings.Default.Sexta_path != ""
                && Settings.Default.Sabado_path != ""
                && Settings.Default.Domingo_path != ""
                && Settings.Default.Script_Path != ""
                && Settings.Default.Script_Name != ""
                && Settings.Default.Usuario_ftp != ""
                && Settings.Default.Senha_ftp != "")
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
            string senha = "senha";
            if(CustomForms.InputBox("DESEJA FECHAR O SISTEMA?", "Digite a senha para fechar o sistema",ref senha) == DialogResult.OK) {
                if(senha == Settings.Default.Senha_Sistema)
                {
                    Close();
                } else
                {
                    MessageBox.Show("Senha invalida");
                }
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            string senha = "senha";
            if (CustomForms.InputBox("AVISO", "Insira a senha para acessar as configurações", ref senha) == DialogResult.OK)
            {
                if (senha == Settings.Default.Senha_Sistema)
                {
                    configuracoes configuracoes = new configuracoes();
                    configuracoes.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha invalida");
                }
            }
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
                    notifyIcon1.BalloonTipText = "Backup iniciado, não desligue o computador";
                    notifyIcon1.ShowBalloonTip(5000);
                    PowerShell ps = PowerShell.Create();
                    string script = String.Format(@"{0}/{1}.ps1", Settings.Default.Script_Path, Settings.Default.Script_Name);
                    ps.AddScript(File.ReadAllText(script), true).Invoke();
                    DateTime dt = DateTime.Now;

                    switch (dt.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            zipConfig("Domingo");
                            backupConfig("Domingo");
                            break;
                        case DayOfWeek.Monday:
                            zipConfig("Segunda");
                            backupConfig("Segunda");
                            break;
                        case DayOfWeek.Tuesday:
                            zipConfig("Terça");
                            backupConfig("Terça");
                            break;
                        case DayOfWeek.Wednesday:
                            zipConfig("Quarta");
                            backupConfig("Quarta");
                            break;
                        case DayOfWeek.Thursday:
                            zipConfig("Quinta");
                            backupConfig("Quinta");
                            break;
                        case DayOfWeek.Friday:
                            zipConfig("Sexta");
                            backupConfig("Sexta");
                            break;
                        case DayOfWeek.Saturday:
                            zipConfig("Sabado");
                            backupConfig("Sabado");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    notifyIcon1.BalloonTipText = "Erro ao efetuar backup, contate o suporte";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
        }

        private void zipConfig(string dia)
        {
            using (ZipFile zip = new ZipFile())
            {
                string zipdiretorio = String.Format(@"{0}/{1}.{2}", Settings.Default.Segunda_path, Settings.Default.FileName, Settings.Default.Format);
                string zipname = String.Format(@"{0}/{1}.zip", Settings.Default.Segunda_path, dia);
                zip.AddFile(zipdiretorio, "BACKUP");
                zip.Save(zipname);
            }
        }

        private void backupConfig(string dia)
        {
            string PureFileName = new FileInfo(dia).Name;
            String uploadUrl = String.Format("ftp://{0}/{1}/{2}.zip", Settings.Default.Endereco_ftp, Settings.Default.Diretorio_ftp, PureFileName);
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(uploadUrl);
            req.Proxy = null;
            req.Method = WebRequestMethods.Ftp.UploadFile;
            req.Credentials = new NetworkCredential(Settings.Default.Usuario_ftp, Settings.Default.Senha_ftp);
            req.UseBinary = true;
            req.UsePassive = true;
            String FilePath = String.Format(@"{0}\{1}.zip", Settings.Default.Segunda_path, dia);
            byte[] data = File.ReadAllBytes(FilePath);
            req.ContentLength = data.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();
            FtpWebResponse res = (FtpWebResponse)req.GetResponse();
            notifyIcon1.BalloonTipText = "Backup finalizado";
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            if (configurado)
            {
                try
                {
                    notifyIcon1.BalloonTipText = "Backup forçado iniciado, não desligue o computador";
                    notifyIcon1.ShowBalloonTip(5000);
                    PowerShell ps = PowerShell.Create();
                    string script = String.Format(@"{0}/{1}.ps1", Settings.Default.Script_Path, Settings.Default.Script_Name);
                    ps.AddScript(File.ReadAllText(script), true).Invoke();
                    DateTime dt = DateTime.Now;

                    switch (dt.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            zipConfig("Domingo");
                            backupConfig("Domingo");
                            break;
                        case DayOfWeek.Monday:
                            zipConfig("Segunda");
                            backupConfig("Segunda");
                            break;
                        case DayOfWeek.Tuesday:
                            zipConfig("Terça");
                            backupConfig("Terça");
                            break;
                        case DayOfWeek.Wednesday:
                            zipConfig("Quarta");
                            backupConfig("Quarta");
                            break;
                        case DayOfWeek.Thursday:
                            zipConfig("Quinta");
                            backupConfig("Quinta");
                            break;
                        case DayOfWeek.Friday:
                            zipConfig("Sexta");
                            backupConfig("Sexta");
                            break;
                        case DayOfWeek.Saturday:
                            zipConfig("Sabado");
                            backupConfig("Sabado");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    notifyIcon1.BalloonTipText = "Erro ao efetuar backup, contate o suporte";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            } else
            {
                MessageBox.Show("Sistema não está configurado corretamente");
            }
        }
    }
}

using GDBackup.Properties;
using Ionic.Zip;
using System;
using System.IO;
using System.Management.Automation;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class Form1 : Form
    {
        private bool configurado;
        private bool salvar;
        public Form1()
        {

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            InitializeComponent();
            InitTimer();
            TopMost = true;
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
                && Settings.Default.Senha_ftp != ""
                && Settings.Default.Smtp != ""
                && Settings.Default.Smtp_port != 0
                && Settings.Default.Mail_user != ""
                && Settings.Default.Mail_pass != ""
                && Settings.Default.Mail_receiver != "")
            {
                lbl_status.Text = "SISTEMA CONFIGURADO";
                configurado = true;
            }
            else
            {
                configurado = false;
                lbl_status.Text = "NÃO CONFIGURADO";
            }
            if(Settings.Default.Sistema_manutencao)
            {
                configurado = false;
                lbl_status.Text = "MANUTENÇÃO LIGADA";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = "senha";
            if (CustomForms.InputBox("DESEJA FECHAR O SISTEMA?", "Digite a senha para fechar o sistema", ref senha) == DialogResult.OK)
            {
                if (senha == Settings.Default.Senha_Sistema)
                {
                    Close();
                }
                else
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
                            zipConfig(Settings.Default.Domingo_path, "Domingo");
                            if (salvar)
                            {
                                smtp(Settings.Default.Domingo_path);
                                backupConfig(Settings.Default.Domingo_path, "Domingo");
                            }
                            break;
                        case DayOfWeek.Monday:
                            zipConfig(Settings.Default.Segunda_path, "Segunda");
                            if (salvar)
                            {
                                smtp(Settings.Default.Segunda_path);
                                backupConfig(Settings.Default.Segunda_path, "Segunda");
                            }
                            break;
                        case DayOfWeek.Tuesday:
                            zipConfig(Settings.Default.Terca_path, "Terça");
                            if (salvar)
                            {
                                smtp(Settings.Default.Terca_path);
                                backupConfig(Settings.Default.Terca_path, "Terça");
                            }
                            break;
                        case DayOfWeek.Wednesday:
                            zipConfig(Settings.Default.Quarta_path, "Quarta");
                            if (salvar)
                            {
                                smtp(Settings.Default.Quarta_path);
                                backupConfig(Settings.Default.Quarta_path, "Quarta");
                            }
                            break;
                        case DayOfWeek.Thursday:
                            zipConfig(Settings.Default.Quinta_path, "Quinta");
                            if (salvar)
                            {
                                smtp(Settings.Default.Quinta_path);
                                backupConfig(Settings.Default.Quinta_path, "Quinta");
                            }
                            break;
                        case DayOfWeek.Friday:
                            zipConfig(Settings.Default.Sexta_path, "Sexta");
                            if (salvar)
                            {
                                smtp(Settings.Default.Sexta_path);
                                backupConfig(Settings.Default.Sexta_path, "Sexta");
                            }
                            break;
                        case DayOfWeek.Saturday:
                            zipConfig(Settings.Default.Sabado_path, "Sabado");
                            if (salvar)
                            {
                                smtp(Settings.Default.Sabado_path);
                                backupConfig(Settings.Default.Sabado_path, "Sabado");
                            }
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

        private void zipConfig(string diapath, string dia)
        {
            using (ZipFile zip = new ZipFile())
            {
                string zipdiretorio = String.Format(@"{0}/{1}.{2}", diapath, Settings.Default.FileName, Settings.Default.Format);
                string logdiretorio = String.Format(@"{0}/{1}.log", diapath, "backup");
                string zipname = String.Format(@"{0}/{1}.zip", diapath, dia);
                zip.AddFile(zipdiretorio, "BACKUP");
                zip.AddFile(logdiretorio, "BACKUP");
                zip.Save(zipname);
                if (File.ReadAllText(logdiretorio).Contains("Export terminated successfully without warnings"))
                {
                    salvar = true;
                }
                else
                {
                    salvar = false;
                    notifyIcon1.BalloonTipText = "Banco de dados com problema, contate o suporte o mais rapido possivel";
                    smtp(dia);
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
        }

        private void backupConfig(string diapath, string dia)
        {
            string PureFileName = new FileInfo(dia).Name;
            String uploadUrl = String.Format("ftp://{0}/{1}/{2}.zip", Settings.Default.Endereco_ftp, Settings.Default.Diretorio_ftp, PureFileName);
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(uploadUrl);
            req.Proxy = null;
            req.Method = WebRequestMethods.Ftp.UploadFile;
            req.Credentials = new NetworkCredential(Settings.Default.Usuario_ftp, Settings.Default.Senha_ftp);
            req.UseBinary = true;
            req.UsePassive = true;
            String FilePath = String.Format(@"{0}/{1}.zip", diapath, dia);
            byte[] data = File.ReadAllBytes(FilePath);
            req.ContentLength = data.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();
            notifyIcon1.BalloonTipText = "Backup finalizado";
            notifyIcon1.ShowBalloonTip(5000);
            salvar = false;
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
                            zipConfig(Settings.Default.Domingo_path, "Domingo");
                            if (salvar)
                            {
                                smtp(Settings.Default.Domingo_path);
                                backupConfig(Settings.Default.Domingo_path, "Domingo");
                            }
                            break;
                        case DayOfWeek.Monday:
                            zipConfig(Settings.Default.Segunda_path, "Segunda");
                            if (salvar)
                            {
                                smtp(Settings.Default.Segunda_path);
                                backupConfig(Settings.Default.Segunda_path, "Segunda");
                            }
                            break;
                        case DayOfWeek.Tuesday:
                            zipConfig(Settings.Default.Terca_path, "Terça");
                            if (salvar)
                            {
                                smtp(Settings.Default.Terca_path);
                                backupConfig(Settings.Default.Terca_path, "Terça");
                            }
                            break;
                        case DayOfWeek.Wednesday:
                            zipConfig(Settings.Default.Quarta_path, "Quarta");
                            if (salvar)
                            {
                                smtp(Settings.Default.Quarta_path);
                                backupConfig(Settings.Default.Quarta_path, "Quarta");
                            }
                            break;
                        case DayOfWeek.Thursday:
                            zipConfig(Settings.Default.Quinta_path, "Quinta");
                            if (salvar)
                            {
                                smtp(Settings.Default.Quinta_path);
                                backupConfig(Settings.Default.Quinta_path, "Quinta");
                            }
                            break;
                        case DayOfWeek.Friday:
                            zipConfig(Settings.Default.Sexta_path, "Sexta");
                            if (salvar)
                            {
                                smtp(Settings.Default.Sexta_path);
                                backupConfig(Settings.Default.Sexta_path, "Sexta");
                            }
                            break;
                        case DayOfWeek.Saturday:
                            zipConfig(Settings.Default.Sabado_path, "Sabado");
                            if (salvar)
                            {
                                smtp(Settings.Default.Sabado_path);
                                backupConfig(Settings.Default.Sabado_path, "Sabado");
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    notifyIcon1.BalloonTipText = "Erro ao efetuar backup, contate o suporte";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
            else
            {
                MessageBox.Show("Sistema não está configurado corretamente");
            }
        }

        private void smtp(string dia)
        {
            if (Settings.Default.Utiliza_email)
            {
                try
                {
                    var smtpClient = new SmtpClient(Settings.Default.Smtp)
                    {
                        Port = Settings.Default.Smtp_port,
                        Credentials = new NetworkCredential(Settings.Default.Mail_user, Settings.Default.Mail_pass),
                        EnableSsl = true,
                    };
                    if (salvar == true)
                    {
                        var mailMessage = new MailMessage
                        {
                            From = new MailAddress(Settings.Default.Mail_user),
                            Subject = Settings.Default.Cliente,
                            Body = "",
                            IsBodyHtml = false,
                        };
                        string logdiretorio = String.Format(@"{0}/{1}.log", dia, "backup");
                        var attachment = new Attachment(logdiretorio, MediaTypeNames.Text.Plain);
                        mailMessage.To.Add(Settings.Default.Mail_receiver);
                        mailMessage.Attachments.Add(attachment);
                        smtpClient.Send(mailMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class cfg_email : Form
    {
        public cfg_email()
        {
            InitializeComponent();
            TopMost = true;
            box_smtp.Text = Properties.Settings.Default.Smtp;
            box_cliente.Text = Properties.Settings.Default.Cliente;
            box_mailPass.Text = Properties.Settings.Default.Mail_pass;
            box_mailUser.Text = Properties.Settings.Default.Mail_user;
            box_receiver.Text = Properties.Settings.Default.Mail_receiver;
            box_smtp_port.Text = Properties.Settings.Default.Smtp_port.ToString();
            box_utiliza_email.Checked = Properties.Settings.Default.Utiliza_email;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Smtp = box_smtp.Text;
            Properties.Settings.Default.Smtp_port = Convert.ToInt32(box_smtp_port.Text);
            Properties.Settings.Default.Mail_user = box_mailUser.Text;
            Properties.Settings.Default.Mail_pass = box_mailPass.Text;
            Properties.Settings.Default.Mail_receiver = box_receiver.Text;
            Properties.Settings.Default.Cliente = box_cliente.Text;
            if(box_utiliza_email.Checked)
            {
                Properties.Settings.Default.Utiliza_email = true;
            } else 
            { 
                Properties.Settings.Default.Utiliza_email = false; 
            }
            
            Properties.Settings.Default.Save();
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void box_smtp_port_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box_smtp_port.Text, "  ^ [0-9]"))
            {
                box_smtp_port.Text = "";
            }
        }
    }
}

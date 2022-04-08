using System;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class configuracoes : Form
    {
        public configuracoes()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("Configurações salvas, por favor reinicie o software");
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_diretorio_Click(object sender, EventArgs e)
        {
            diretorios diretorios = new diretorios();
            diretorios.ShowDialog();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            cfg_email cfg_Email = new cfg_email();
            cfg_Email.ShowDialog();
        }

        private void btn_ftp_Click(object sender, EventArgs e)
        {
            cfg_ftp cfg_Ftp = new cfg_ftp();
            cfg_Ftp.ShowDialog();
        }

        private void btn_sistema_Click(object sender, EventArgs e)
        {
            cfg_sistema cfg_Sistema = new cfg_sistema();
            cfg_Sistema.ShowDialog();
        }
    }
}

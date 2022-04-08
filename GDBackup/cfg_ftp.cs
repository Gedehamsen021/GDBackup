using System;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class cfg_ftp : Form
    {
        public cfg_ftp()
        {
            InitializeComponent();
            TopMost = true;
            box_usuario.Text = Properties.Settings.Default.Usuario_ftp;
            box_senha.Text = Properties.Settings.Default.Senha_ftp;
            box_diretorio.Text = Properties.Settings.Default.Diretorio_ftp;
            box_ftp.Text = Properties.Settings.Default.Endereco_ftp;
            box_intervalo.Value = Properties.Settings.Default.Intervalo;
            cmb_timer.Text = Properties.Settings.Default.TimeFormat;
            box_script.Text = Properties.Settings.Default.Script_Path;
            box_scriptname.Text = Properties.Settings.Default.Script_Name;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Diretorio_ftp = box_diretorio.Text;
                Properties.Settings.Default.Endereco_ftp = box_ftp.Text;
                Properties.Settings.Default.Usuario_ftp = box_usuario.Text;
                Properties.Settings.Default.Senha_ftp = box_senha.Text;
                Properties.Settings.Default.Intervalo = Convert.ToInt32(box_intervalo.Value);
                Properties.Settings.Default.TimeFormat = cmb_timer.Text;
                Properties.Settings.Default.Script_Path = box_script.Text;
                Properties.Settings.Default.Script_Name = box_scriptname.Text;
                Properties.Settings.Default.Save();
                Close();
            }
            catch (Exception)
            {

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

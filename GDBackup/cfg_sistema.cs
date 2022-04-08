using System;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class cfg_sistema : Form
    {
        public cfg_sistema()
        {
            InitializeComponent();
            TopMost = true;
            box_manutencao.Checked = Properties.Settings.Default.Sistema_manutencao;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (box_oldpass.Text != "" && box_newpass.Text != "")
                {
                    if (box_oldpass.Text == Properties.Settings.Default.Senha_Sistema)
                    {
                        if (box_manutencao.Checked)
                        {
                            Properties.Settings.Default.Sistema_manutencao = true;
                        } else
                        {
                            Properties.Settings.Default.Sistema_manutencao = false;
                        }
                        Properties.Settings.Default.Senha_Sistema = box_newpass.Text;
                        Properties.Settings.Default.Save();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("SENHA ANTIGA NÃO CORRESPONDE COM A SENHA ATUAL");
                    }
                }
                else
                {
                    if (box_manutencao.Checked)
                    {
                        Properties.Settings.Default.Sistema_manutencao = true;
                    }
                    else
                    {
                        Properties.Settings.Default.Sistema_manutencao = false;
                    }
                    Properties.Settings.Default.Save();
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

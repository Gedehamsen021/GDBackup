﻿using System;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class configuracoes : Form
    {
        public configuracoes()
        {
            InitializeComponent();
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
                Properties.Settings.Default.Intervalo = Convert.ToInt32(box_intervalo.Value);
                Properties.Settings.Default.TimeFormat = cmb_timer.Text;
                Properties.Settings.Default.Script_Path = box_script.Text;
                Properties.Settings.Default.Script_Name = box_scriptname.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("CONFIGURAÇÕES APLICADAS E SALVAS, REINICIE O PROGRAMA");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
    }
}

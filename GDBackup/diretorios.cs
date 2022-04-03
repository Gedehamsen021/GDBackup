using System;
using System.Windows.Forms;

namespace GDBackup
{
    public partial class diretorios : Form
    {
        public diretorios()
        {
            InitializeComponent();
            box_fileName.Text = Properties.Settings.Default.FileName;
            box_format.Text = Properties.Settings.Default.Format;
            box_segunda.Text = Properties.Settings.Default.Segunda_path;
            box_terca.Text = Properties.Settings.Default.Terca_path;
            box_quarta.Text = Properties.Settings.Default.Quarta_path;
            box_quinta.Text = Properties.Settings.Default.Quinta_path;
            box_sexta.Text = Properties.Settings.Default.Sexta_path;
            box_sabado.Text = Properties.Settings.Default.Sabado_path;
            box_domingo.Text = Properties.Settings.Default.Domingo_path;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FileName = box_fileName.Text;
            Properties.Settings.Default.Format = box_format.Text;
            Properties.Settings.Default.Segunda_path = box_segunda.Text;
            Properties.Settings.Default.Terca_path = box_terca.Text;
            Properties.Settings.Default.Quarta_path = box_quarta.Text;
            Properties.Settings.Default.Quinta_path = box_quinta.Text;
            Properties.Settings.Default.Sexta_path = box_sexta.Text;
            Properties.Settings.Default.Sabado_path = box_sabado.Text;
            Properties.Settings.Default.Domingo_path = box_domingo.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}

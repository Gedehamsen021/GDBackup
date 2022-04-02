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
            box_segunda.Text = Properties.Settings.Default.Path;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FileName = box_fileName.Text;
            Properties.Settings.Default.Format = box_format.Text;
            Properties.Settings.Default.Path = box_segunda.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}

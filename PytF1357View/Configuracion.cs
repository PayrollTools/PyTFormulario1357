using PytF1357Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace PytF1357View
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        private string ObtainDirectory()
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowser.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }
        private void Configuracion_Load(object sender, EventArgs e)
        {
            this.txtDirectorio.Text = IniFile.ReadINI();
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            this.txtDirectorio.Text = ObtainDirectory();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(this.txtDirectorio.Text))
            {
                IniFile.WriteINI(this.txtDirectorio.Text);
                MessageBox.Show("Se guardaron los cambios sactifactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Directorio especificado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

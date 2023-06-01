using PytF1357Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PytF1357View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string ObtainTXTFile()
        {
            string currentDirectory = Environment.CurrentDirectory;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = currentDirectory;
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }

        private string ObtainExcelFile()
        {
            string currentDirectory = Environment.CurrentDirectory;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = currentDirectory;
                fileDialog.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }        

        private void configuraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.ShowDialog();
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string excelFile;
            string txtFile;
            byte? tipoPresentacion = null;
            string directorySave = IniFile.ReadINI();
            // Si no existe en directorio lo guarda en el del programa.
            if(!Directory.Exists(directorySave))
            {
                directorySave = Environment.CurrentDirectory;
            }
            // Inhabilita el formulario mientras esta procesando la información.
            this.Enabled = false;

            List<Object> registro01 = new List<Object>();

            switch (this.cmbPresentacion.SelectedIndex)
            {
                case 0:
                    tipoPresentacion = 1;
                    break;
                case 1:
                    tipoPresentacion = 2;
                    break;
                case 2:
                    tipoPresentacion = 3;
                    break;
                case 3:
                    tipoPresentacion = 4;
                    break;
            }

            List<object> datosRegistro01 = new List<object>()
                        {
                            this.txtCUIT.Text,
                            this.txtPerInformado.Text,
                            this.txtSecuencia.Text,
                            tipoPresentacion
                        };

            List<object> response;

            try
            {
                // Manejo de errores
                if (this.cmbSeleccionProceso.SelectedIndex == 2 || this.cmbSeleccionProceso.SelectedIndex == 3)
                {
                    // Verifica el largo del campo CUIT.
                    int cuitLong = this.txtCUIT.Text.Length;
                    if (cuitLong != 11)
                    {
                        throw new FormatException();
                    }
                    // Verifica el largo del campo Periodo Informado.
                    int periodoInformadoLong = this.txtPerInformado.Text.Length;
                    if (periodoInformadoLong != 6)
                    {
                        throw new FormatException();
                    }
                    // Verifica el largo del campo secuencia.
                    int secuenciaLong = this.txtSecuencia.Text.Length;
                    if (secuenciaLong != 2)
                    {
                        throw new FormatException();
                    }
                    // Verifica que el campo CUIT no tenga caracteres invalidos.
                    long nroCUIT;
                    if (long.TryParse(this.txtCUIT.Text.ToString(), out nroCUIT) == false)
                    {
                        throw new InvalidCastException();
                    }
                    // Verifica que el campo periodo informado no tenga caracteres invalidos.
                    int periodoInformado;
                    if (int.TryParse(this.txtPerInformado.Text.ToString(), out periodoInformado) == false)
                    {
                        throw new InvalidCastException();
                    }
                    // Verifica que el campo secuencia no tenga caracteres invalidos.
                    byte secuencia;
                    if (byte.TryParse(this.txtSecuencia.Text.ToString(), out secuencia) == false)
                    {
                        throw new InvalidCastException();
                    }
                }

                switch (this.cmbSeleccionProceso.SelectedIndex)
                {
                    
                    case 0:
                        txtFile = ObtainTXTFile();
                        if (txtFile != null)
                        {
                            response = Model.TxtAExcelVersion5(registro01, txtFile, directorySave);
                            if ((bool)response[0] == true)
                            {
                                this.txtCUIT.Text = registro01[0].ToString();
                                this.txtPerInformado.Text = registro01[1].ToString();
                                this.txtSecuencia.Text = registro01[2].ToString();
                                this.cmbPresentacion.SelectedItem = (int)registro01[3];

                                MessageBox.Show("Proceso finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show((string)response[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case 1:
                        txtFile = ObtainTXTFile();

                        if (txtFile != null)
                        {
                            response = Model.TxtAExcelVersion6(registro01, txtFile, directorySave);

                            if ((bool)response[0] == true)
                            {
                                this.txtCUIT.Text = registro01[0].ToString();
                                this.txtPerInformado.Text = registro01[1].ToString();
                                this.txtSecuencia.Text = registro01[2].ToString();
                                this.cmbPresentacion.SelectedItem = (int)registro01[3];

                                MessageBox.Show("Proceso finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show((string)response[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case 2:
                        excelFile = ObtainExcelFile();

                        if (excelFile != null)
                        {
                            response = Model.ExcelATxtVersion5(datosRegistro01, excelFile, directorySave);

                            if ((bool)response[0] == true)
                            {
                                MessageBox.Show("Proceso finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show((string)response[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case 3:
                        excelFile = ObtainExcelFile();

                        if (excelFile != null)
                        {
                            response = Model.ExcelATxtVersion6(datosRegistro01, excelFile, directorySave);

                            if ((bool)response[0] == true)
                            {
                                MessageBox.Show("Proceso finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show((string)response[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }

                this.Enabled = true;
            }

            catch (FormatException)
            {
                MessageBox.Show("Verificar largo de caracteres ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("La información ingresada contiene caracteres invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"{Environment.CurrentDirectory}/Documentación/index.html");
        }
    }
}

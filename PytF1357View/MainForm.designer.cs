namespace PytF1357View
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl02 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lblPeriodoInformado = new System.Windows.Forms.Label();
            this.txtPerInformado = new System.Windows.Forms.TextBox();
            this.lbl03 = new System.Windows.Forms.Label();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.lbl05 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeleccionProceso = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem1});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.configuraciónToolStripMenuItem1.Text = "Directorio";
            this.configuraciónToolStripMenuItem1.Click += new System.EventHandler(this.configuraciónToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.toolStripSeparator1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Location = new System.Drawing.Point(71, 74);
            this.lbl02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(35, 13);
            this.lbl02.TabIndex = 1;
            this.lbl02.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(116, 71);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(120, 20);
            this.txtCUIT.TabIndex = 2;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(8, 34);
            this.lbl01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(153, 20);
            this.lbl01.TabIndex = 0;
            this.lbl01.Text = "Datos registro 01:";
            // 
            // lblPeriodoInformado
            // 
            this.lblPeriodoInformado.AutoSize = true;
            this.lblPeriodoInformado.Location = new System.Drawing.Point(255, 74);
            this.lblPeriodoInformado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodoInformado.Name = "lblPeriodoInformado";
            this.lblPeriodoInformado.Size = new System.Drawing.Size(95, 13);
            this.lblPeriodoInformado.TabIndex = 3;
            this.lblPeriodoInformado.Text = "Periodo informado:";
            // 
            // txtPerInformado
            // 
            this.txtPerInformado.Location = new System.Drawing.Point(357, 71);
            this.txtPerInformado.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerInformado.Name = "txtPerInformado";
            this.txtPerInformado.Size = new System.Drawing.Size(120, 20);
            this.txtPerInformado.TabIndex = 4;
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Location = new System.Drawing.Point(45, 103);
            this.lbl03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(61, 13);
            this.lbl03.TabIndex = 5;
            this.lbl03.Text = "Secuencia:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(116, 100);
            this.txtSecuencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(120, 20);
            this.txtSecuencia.TabIndex = 6;
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.Location = new System.Drawing.Point(255, 103);
            this.lbl05.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(95, 13);
            this.lbl05.TabIndex = 7;
            this.lbl05.Text = "Tipo presentación:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datos requeridos al generar el archivo txt a partir de un excel.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Proceso a generar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Proceso:";
            // 
            // cmbSeleccionProceso
            // 
            this.cmbSeleccionProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionProceso.FormattingEnabled = true;
            this.cmbSeleccionProceso.Items.AddRange(new object[] {
            "Lectura archivo TXT a excel - Versión 5",
            "Lectura archivo TXT a excel - Versión 6",
            "Lectura archivo excel a TXT - Versión 5",
            "Lectura archivo excel a TXT - Versión 6"});
            this.cmbSeleccionProceso.Location = new System.Drawing.Point(116, 209);
            this.cmbSeleccionProceso.Name = "cmbSeleccionProceso";
            this.cmbSeleccionProceso.Size = new System.Drawing.Size(361, 21);
            this.cmbSeleccionProceso.TabIndex = 12;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(402, 246);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 13;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Items.AddRange(new object[] {
            "1 - Anual",
            "2 - Final",
            "3 - Informativa ",
            "4 - Anual -> Distracto Ene - Mar"});
            this.cmbPresentacion.Location = new System.Drawing.Point(357, 99);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(121, 21);
            this.cmbPresentacion.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 294);
            this.Controls.Add(this.cmbPresentacion);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbSeleccionProceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl05);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.txtPerInformado);
            this.Controls.Add(this.lblPeriodoInformado);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Pyt - Lector formulario 1357";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lblPeriodoInformado;
        private System.Windows.Forms.TextBox txtPerInformado;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.TextBox txtSecuencia;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeleccionProceso;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ComboBox cmbPresentacion;
    }
}


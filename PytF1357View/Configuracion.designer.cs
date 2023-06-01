namespace PytF1357View
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directorio de Salida:";
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(111, 15);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(265, 20);
            this.txtDirectorio.TabIndex = 1;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirectorio.BackgroundImage")));
            this.btnDirectorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectorio.Location = new System.Drawing.Point(382, 8);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(32, 32);
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(339, 55);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(258, 55);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 91);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
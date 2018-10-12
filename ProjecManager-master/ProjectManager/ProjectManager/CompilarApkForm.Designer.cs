namespace ProjectManager
{
    partial class CompilarApkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompilarApkForm));
            this.lblSeleccionarProyectoApk = new System.Windows.Forms.Label();
            this.cmbProyectosApk = new System.Windows.Forms.ComboBox();
            this.cmbSeleccionarEntorno = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarEntornoApk = new System.Windows.Forms.Label();
            this.checkAgregarPlataforma = new System.Windows.Forms.CheckBox();
            this.lblAgregarPlataforma = new System.Windows.Forms.Label();
            this.lblFirmaApk = new System.Windows.Forms.Label();
            this.checkFirmarApk = new System.Windows.Forms.CheckBox();
            this.btnCompilarApk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionarProyectoApk
            // 
            this.lblSeleccionarProyectoApk.AutoSize = true;
            this.lblSeleccionarProyectoApk.Location = new System.Drawing.Point(7, 53);
            this.lblSeleccionarProyectoApk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarProyectoApk.Name = "lblSeleccionarProyectoApk";
            this.lblSeleccionarProyectoApk.Size = new System.Drawing.Size(244, 20);
            this.lblSeleccionarProyectoApk.TabIndex = 38;
            this.lblSeleccionarProyectoApk.Text = "Seleccione el proyecto a compilar";
            this.lblSeleccionarProyectoApk.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbProyectosApk
            // 
            this.cmbProyectosApk.FormattingEnabled = true;
            this.cmbProyectosApk.Location = new System.Drawing.Point(13, 78);
            this.cmbProyectosApk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProyectosApk.Name = "cmbProyectosApk";
            this.cmbProyectosApk.Size = new System.Drawing.Size(238, 28);
            this.cmbProyectosApk.TabIndex = 37;
            // 
            // cmbSeleccionarEntorno
            // 
            this.cmbSeleccionarEntorno.FormattingEnabled = true;
            this.cmbSeleccionarEntorno.Location = new System.Drawing.Point(13, 152);
            this.cmbSeleccionarEntorno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSeleccionarEntorno.Name = "cmbSeleccionarEntorno";
            this.cmbSeleccionarEntorno.Size = new System.Drawing.Size(238, 28);
            this.cmbSeleccionarEntorno.TabIndex = 39;
            // 
            // lblSeleccionarEntornoApk
            // 
            this.lblSeleccionarEntornoApk.AutoSize = true;
            this.lblSeleccionarEntornoApk.Location = new System.Drawing.Point(9, 127);
            this.lblSeleccionarEntornoApk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarEntornoApk.Name = "lblSeleccionarEntornoApk";
            this.lblSeleccionarEntornoApk.Size = new System.Drawing.Size(162, 20);
            this.lblSeleccionarEntornoApk.TabIndex = 40;
            this.lblSeleccionarEntornoApk.Text = "Seleccione el entorno";
            this.lblSeleccionarEntornoApk.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkAgregarPlataforma
            // 
            this.checkAgregarPlataforma.AutoSize = true;
            this.checkAgregarPlataforma.Location = new System.Drawing.Point(13, 209);
            this.checkAgregarPlataforma.Name = "checkAgregarPlataforma";
            this.checkAgregarPlataforma.Size = new System.Drawing.Size(22, 21);
            this.checkAgregarPlataforma.TabIndex = 41;
            this.checkAgregarPlataforma.UseVisualStyleBackColor = true;
            // 
            // lblAgregarPlataforma
            // 
            this.lblAgregarPlataforma.AutoSize = true;
            this.lblAgregarPlataforma.Location = new System.Drawing.Point(42, 210);
            this.lblAgregarPlataforma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarPlataforma.Name = "lblAgregarPlataforma";
            this.lblAgregarPlataforma.Size = new System.Drawing.Size(146, 20);
            this.lblAgregarPlataforma.TabIndex = 42;
            this.lblAgregarPlataforma.Text = "Agregar plataforma";
            // 
            // lblFirmaApk
            // 
            this.lblFirmaApk.AutoSize = true;
            this.lblFirmaApk.Location = new System.Drawing.Point(42, 250);
            this.lblFirmaApk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirmaApk.Name = "lblFirmaApk";
            this.lblFirmaApk.Size = new System.Drawing.Size(86, 20);
            this.lblFirmaApk.TabIndex = 44;
            this.lblFirmaApk.Text = "Firmar Apk";
            // 
            // checkFirmarApk
            // 
            this.checkFirmarApk.AutoSize = true;
            this.checkFirmarApk.Location = new System.Drawing.Point(13, 249);
            this.checkFirmarApk.Name = "checkFirmarApk";
            this.checkFirmarApk.Size = new System.Drawing.Size(22, 21);
            this.checkFirmarApk.TabIndex = 43;
            this.checkFirmarApk.UseVisualStyleBackColor = true;
            // 
            // btnCompilarApk
            // 
            this.btnCompilarApk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompilarApk.BackgroundImage")));
            this.btnCompilarApk.FlatAppearance.BorderSize = 0;
            this.btnCompilarApk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompilarApk.Location = new System.Drawing.Point(250, 210);
            this.btnCompilarApk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompilarApk.Name = "btnCompilarApk";
            this.btnCompilarApk.Size = new System.Drawing.Size(62, 63);
            this.btnCompilarApk.TabIndex = 45;
            this.btnCompilarApk.UseVisualStyleBackColor = true;
            this.btnCompilarApk.Click += new System.EventHandler(this.btnCompilarApk_Click);
            // 
            // CompilarApkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 293);
            this.Controls.Add(this.btnCompilarApk);
            this.Controls.Add(this.lblFirmaApk);
            this.Controls.Add(this.checkFirmarApk);
            this.Controls.Add(this.lblAgregarPlataforma);
            this.Controls.Add(this.checkAgregarPlataforma);
            this.Controls.Add(this.lblSeleccionarEntornoApk);
            this.Controls.Add(this.cmbSeleccionarEntorno);
            this.Controls.Add(this.lblSeleccionarProyectoApk);
            this.Controls.Add(this.cmbProyectosApk);
            this.Name = "CompilarApkForm";
            this.Text = "CompilarApkForm";
            this.Load += new System.EventHandler(this.CompilarApkForm_Load);
            this.Controls.SetChildIndex(this.cmbProyectosApk, 0);
            this.Controls.SetChildIndex(this.lblSeleccionarProyectoApk, 0);
            this.Controls.SetChildIndex(this.cmbSeleccionarEntorno, 0);
            this.Controls.SetChildIndex(this.lblSeleccionarEntornoApk, 0);
            this.Controls.SetChildIndex(this.checkAgregarPlataforma, 0);
            this.Controls.SetChildIndex(this.lblAgregarPlataforma, 0);
            this.Controls.SetChildIndex(this.checkFirmarApk, 0);
            this.Controls.SetChildIndex(this.lblFirmaApk, 0);
            this.Controls.SetChildIndex(this.btnCompilarApk, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarProyectoApk;
        private System.Windows.Forms.ComboBox cmbProyectosApk;
        private System.Windows.Forms.ComboBox cmbSeleccionarEntorno;
        private System.Windows.Forms.Label lblSeleccionarEntornoApk;
        private System.Windows.Forms.CheckBox checkAgregarPlataforma;
        private System.Windows.Forms.Label lblAgregarPlataforma;
        private System.Windows.Forms.Label lblFirmaApk;
        private System.Windows.Forms.CheckBox checkFirmarApk;
        private System.Windows.Forms.Button btnCompilarApk;
    }
}
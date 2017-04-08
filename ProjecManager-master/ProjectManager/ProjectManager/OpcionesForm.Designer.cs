namespace ProjectManager
{
    partial class OpcionesForm
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
            this.btnCompilar = new System.Windows.Forms.Button();
            this.btnDeployar = new System.Windows.Forms.Button();
            this.cmbServidores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cLBPiezas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(12, 29);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(136, 38);
            this.btnCompilar.TabIndex = 0;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // btnDeployar
            // 
            this.btnDeployar.Location = new System.Drawing.Point(12, 89);
            this.btnDeployar.Name = "btnDeployar";
            this.btnDeployar.Size = new System.Drawing.Size(136, 40);
            this.btnDeployar.TabIndex = 1;
            this.btnDeployar.Text = "Deployar";
            this.btnDeployar.UseVisualStyleBackColor = true;
            this.btnDeployar.Click += new System.EventHandler(this.btnDeployar_Click);
            // 
            // cmbServidores
            // 
            this.cmbServidores.FormattingEnabled = true;
            this.cmbServidores.Location = new System.Drawing.Point(155, 107);
            this.cmbServidores.Name = "cmbServidores";
            this.cmbServidores.Size = new System.Drawing.Size(178, 21);
            this.cmbServidores.TabIndex = 2;
            this.cmbServidores.SelectedIndexChanged += new System.EventHandler(this.cmbServidores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione el proyecto";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(155, 47);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(178, 21);
            this.cmbProyectos.TabIndex = 4;
            this.cmbProyectos.SelectedIndexChanged += new System.EventHandler(this.cmbProyectos_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Seleccione una opcion.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione las piezas a deployar";
            // 
            // cLBPiezas
            // 
            this.cLBPiezas.BackColor = System.Drawing.SystemColors.Control;
            this.cLBPiezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cLBPiezas.FormattingEnabled = true;
            this.cLBPiezas.Location = new System.Drawing.Point(16, 158);
            this.cLBPiezas.Name = "cLBPiezas";
            this.cLBPiezas.Size = new System.Drawing.Size(317, 90);
            this.cLBPiezas.TabIndex = 10;
            // 
            // OpcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.cLBPiezas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProyectos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbServidores);
            this.Controls.Add(this.btnDeployar);
            this.Controls.Add(this.btnCompilar);
            this.Name = "OpcionesForm";
            this.Text = "OpcionesForm";
            this.Load += new System.EventHandler(this.OpcionesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.Button btnDeployar;
        private System.Windows.Forms.ComboBox cmbServidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProyectos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cLBPiezas;
    }
}
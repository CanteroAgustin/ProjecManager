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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesForm));
            this.btnCompilar = new System.Windows.Forms.Button();
            this.btnDeployar = new System.Windows.Forms.Button();
            this.cmbServidores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cLBPiezas = new System.Windows.Forms.CheckedListBox();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnEliminarServidor = new System.Windows.Forms.Button();
            this.btnAgregarServidor = new System.Windows.Forms.Button();
            this.btnAgregarProyecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(16, 186);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(136, 28);
            this.btnCompilar.TabIndex = 0;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // btnDeployar
            // 
            this.btnDeployar.Location = new System.Drawing.Point(158, 186);
            this.btnDeployar.Name = "btnDeployar";
            this.btnDeployar.Size = new System.Drawing.Size(136, 28);
            this.btnDeployar.TabIndex = 1;
            this.btnDeployar.Text = "Deployar";
            this.btnDeployar.UseVisualStyleBackColor = true;
            this.btnDeployar.Click += new System.EventHandler(this.btnDeployar_Click);
            // 
            // cmbServidores
            // 
            this.cmbServidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServidores.FormattingEnabled = true;
            this.cmbServidores.Location = new System.Drawing.Point(16, 124);
            this.cmbServidores.Name = "cmbServidores";
            this.cmbServidores.Size = new System.Drawing.Size(178, 21);
            this.cmbServidores.TabIndex = 2;
            this.cmbServidores.SelectedIndexChanged += new System.EventHandler(this.cmbServidores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione el proyecto";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(16, 62);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(178, 21);
            this.cmbProyectos.Sorted = true;
            this.cmbProyectos.TabIndex = 4;
            this.cmbProyectos.SelectedIndexChanged += new System.EventHandler(this.cmbProyectos_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(14, 160);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Seleccione una opcion.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 40);
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
            this.cLBPiezas.Location = new System.Drawing.Point(261, 62);
            this.cLBPiezas.Name = "cLBPiezas";
            this.cLBPiezas.Size = new System.Drawing.Size(191, 105);
            this.cLBPiezas.TabIndex = 10;
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyecto.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(220, 60);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(21, 23);
            this.btnEliminarProyecto.TabIndex = 11;
            this.btnEliminarProyecto.Text = "-";
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnEliminarServidor
            // 
            this.btnEliminarServidor.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarServidor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarServidor.FlatAppearance.BorderSize = 0;
            this.btnEliminarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServidor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServidor.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarServidor.Location = new System.Drawing.Point(220, 121);
            this.btnEliminarServidor.Name = "btnEliminarServidor";
            this.btnEliminarServidor.Size = new System.Drawing.Size(21, 23);
            this.btnEliminarServidor.TabIndex = 12;
            this.btnEliminarServidor.Text = "-";
            this.btnEliminarServidor.UseVisualStyleBackColor = false;
            this.btnEliminarServidor.Click += new System.EventHandler(this.btnEliminarServidor_Click);
            // 
            // btnAgregarServidor
            // 
            this.btnAgregarServidor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarServidor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarServidor.FlatAppearance.BorderSize = 0;
            this.btnAgregarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServidor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServidor.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarServidor.Location = new System.Drawing.Point(200, 121);
            this.btnAgregarServidor.Name = "btnAgregarServidor";
            this.btnAgregarServidor.Size = new System.Drawing.Size(21, 23);
            this.btnAgregarServidor.TabIndex = 14;
            this.btnAgregarServidor.Text = "+";
            this.btnAgregarServidor.UseVisualStyleBackColor = false;
            this.btnAgregarServidor.Click += new System.EventHandler(this.btnAgregarServidor_Click);
            // 
            // btnAgregarProyecto
            // 
            this.btnAgregarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarProyecto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyecto.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyecto.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarProyecto.Location = new System.Drawing.Point(200, 60);
            this.btnAgregarProyecto.Name = "btnAgregarProyecto";
            this.btnAgregarProyecto.Size = new System.Drawing.Size(21, 23);
            this.btnAgregarProyecto.TabIndex = 15;
            this.btnAgregarProyecto.Text = "+";
            this.btnAgregarProyecto.UseVisualStyleBackColor = false;
            this.btnAgregarProyecto.Click += new System.EventHandler(this.btnAgregarProyecto_Click);
            // 
            // OpcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 240);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarProyecto);
            this.Controls.Add(this.btnAgregarServidor);
            this.Controls.Add(this.btnEliminarServidor);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.cLBPiezas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProyectos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbServidores);
            this.Controls.Add(this.btnDeployar);
            this.Controls.Add(this.btnCompilar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpcionesForm";
            this.Load += new System.EventHandler(this.OpcionesForm_Load);
            this.Controls.SetChildIndex(this.btnCompilar, 0);
            this.Controls.SetChildIndex(this.btnDeployar, 0);
            this.Controls.SetChildIndex(this.cmbServidores, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbProyectos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cLBPiezas, 0);
            this.Controls.SetChildIndex(this.btnEliminarProyecto, 0);
            this.Controls.SetChildIndex(this.btnEliminarServidor, 0);
            this.Controls.SetChildIndex(this.btnAgregarServidor, 0);
            this.Controls.SetChildIndex(this.btnAgregarProyecto, 0);
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
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Button btnEliminarServidor;
        private System.Windows.Forms.Button btnAgregarServidor;
        private System.Windows.Forms.Button btnAgregarProyecto;
    }
}
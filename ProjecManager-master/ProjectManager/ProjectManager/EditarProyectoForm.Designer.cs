namespace ProjectManager
{
    partial class EditarProyectoForm
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
            this.cmbProyectosAEditar = new System.Windows.Forms.ComboBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevaRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.btnCancelAddApp = new System.Windows.Forms.Button();
            this.btnAcceptAddApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProyectosAEditar
            // 
            this.cmbProyectosAEditar.FormattingEnabled = true;
            this.cmbProyectosAEditar.Location = new System.Drawing.Point(12, 40);
            this.cmbProyectosAEditar.Name = "cmbProyectosAEditar";
            this.cmbProyectosAEditar.Size = new System.Drawing.Size(160, 21);
            this.cmbProyectosAEditar.TabIndex = 31;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(13, 94);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 32;
            // 
            // txtNuevaRuta
            // 
            this.txtNuevaRuta.Location = new System.Drawing.Point(12, 141);
            this.txtNuevaRuta.Name = "txtNuevaRuta";
            this.txtNuevaRuta.Size = new System.Drawing.Size(355, 20);
            this.txtNuevaRuta.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nuevo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nueva Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seleccione el proyecto a modificar";
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.Location = new System.Drawing.Point(373, 141);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(27, 21);
            this.btnAgregarRuta.TabIndex = 37;
            this.btnAgregarRuta.Text = "...";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnCancelAddApp
            // 
            this.btnCancelAddApp.Location = new System.Drawing.Point(151, 178);
            this.btnCancelAddApp.Name = "btnCancelAddApp";
            this.btnCancelAddApp.Size = new System.Drawing.Size(124, 28);
            this.btnCancelAddApp.TabIndex = 39;
            this.btnCancelAddApp.Text = "Cancelar";
            this.btnCancelAddApp.UseVisualStyleBackColor = true;
            this.btnCancelAddApp.Click += new System.EventHandler(this.btnCancelAddApp_Click);
            // 
            // btnAcceptAddApp
            // 
            this.btnAcceptAddApp.Location = new System.Drawing.Point(16, 178);
            this.btnAcceptAddApp.Name = "btnAcceptAddApp";
            this.btnAcceptAddApp.Size = new System.Drawing.Size(129, 28);
            this.btnAcceptAddApp.TabIndex = 38;
            this.btnAcceptAddApp.Text = "Aceptar";
            this.btnAcceptAddApp.UseVisualStyleBackColor = true;
            this.btnAcceptAddApp.Click += new System.EventHandler(this.btnEditarProyecto_Click);
            // 
            // EditarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 218);
            this.Controls.Add(this.btnCancelAddApp);
            this.Controls.Add(this.btnAcceptAddApp);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevaRuta);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.cmbProyectosAEditar);
            this.Name = "EditarProyecto";
            this.Text = "EditarProyecto";
            this.Load += new System.EventHandler(this.EditarProyecto_Load);
            this.Controls.SetChildIndex(this.cmbProyectosAEditar, 0);
            this.Controls.SetChildIndex(this.txtNuevoNombre, 0);
            this.Controls.SetChildIndex(this.txtNuevaRuta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAgregarRuta, 0);
            this.Controls.SetChildIndex(this.btnAcceptAddApp, 0);
            this.Controls.SetChildIndex(this.btnCancelAddApp, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProyectosAEditar;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevaRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Button btnCancelAddApp;
        private System.Windows.Forms.Button btnAcceptAddApp;
    }
}
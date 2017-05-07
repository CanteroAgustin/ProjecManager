namespace ProjectManager
{
    partial class EditarServidorForm
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
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaRuta = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.cmbServidoresAEditar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Location = new System.Drawing.Point(151, 178);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(124, 28);
            this.btnCancelarEdicion.TabIndex = 48;
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.Location = new System.Drawing.Point(16, 178);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(129, 28);
            this.btnAceptarEdicion.TabIndex = 47;
            this.btnAceptarEdicion.Text = "Aceptar";
            this.btnAceptarEdicion.UseVisualStyleBackColor = true;
            this.btnAceptarEdicion.Click += new System.EventHandler(this.btnAceptarEdicion_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.Location = new System.Drawing.Point(373, 141);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(27, 21);
            this.btnAgregarRuta.TabIndex = 46;
            this.btnAgregarRuta.Text = "...";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Seleccione el servidor a modificar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nueva Ruta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nuevo Nombre";
            // 
            // txtNuevaRuta
            // 
            this.txtNuevaRuta.Location = new System.Drawing.Point(12, 141);
            this.txtNuevaRuta.Name = "txtNuevaRuta";
            this.txtNuevaRuta.Size = new System.Drawing.Size(355, 20);
            this.txtNuevaRuta.TabIndex = 42;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(13, 94);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 41;
            // 
            // cmbServidoresAEditar
            // 
            this.cmbServidoresAEditar.FormattingEnabled = true;
            this.cmbServidoresAEditar.Location = new System.Drawing.Point(12, 40);
            this.cmbServidoresAEditar.Name = "cmbServidoresAEditar";
            this.cmbServidoresAEditar.Size = new System.Drawing.Size(160, 21);
            this.cmbServidoresAEditar.TabIndex = 40;
            this.cmbServidoresAEditar.SelectedIndexChanged += new System.EventHandler(this.cmbServidoresAEditar_SelectedIndexChanged);
            // 
            // EditarServidorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 218);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnAceptarEdicion);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevaRuta);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.cmbServidoresAEditar);
            this.Name = "EditarServidorForm";
            this.Text = "EditarServidoresForm";
            this.Load += new System.EventHandler(this.EditarServidoresForm_Load);
            this.Controls.SetChildIndex(this.cmbServidoresAEditar, 0);
            this.Controls.SetChildIndex(this.txtNuevoNombre, 0);
            this.Controls.SetChildIndex(this.txtNuevaRuta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAgregarRuta, 0);
            this.Controls.SetChildIndex(this.btnAceptarEdicion, 0);
            this.Controls.SetChildIndex(this.btnCancelarEdicion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevaRuta;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.ComboBox cmbServidoresAEditar;
    }
}
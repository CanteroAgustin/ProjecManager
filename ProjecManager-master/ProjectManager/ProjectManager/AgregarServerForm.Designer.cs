namespace ProjectManager
{
    partial class AddServerForm
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
            this.txtNameAddApp = new System.Windows.Forms.TextBox();
            this.txtPathAddApp = new System.Windows.Forms.TextBox();
            this.lblNameAddApp = new System.Windows.Forms.Label();
            this.lblPathAddApp = new System.Windows.Forms.Label();
            this.btnGuardarServidor = new System.Windows.Forms.Button();
            this.btnCancelAddApp = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameAddApp
            // 
            this.txtNameAddApp.Location = new System.Drawing.Point(12, 40);
            this.txtNameAddApp.Name = "txtNameAddApp";
            this.txtNameAddApp.Size = new System.Drawing.Size(129, 20);
            this.txtNameAddApp.TabIndex = 0;
            // 
            // txtPathAddApp
            // 
            this.txtPathAddApp.Location = new System.Drawing.Point(12, 66);
            this.txtPathAddApp.Name = "txtPathAddApp";
            this.txtPathAddApp.Size = new System.Drawing.Size(355, 20);
            this.txtPathAddApp.TabIndex = 1;
            // 
            // lblNameAddApp
            // 
            this.lblNameAddApp.AutoSize = true;
            this.lblNameAddApp.Location = new System.Drawing.Point(147, 43);
            this.lblNameAddApp.Name = "lblNameAddApp";
            this.lblNameAddApp.Size = new System.Drawing.Size(44, 13);
            this.lblNameAddApp.TabIndex = 2;
            this.lblNameAddApp.Text = "Nombre";
            // 
            // lblPathAddApp
            // 
            this.lblPathAddApp.AutoSize = true;
            this.lblPathAddApp.Location = new System.Drawing.Point(406, 69);
            this.lblPathAddApp.Name = "lblPathAddApp";
            this.lblPathAddApp.Size = new System.Drawing.Size(30, 13);
            this.lblPathAddApp.TabIndex = 3;
            this.lblPathAddApp.Text = "Ruta";
            // 
            // btnGuardarServidor
            // 
            this.btnGuardarServidor.Location = new System.Drawing.Point(12, 92);
            this.btnGuardarServidor.Name = "btnGuardarServidor";
            this.btnGuardarServidor.Size = new System.Drawing.Size(129, 28);
            this.btnGuardarServidor.TabIndex = 4;
            this.btnGuardarServidor.Text = "Aceptar";
            this.btnGuardarServidor.UseVisualStyleBackColor = true;
            this.btnGuardarServidor.Click += new System.EventHandler(this.btnGuardarServidor_Click);
            // 
            // btnCancelAddApp
            // 
            this.btnCancelAddApp.Location = new System.Drawing.Point(147, 92);
            this.btnCancelAddApp.Name = "btnCancelAddApp";
            this.btnCancelAddApp.Size = new System.Drawing.Size(124, 28);
            this.btnCancelAddApp.TabIndex = 5;
            this.btnCancelAddApp.Text = "Cancelar";
            this.btnCancelAddApp.UseVisualStyleBackColor = true;
            this.btnCancelAddApp.Click += new System.EventHandler(this.btnCancelAddApp_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.Location = new System.Drawing.Point(373, 66);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(27, 21);
            this.btnAgregarRuta.TabIndex = 11;
            this.btnAgregarRuta.Text = "...";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // AddServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 136);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.btnCancelAddApp);
            this.Controls.Add(this.btnGuardarServidor);
            this.Controls.Add(this.lblPathAddApp);
            this.Controls.Add(this.lblNameAddApp);
            this.Controls.Add(this.txtPathAddApp);
            this.Controls.Add(this.txtNameAddApp);
            this.Name = "AddServerForm";
            this.Text = "Nuevo Servidor";
            this.Load += new System.EventHandler(this.AddServerForm_Load_1);
            this.Controls.SetChildIndex(this.txtNameAddApp, 0);
            this.Controls.SetChildIndex(this.txtPathAddApp, 0);
            this.Controls.SetChildIndex(this.lblNameAddApp, 0);
            this.Controls.SetChildIndex(this.lblPathAddApp, 0);
            this.Controls.SetChildIndex(this.btnGuardarServidor, 0);
            this.Controls.SetChildIndex(this.btnCancelAddApp, 0);
            this.Controls.SetChildIndex(this.btnAgregarRuta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameAddApp;
        private System.Windows.Forms.TextBox txtPathAddApp;
        private System.Windows.Forms.Label lblNameAddApp;
        private System.Windows.Forms.Label lblPathAddApp;
        private System.Windows.Forms.Button btnGuardarServidor;
        private System.Windows.Forms.Button btnCancelAddApp;
        private System.Windows.Forms.Button btnAgregarRuta;
    }
}
namespace ProjectManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(-11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrincipal.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrincipal.Location = new System.Drawing.Point(-78, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(376, 55);
            this.lblPrincipal.TabIndex = 14;
            this.lblPrincipal.Text = "Proyect";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(15, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(248, 40);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnAddServer
            // 
            this.btnAddServer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddServer.FlatAppearance.BorderSize = 0;
            this.btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServer.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddServer.Image")));
            this.btnAddServer.Location = new System.Drawing.Point(15, 213);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(248, 40);
            this.btnAddServer.TabIndex = 10;
            this.btnAddServer.Text = "Servidores";
            this.btnAddServer.UseVisualStyleBackColor = false;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnDeploy
            // 
            this.btnDeploy.BackColor = System.Drawing.Color.Transparent;
            this.btnDeploy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeploy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeploy.FlatAppearance.BorderSize = 0;
            this.btnDeploy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeploy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeploy.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploy.Image = ((System.Drawing.Image)(resources.GetObject("btnDeploy.Image")));
            this.btnDeploy.Location = new System.Drawing.Point(15, 121);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(248, 40);
            this.btnDeploy.TabIndex = 12;
            this.btnDeploy.Text = "Compilar/Deployar";
            this.btnDeploy.UseVisualStyleBackColor = false;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddApp.FlatAppearance.BorderSize = 0;
            this.btnAddApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddApp.Image")));
            this.btnAddApp.Location = new System.Drawing.Point(15, 167);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(248, 40);
            this.btnAddApp.TabIndex = 11;
            this.btnAddApp.Text = "Proyectos";
            this.btnAddApp.UseVisualStyleBackColor = false;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(278, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.btnAddApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.Button btnAddApp;

    }
}


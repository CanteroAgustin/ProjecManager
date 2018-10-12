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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesForm));
            this.btnCompilar = new System.Windows.Forms.Button();
            this.btnDeployar = new System.Windows.Forms.Button();
            this.cmbServidores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cLBPiezas = new System.Windows.Forms.CheckedListBox();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnAgregarProyecto = new System.Windows.Forms.Button();
            this.tTAgregarProyecto = new System.Windows.Forms.ToolTip(this.components);
            this.tTEliminarProyecto = new System.Windows.Forms.ToolTip(this.components);
            this.tTAgregarServidor = new System.Windows.Forms.ToolTip(this.components);
            this.tTEliminarServidor = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditarProyecto = new System.Windows.Forms.Button();
            this.panelBotonesProyecto = new System.Windows.Forms.Panel();
            this.panelBotonesServidor = new System.Windows.Forms.Panel();
            this.btnAgregarServidor = new System.Windows.Forms.Button();
            this.btnEditarServidor = new System.Windows.Forms.Button();
            this.btnEliminarServidor = new System.Windows.Forms.Button();
            this.tTCompilar = new System.Windows.Forms.ToolTip(this.components);
            this.tTDesplegar = new System.Windows.Forms.ToolTip(this.components);
            this.tTEditarProyecto = new System.Windows.Forms.ToolTip(this.components);
            this.tTEditarServidor = new System.Windows.Forms.ToolTip(this.components);
            this.checkConsola = new System.Windows.Forms.CheckBox();
            this.tTcheckConsola = new System.Windows.Forms.ToolTip(this.components);
            this.btnCompilarAPK = new System.Windows.Forms.Button();
            this.tTCompilarApk = new System.Windows.Forms.ToolTip(this.components);
            this.panelBotonesProyecto.SuspendLayout();
            this.panelBotonesServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompilar
            // 
            this.btnCompilar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompilar.BackgroundImage")));
            this.btnCompilar.FlatAppearance.BorderSize = 0;
            this.btnCompilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompilar.Location = new System.Drawing.Point(439, 77);
            this.btnCompilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(62, 63);
            this.btnCompilar.TabIndex = 0;
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // btnDeployar
            // 
            this.btnDeployar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeployar.BackgroundImage")));
            this.btnDeployar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeployar.FlatAppearance.BorderSize = 0;
            this.btnDeployar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployar.Location = new System.Drawing.Point(439, 173);
            this.btnDeployar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeployar.Name = "btnDeployar";
            this.btnDeployar.Size = new System.Drawing.Size(62, 63);
            this.btnDeployar.TabIndex = 1;
            this.btnDeployar.UseVisualStyleBackColor = true;
            this.btnDeployar.Click += new System.EventHandler(this.btnDeployar_Click);
            // 
            // cmbServidores
            // 
            this.cmbServidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServidores.FormattingEnabled = true;
            this.cmbServidores.Location = new System.Drawing.Point(24, 191);
            this.cmbServidores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbServidores.Name = "cmbServidores";
            this.cmbServidores.Size = new System.Drawing.Size(265, 28);
            this.cmbServidores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione el proyecto";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(24, 95);
            this.cmbProyectos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(265, 28);
            this.cmbProyectos.Sorted = true;
            this.cmbProyectos.TabIndex = 4;
            this.cmbProyectos.SelectedIndexChanged += new System.EventHandler(this.cmbProyectos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione las piezas a desplegar";
            // 
            // cLBPiezas
            // 
            this.cLBPiezas.BackColor = System.Drawing.SystemColors.Control;
            this.cLBPiezas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLBPiezas.FormattingEnabled = true;
            this.cLBPiezas.Location = new System.Drawing.Point(17, 294);
            this.cLBPiezas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cLBPiezas.Name = "cLBPiezas";
            this.cLBPiezas.Size = new System.Drawing.Size(575, 233);
            this.cLBPiezas.TabIndex = 10;
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyecto.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(64, -9);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 40);
            this.btnEliminarProyecto.TabIndex = 11;
            this.btnEliminarProyecto.Text = "x";
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnAgregarProyecto
            // 
            this.btnAgregarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarProyecto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyecto.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyecto.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarProyecto.Location = new System.Drawing.Point(4, -8);
            this.btnAgregarProyecto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarProyecto.Name = "btnAgregarProyecto";
            this.btnAgregarProyecto.Size = new System.Drawing.Size(32, 35);
            this.btnAgregarProyecto.TabIndex = 15;
            this.btnAgregarProyecto.Text = "+";
            this.btnAgregarProyecto.UseVisualStyleBackColor = false;
            this.btnAgregarProyecto.Click += new System.EventHandler(this.btnAgregarProyecto_Click);
            // 
            // btnEditarProyecto
            // 
            this.btnEditarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarProyecto.BackgroundImage")));
            this.btnEditarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarProyecto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEditarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProyecto.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProyecto.ForeColor = System.Drawing.Color.Red;
            this.btnEditarProyecto.Location = new System.Drawing.Point(40, 8);
            this.btnEditarProyecto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarProyecto.Name = "btnEditarProyecto";
            this.btnEditarProyecto.Size = new System.Drawing.Size(21, 23);
            this.btnEditarProyecto.TabIndex = 31;
            this.btnEditarProyecto.UseVisualStyleBackColor = false;
            this.btnEditarProyecto.Click += new System.EventHandler(this.btnEditarProyecto_Click);
            // 
            // panelBotonesProyecto
            // 
            this.panelBotonesProyecto.Controls.Add(this.btnAgregarProyecto);
            this.panelBotonesProyecto.Controls.Add(this.btnEditarProyecto);
            this.panelBotonesProyecto.Controls.Add(this.btnEliminarProyecto);
            this.panelBotonesProyecto.Location = new System.Drawing.Point(300, 98);
            this.panelBotonesProyecto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBotonesProyecto.Name = "panelBotonesProyecto";
            this.panelBotonesProyecto.Size = new System.Drawing.Size(100, 29);
            this.panelBotonesProyecto.TabIndex = 33;
            // 
            // panelBotonesServidor
            // 
            this.panelBotonesServidor.Controls.Add(this.btnAgregarServidor);
            this.panelBotonesServidor.Controls.Add(this.btnEditarServidor);
            this.panelBotonesServidor.Controls.Add(this.btnEliminarServidor);
            this.panelBotonesServidor.Location = new System.Drawing.Point(300, 194);
            this.panelBotonesServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBotonesServidor.Name = "panelBotonesServidor";
            this.panelBotonesServidor.Size = new System.Drawing.Size(100, 29);
            this.panelBotonesServidor.TabIndex = 34;
            // 
            // btnAgregarServidor
            // 
            this.btnAgregarServidor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarServidor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarServidor.FlatAppearance.BorderSize = 0;
            this.btnAgregarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServidor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServidor.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarServidor.Location = new System.Drawing.Point(4, -8);
            this.btnAgregarServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarServidor.Name = "btnAgregarServidor";
            this.btnAgregarServidor.Size = new System.Drawing.Size(32, 35);
            this.btnAgregarServidor.TabIndex = 15;
            this.btnAgregarServidor.Text = "+";
            this.btnAgregarServidor.UseVisualStyleBackColor = false;
            this.btnAgregarServidor.Click += new System.EventHandler(this.btnAgregarServidor_Click);
            // 
            // btnEditarServidor
            // 
            this.btnEditarServidor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarServidor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarServidor.BackgroundImage")));
            this.btnEditarServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarServidor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditarServidor.FlatAppearance.BorderSize = 0;
            this.btnEditarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarServidor.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServidor.ForeColor = System.Drawing.Color.Red;
            this.btnEditarServidor.Location = new System.Drawing.Point(40, 8);
            this.btnEditarServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarServidor.Name = "btnEditarServidor";
            this.btnEditarServidor.Size = new System.Drawing.Size(21, 23);
            this.btnEditarServidor.TabIndex = 31;
            this.btnEditarServidor.UseVisualStyleBackColor = false;
            this.btnEditarServidor.Click += new System.EventHandler(this.btnEditarServidor_Click);
            // 
            // btnEliminarServidor
            // 
            this.btnEliminarServidor.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarServidor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarServidor.FlatAppearance.BorderSize = 0;
            this.btnEliminarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServidor.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServidor.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarServidor.Location = new System.Drawing.Point(64, -9);
            this.btnEliminarServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarServidor.Name = "btnEliminarServidor";
            this.btnEliminarServidor.Size = new System.Drawing.Size(32, 40);
            this.btnEliminarServidor.TabIndex = 11;
            this.btnEliminarServidor.Text = "x";
            this.btnEliminarServidor.UseVisualStyleBackColor = false;
            this.btnEliminarServidor.Click += new System.EventHandler(this.btnEliminarServidor_Click);
            // 
            // checkConsola
            // 
            this.checkConsola.AutoSize = true;
            this.checkConsola.Location = new System.Drawing.Point(407, 102);
            this.checkConsola.Name = "checkConsola";
            this.checkConsola.Size = new System.Drawing.Size(22, 21);
            this.checkConsola.TabIndex = 35;
            this.checkConsola.UseVisualStyleBackColor = true;
            // 
            // btnCompilarAPK
            // 
            this.btnCompilarAPK.BackColor = System.Drawing.Color.Transparent;
            this.btnCompilarAPK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompilarAPK.BackgroundImage")));
            this.btnCompilarAPK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCompilarAPK.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCompilarAPK.FlatAppearance.BorderSize = 0;
            this.btnCompilarAPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompilarAPK.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompilarAPK.ForeColor = System.Drawing.Color.Red;
            this.btnCompilarAPK.Location = new System.Drawing.Point(509, 98);
            this.btnCompilarAPK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompilarAPK.Name = "btnCompilarAPK";
            this.btnCompilarAPK.Size = new System.Drawing.Size(89, 111);
            this.btnCompilarAPK.TabIndex = 1;
            this.btnCompilarAPK.UseVisualStyleBackColor = false;
            this.btnCompilarAPK.Click += new System.EventHandler(this.btnCompilarAPK_Click);
            // 
            // tTCompilarApk
            // 
            this.tTCompilarApk.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // OpcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 547);
            this.ControlBox = false;
            this.Controls.Add(this.btnCompilarAPK);
            this.Controls.Add(this.checkConsola);
            this.Controls.Add(this.panelBotonesServidor);
            this.Controls.Add(this.panelBotonesProyecto);
            this.Controls.Add(this.cLBPiezas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProyectos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbServidores);
            this.Controls.Add(this.btnDeployar);
            this.Controls.Add(this.btnCompilar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "OpcionesForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.OpcionesForm_Load);
            this.Controls.SetChildIndex(this.btnCompilar, 0);
            this.Controls.SetChildIndex(this.btnDeployar, 0);
            this.Controls.SetChildIndex(this.cmbServidores, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbProyectos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cLBPiezas, 0);
            this.Controls.SetChildIndex(this.panelBotonesProyecto, 0);
            this.Controls.SetChildIndex(this.panelBotonesServidor, 0);
            this.Controls.SetChildIndex(this.checkConsola, 0);
            this.Controls.SetChildIndex(this.btnCompilarAPK, 0);
            this.panelBotonesProyecto.ResumeLayout(false);
            this.panelBotonesServidor.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cLBPiezas;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Button btnAgregarProyecto;
        private System.Windows.Forms.ToolTip tTAgregarProyecto;
        private System.Windows.Forms.ToolTip tTEliminarProyecto;
        private System.Windows.Forms.ToolTip tTAgregarServidor;
        private System.Windows.Forms.ToolTip tTEliminarServidor;
        private System.Windows.Forms.Button btnEditarProyecto;
        private System.Windows.Forms.Panel panelBotonesProyecto;
        private System.Windows.Forms.Panel panelBotonesServidor;
        private System.Windows.Forms.Button btnAgregarServidor;
        private System.Windows.Forms.Button btnEditarServidor;
        private System.Windows.Forms.Button btnEliminarServidor;
        private System.Windows.Forms.ToolTip tTCompilar;
        private System.Windows.Forms.ToolTip tTDesplegar;
        private System.Windows.Forms.ToolTip tTEditarProyecto;
        private System.Windows.Forms.ToolTip tTEditarServidor;
        private System.Windows.Forms.CheckBox checkConsola;
        private System.Windows.Forms.ToolTip tTcheckConsola;
        private System.Windows.Forms.Button btnCompilarAPK;
        private System.Windows.Forms.ToolTip tTCompilarApk;
    }
}
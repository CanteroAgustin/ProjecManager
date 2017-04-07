using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using System.IO;

namespace easyCompileAndDeployApp
{
    public partial class AddAppForm : Form
    {
        public AddAppForm()
        {
            InitializeComponent();
            Form1.ActiveForm.Hide();
        }

        private void AddAppForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAcceptAddApp_Click(object sender, EventArgs e)
        {
            bool guardadoConExito = false;
            bool puedeGuardar = true;
            string curFile = "../../../proyectos.xml";
            List<Apps> listApps = new List<Apps>();
            XmlSerialize<Apps> ser = new XmlSerialize<Apps>();
            if (File.Exists(curFile))
            {
                listApps = ser.DesSerializarXML(listApps, curFile);
            }
            Apps app = new Apps();
            app.Name = txtNameAddApp.Text;
            app.Path = txtPathAddApp.Text;
            
            string wordWithOutWhiteSpaces = txtPiezas.Text.Replace(" ", "");
            
            string[] words = wordWithOutWhiteSpaces.Split(',');
            for (int i = 0; i < words.Count(); i++)
            {
                if (!"".Equals(words[i]))
                app.Piezas.Add(words[i]);
            }

            if (listApps.Count > 0)
            {
                for (int i = 0; i < listApps.Count; i++ )
                {
                    if (listApps[i].Name.Equals(app.Name))
                    {
                        puedeGuardar = false;
                    }
                        
                }

                if (puedeGuardar)
                {
                    listApps.Add(app);
                    guardadoConExito = true;
                }
                else
                {
                    MessageBox.Show("No se puede agregar el proyecto, el nombre ya existe", "",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                listApps.Add(app);
                guardadoConExito = true;
            }
            
            ser.SerializarXML(listApps, curFile);

            if(guardadoConExito)
            this.Close();
        }

        private void btnCancelAddApp_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Show();
            this.Close();
            
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtPathAddApp.Text = fbd.SelectedPath;
        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPiezas.Text += openFileDialog.FileName+",";
                
            }
        }

    }
}

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

namespace ProjectManager
{
    public partial class AddAppForm : Form
    {
        bool vacio = false; // Variable utilizada para saber si hay algún TextBox vacio.

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
            bool volver = this.validarCamposVacios(this);
            if (volver)
            {
                return;
            }

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
                    MessageBox.Show("No se puede agregar el proyecto, el nombre ya existe", "El Proyecto ya existe",
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

        private bool validarCamposVacios(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true) MessageBox.Show("Ningun campo puede quedar vacio."); // Si nuestra variable es verdadera mostramos un mensaje.
            return vacio;
        }

    }
}

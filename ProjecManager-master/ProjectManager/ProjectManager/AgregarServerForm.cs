using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class AddServerForm : Form
    {
        bool vacio = false; // Variable utilizada para saber si hay algún TextBox vacio.

        public AddServerForm()
        {
            InitializeComponent();
            Form1.ActiveForm.Hide();
        }

        private void AddServerForm_Load(object sender, EventArgs e)
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
            string curFile = "../../../servidores.xml";
            List<Server> serversList = new List<Server>();
            XmlSerialize<Server> ser = new XmlSerialize<Server>();
            
            if (File.Exists(curFile))
            {
                serversList = ser.DesSerializarXML(serversList, curFile);
            }

            Server server = new Server();
            server.Name = txtNameAddApp.Text;
            server.Path = txtPathAddApp.Text;

            if (serversList.Count > 0)
            {
                for (int i = 0; i < serversList.Count; i++)
                {
                    if (serversList[i].Name.Equals(server.Name))
                    {
                        puedeGuardar = false;
                    }

                }

                if (puedeGuardar)
                {
                    serversList.Add(server);
                    guardadoConExito = true;
                }
                else
                {
                    MessageBox.Show("No se puede agregar el servidor, ya existe un servidor con ese nombre.", "El servidor ya existe",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                serversList.Add(server);
                guardadoConExito = true;
            }

            ser.SerializarXML(serversList, curFile);

            if (guardadoConExito)
                this.Close();

        }

        private void btnCancelAddApp_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Show();
            this.Close();
        }

        private void AddServerForm_Load_1(object sender, EventArgs e)
        {

        }

        private void txtSources_TextChanged(object sender, EventArgs e)
        {

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

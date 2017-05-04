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
    public partial class EditarServidorForm : Form1
    {

        private static string servidoresXMLPath = "../../../servidores.xml";
        private List<Server> servidoresList = new List<Server>();
        private XmlSerialize<Server> ser = new XmlSerialize<Server>();
        
        public EditarServidorForm()
        {
            InitializeComponent();
        }

        private void EditarServidoresForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(servidoresXMLPath))
                servidoresList = ser.DesSerializarXML(servidoresList, servidoresXMLPath);

            if (servidoresList.Count > 0)
            {
                cmbServidoresAEditar.Items.Clear();
                foreach (Server servidor in servidoresList)
                {
                    cmbServidoresAEditar.Items.Add(servidor.Name);
                }
            }
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            foreach (Server s in servidoresList)
            {
                if (s.Name.Equals(cmbServidoresAEditar.SelectedItem))
                {
                    if (txtNuevoNombre.Text != "")
                        s.Name = txtNuevoNombre.Text;
                    if (txtNuevaRuta.Text != "")
                        s.Path = txtNuevaRuta.Text;

                    ser.SerializarXML(servidoresList, servidoresXMLPath);
                    break;
                }
            }
            
            this.Close();
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Show();
            this.Close();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtNuevaRuta.Text = fbd.SelectedPath;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class EditarProyectoForm : Form1
    {
        private List<Apps> proyectosList = new List<Apps>();
        private static string pathProyectos = "../../../proyectos.xml";
        private XmlSerialize<Apps> ser = new XmlSerialize<Apps>();
        

        public EditarProyectoForm()
        {
            InitializeComponent();
        }

        private void EditarProyecto_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathProyectos))
                proyectosList = ser.DesSerializarXML(proyectosList, pathProyectos);

            if (proyectosList.Count > 0)
            {
                cmbProyectosAEditar.Items.Clear();
                foreach (Apps app in proyectosList)
                {
                    cmbProyectosAEditar.Items.Add(app.Name);
                }
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtNuevaRuta.Text = fbd.SelectedPath;
        }

        private void btnCancelAddApp_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Show();
            this.Close();
        }

        private void btnEditarProyecto_Click(object sender, EventArgs e)
        {
            foreach (Apps p in proyectosList)
            {
                if (p.Name.Equals(cmbProyectosAEditar.SelectedItem))
                {
                    if(txtNuevoNombre.Text != "")
                        p.Name = txtNuevoNombre.Text;
                    if(txtNuevaRuta.Text != "")
                        p.Path = txtNuevaRuta.Text;

                    ser.SerializarXML(proyectosList, pathProyectos);
                    break;
                }
            }
            this.Close();
        }

        private void cmbProyectosAEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Apps p in proyectosList)
            {
                if (p.Name.Equals(cmbProyectosAEditar.SelectedItem))
                {
                    txtNuevoNombre.Text = p.Name;
                    txtNuevaRuta.Text = p.Path;
                    break;
                }
            }
        }
    }
}

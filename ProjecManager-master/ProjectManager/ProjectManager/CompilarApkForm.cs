using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ProjectManager
{
    public partial class CompilarApkForm : Form1
    {
        private static string pathProyectos = "../../../proyectos.xml";
        delegate void SetEnabledButtonCallback(bool flag);
        private List<Apps> proyectosList = new List<Apps>();
        private String entorno = "";
        private XmlSerialize<Apps> ser = new XmlSerialize<Apps>();
        
        public bool vacio; 

        public CompilarApkForm()
        {
            InitializeComponent();
        }

        private void CompilarApkForm_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("DESARROLLO");
            lista.Add("TESTING");
            lista.Add("PRODUCCION");
            cmbSeleccionarEntorno.DataSource = lista;
            if (File.Exists(pathProyectos))
                proyectosList = ser.DesSerializarXML(proyectosList, pathProyectos);

            if (proyectosList.Count > 0)
            {
                cmbProyectosApk.Items.Clear();
                foreach (Apps app in proyectosList)
                {
                    cmbProyectosApk.Items.Add(app.Name);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompilarApk_Click(object sender, EventArgs e)
        {
            validar(this);
            if (proyectosList.Count > 0)
            {
                foreach (Apps app in proyectosList)
                {
                    if (app.Name.Equals(cmbProyectosApk.SelectedItem))
                    {
                        entorno = cmbSeleccionarEntorno.SelectedItem.ToString();
                        btnCompilarApk.Enabled = false;
                        Thread newThread = new Thread(invocarCompiladorApk);
                        newThread.Start(app.Path);
                    }
                }

            }
        }

        private void invocarCompiladorApk(object path)
        {
            Compilador.CompilarApk(path,checkAgregarPlataforma.Checked ,checkFirmarApk.Checked, entorno);
            EnabledButton(true);
        }

        private void validar(Form formulario)
        {
            if(cmbProyectosApk.SelectedItem == null)
            {
                vacio = true;
            }
            if (vacio == true) MessageBox.Show("Por favor seleccione un proyecto."); // Si nuestra variable es verdadera mostramos un mensaje.
            vacio = false; // Devolvemos el valor original a nuestra variable.
        }

        private void EnabledButton(bool flag)
        {
            if (this.btnCompilarApk.InvokeRequired)
            {
                SetEnabledButtonCallback d = new SetEnabledButtonCallback(EnabledButton);
                this.Invoke(d, new object[] { flag });
            }
            else
            {
                this.btnCompilarApk.Enabled = true;
            }
        }
    }
}

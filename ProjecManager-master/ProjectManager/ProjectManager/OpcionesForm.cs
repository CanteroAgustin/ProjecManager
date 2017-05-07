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
using Exceptions;

namespace ProjectManager
{
    public partial class OpcionesForm : Form1
    {
        private List<Server> serversList = new List<Server>();
        private List<Apps> listApps = new List<Apps>();
        private static string serverPath = "../../../servidores.xml";
        private static string pathProyectos = "../../../proyectos.xml";
        private XmlSerialize<Apps> ser = new XmlSerialize<Apps>();
        private XmlSerialize<Server> ser1 = new XmlSerialize<Server>();
        private List<PiezaADeployar> piezasADeployar = new List<PiezaADeployar>();
        private PiezaADeployar piezaADeployar;
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        

        public OpcionesForm()
        {
            
            InitializeComponent();
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            this.validar(this);
            if (listApps.Count > 0)
            {
                foreach (Apps app in listApps)
                {
                    if (app.Name.Equals(cmbProyectos.SelectedItem))
                    {
                        Compilador.Compilar(app.Path);
                    }
                }
            }
        }

        private void OpcionesForm_Load(object sender, EventArgs e)
        {
            this.tTAgregarProyecto.SetToolTip(this.btnAgregarProyecto, "Crea un nuevo proyecto.");
            this.tTEliminarProyecto.SetToolTip(this.btnEliminarProyecto, "Elimina el proyecto seleccionado.");
            this.tTAgregarServidor.SetToolTip(this.btnAgregarServidor, "Crea un nuevo servidor.");
            this.tTEliminarServidor.SetToolTip(this.btnEliminarServidor, "Elimina el servidor seleccionado.");
            this.tTCompilar.SetToolTip(this.btnCompilar, "Compila el Proyecto seleccionado.");
            this.tTDesplegar.SetToolTip(this.btnDeployar, "Despliega las piezas seleccionadas.");
            this.tTEditarProyecto.SetToolTip(this.btnEditarProyecto, "Editar Proyectos.");
            this.tTEditarServidor.SetToolTip(this.btnEditarServidor, "Editar Servidores.");

            if (File.Exists(pathProyectos))
                listApps = ser.DesSerializarXML(listApps, pathProyectos);

            if (File.Exists(serverPath))
                serversList = ser1.DesSerializarXML(serversList, serverPath);

            if (listApps.Count > 0)
            {
                foreach (Apps app in listApps)
                {
                    cmbProyectos.Items.Add(app.Name);
                }
            }
            if (serversList.Count > 0)
            {
                foreach (Server server in serversList)
                {
                    cmbServidores.Items.Add(server.Name);
                }
            }

        }

        private void btnDeployar_Click(object sender, EventArgs e)
        {
            string origen = "";
            string destino = "";

            if(File.Exists(pathProyectos))
            listApps = ser.DesSerializarXML(listApps, pathProyectos);

            if (File.Exists(serverPath))
            serversList = ser1.DesSerializarXML(serversList, serverPath);

            if (listApps.Count > 0)
            {
                foreach (Apps app in listApps)
                {
                    if (app.Name.Equals(cmbProyectos.SelectedItem))
                    {
                        origen = app.Path;
                    }
                }
            }

            if (serversList.Count > 0)
            {
                foreach (Server server in serversList)
                {
                if(server.Name.Equals(cmbServidores.SelectedItem))
                    {
                        destino = server.Path;
                    }
                }
            }

            foreach (string p in cLBPiezas.CheckedItems)
            {
                string[] files = new string[10];
                files = Directory.GetFiles(origen, "*.war", SearchOption.AllDirectories);
                
                for (int i = 0; i < files.Count(); i++)
                {
                    DirectoryInfo dir = new DirectoryInfo(files[i]);
                    if (dir.Name.Equals(p))
                    {
                        string destinoCompleto = System.IO.Path.Combine(destino,p);
                        Deployer.Deployar(dir.FullName, destinoCompleto);
                    }
                }
            }
        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbServidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] files = new string[10];
            cLBPiezas.Items.Clear();

            foreach (Apps app in listApps)
            {
                if (app.Name.Equals(cmbProyectos.SelectedItem))
                {
                    if (app != null)
                    {
                        try
                        {
                            files = Directory.GetFiles(app.Path, "*.war", SearchOption.AllDirectories);
                        }
                        catch (ArgumentException)
                        {
                            cmbProyectos.SelectedText = "";
                            MessageBox.Show("La ruta: " + app.Path + ", posee caracteres invalidos");
                        }
                        catch (DirectoryNotFoundException )
                        {
                            cmbProyectos.SelectedText = "";
                            MessageBox.Show("No se encontro la ruta: "+app.Path);
                        }
                        
                    }
                }
            }
            for (int i = 0; i < files.Count(); i++)
            {
                try
                {
                    piezaADeployar = new PiezaADeployar();
                    DirectoryInfo dir = new DirectoryInfo(files[i]);
                    piezaADeployar.Ruta = dir.FullName;
                    piezaADeployar.Nombre = dir.Name;
                    piezasADeployar.Add(piezaADeployar);
                    cLBPiezas.Items.Add(piezaADeployar.Nombre);
                    
                }
                catch (ArgumentNullException)
                {
                }
            }
            if (files.Count() == 0)
            {
                MessageBox.Show("No se encontraron artefactos");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
            vacio = false; // Devolvemos el valor original a nuestra variable.
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            if (cmbProyectos.SelectedItem == null)
                return;

            foreach(Apps p in listApps)
            {
                if (p.Name.Equals(cmbProyectos.SelectedItem))
                {
                    listApps.Remove(p);
                    ser.SerializarXML(listApps, pathProyectos);
                    cmbProyectos.Items.Clear();
                    break;
                }
            }
            if (listApps.Count > 0)
            {
                foreach (Apps app in listApps)
                {
                    cmbProyectos.Items.Add(app.Name);
                }
            }
            cLBPiezas.Items.Clear();
        }

        private void btnEliminarServidor_Click(object sender, EventArgs e)
        {
            if (cmbServidores.SelectedItem == null)
                return;

            foreach (Server s in serversList)
            {
                if (s.Name.Equals(cmbServidores.SelectedItem))
                {
                    serversList.Remove(s);
                    ser1.SerializarXML(serversList, serverPath);
                    cmbServidores.Items.Clear();
                    break;
                }
            }
            if (serversList.Count > 0)
            {
                foreach (Server s in serversList)
                {
                    cmbServidores.Items.Add(s.Name);
                }
            }
            cLBPiezas.Items.Clear();
        }

        private void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            AddAppForm frm = new AddAppForm();
            this.Hide();
            frm.ShowDialog();
            if (File.Exists(pathProyectos))
                listApps = ser.DesSerializarXML(listApps, pathProyectos);

            if (listApps.Count > 0)
            {
                cmbProyectos.Items.Clear();
                foreach (Apps app in listApps)
                {
                    cmbProyectos.Items.Add(app.Name);
                }
            }
            cLBPiezas.Items.Clear();
            this.Show();
        }

        private void btnAgregarServidor_Click(object sender, EventArgs e)
        {
            AddServerForm frm = new AddServerForm();
            this.Hide();
            frm.ShowDialog();
            if (File.Exists(serverPath))
                serversList = ser1.DesSerializarXML(serversList, serverPath);

            if (serversList.Count > 0)
            {
                cmbServidores.Items.Clear();
                foreach (Server servidor in serversList)
                {
                    cmbServidores.Items.Add(servidor.Name);
                }
            }
            cLBPiezas.Items.Clear();
            this.Show();
        }

        private void btnEditarProyecto_Click(object sender, EventArgs e)
        {
            EditarProyectoForm frm = new EditarProyectoForm();
            this.Hide();
            frm.ShowDialog();

            if (File.Exists(pathProyectos))
                listApps = ser.DesSerializarXML(listApps, pathProyectos);

            if (listApps.Count > 0)
            {
                cmbProyectos.Items.Clear();
                foreach (Apps app in listApps)
                {
                    cmbProyectos.Items.Add(app.Name);
                }
            }
            cLBPiezas.Items.Clear();
            this.Show();
        }

        private void btnEditarServidor_Click(object sender, EventArgs e)
        {
            EditarServidorForm frm = new EditarServidorForm();
            this.Hide();
            frm.ShowDialog();

            if (File.Exists(serverPath))
                serversList = ser1.DesSerializarXML(serversList, serverPath);

            if (serversList.Count > 0)
            {
                cmbServidores.Items.Clear();
                foreach (Server servidor in serversList)
                {
                    cmbServidores.Items.Add(servidor.Name);
                }
            }
            cLBPiezas.Items.Clear();
            this.Show();
        }
        

        
    }
}

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
    public partial class OpcionesForm : Form
    {
        private List<Server> serversList = new List<Server>();
        private List<Apps> listApps = new List<Apps>();
        private static string serverPath = "../../../servidores.xml";
        private static string pathProyectos = "../../../proyectos.xml";
        private XmlSerialize<Apps> ser = new XmlSerialize<Apps>();
        private XmlSerialize<Server> ser1 = new XmlSerialize<Server>();
        private List<PiezaADeployar> piezasADeployar = new List<PiezaADeployar>();
        private PiezaADeployar piezaADeployar;

        public OpcionesForm()
        {
            
            InitializeComponent();
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
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
            listApps = ser.DesSerializarXML(listApps, pathProyectos);
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

            listApps = ser.DesSerializarXML(listApps, pathProyectos);
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
                        Deployer.Deployar(dir.FullName, destino + "/" + p);
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
                        files = Directory.GetFiles(app.Path, "*.war",SearchOption.AllDirectories);
                        
                    }
                }
            }
            for (int i = 0; i < files.Count(); i++)
            {
                

                piezaADeployar = new PiezaADeployar();
                DirectoryInfo dir = new DirectoryInfo(files[i]);
                piezaADeployar.Ruta = dir.FullName;
                piezaADeployar.Nombre = dir.Name;
                piezasADeployar.Add(piezaADeployar);
                cLBPiezas.Items.Add(piezaADeployar.Nombre);
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

    }
}

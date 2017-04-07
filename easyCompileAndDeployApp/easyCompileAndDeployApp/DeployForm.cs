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
namespace easyCompileAndDeployApp
{
    public partial class DeployForm : Form
    {
        List<Server> serversList = new List<Server>();
        List<Apps> appsList = new List<Apps>();
        string serverPath = "../../../servidores.xml";
        string appPath = "../../../proyectos.xml";

        public DeployForm()
        {
            InitializeComponent();
        }

        private void DeployForm_Load(object sender, EventArgs e)
        {
            AddControls();
        }

        private void AddControls()
        {
            XmlSerialize<Server> ser = new XmlSerialize<Server>();
            serversList = ser.DesSerializarXML(serversList, serverPath);
            int baseX = 1;
            int baseY = 1;
            for (int i = 0; i < serversList.Count; i++)
            {
                Button newPanelButton = new Button();
                newPanelButton.Name = serversList[i].Name;
                newPanelButton.Text = serversList[i].Name;
                newPanelButton.Top = 20;
                newPanelButton.Height = 23;
                newPanelButton.Width = 259;
                newPanelButton.Location = new Point(baseX, baseY + (22 * i));
                pnlBotones.Controls.Add(newPanelButton);
                newPanelButton.Click += new System.EventHandler(this.NewPanelButton_Click);
            }
        }

        private void NewPanelButton_Click(Object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            XmlSerialize<Apps> ser = new XmlSerialize<Apps>();
            appsList = ser.DesSerializarXML(appsList, appPath);
            foreach (Apps a in appsList)
            {
                if (clickedButton.Text == a.Name)
                {
                    foreach (string p in a.Piezas)
                    {
                        Deployer.Deployar(p, a.Path);
                    }
                    
                }
            }
        }
    }
}

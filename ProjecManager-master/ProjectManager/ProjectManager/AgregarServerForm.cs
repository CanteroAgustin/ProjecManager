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

            serversList.Add(server);
            ser.SerializarXML(serversList, curFile);
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
    }
}

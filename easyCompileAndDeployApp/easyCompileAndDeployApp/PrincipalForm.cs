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
    public partial class Form1 : Form
    {
        Point formPosition;
        Boolean mouseAction;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AddAppForm frm = new AddAppForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            OpcionesForm frm = new OpcionesForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            AddServerForm frm = new AddServerForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnShowServers_Click(object sender, EventArgs e)
        {

        }

        private void btnShowApps_Click(object sender, EventArgs e)
        {

        }

        

        private void dynamicbutton_Click(Object sender, System.EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pBLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

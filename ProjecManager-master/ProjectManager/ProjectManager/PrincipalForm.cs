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

namespace ProjectManager
{
    public partial class Form1 : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState =
        (this.WindowState == FormWindowState.Maximized ?
            FormWindowState.Normal :
            FormWindowState.Maximized);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }
        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        public string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

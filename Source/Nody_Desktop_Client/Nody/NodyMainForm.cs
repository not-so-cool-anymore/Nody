using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    public partial class NodyMainForm : Form
    {
        public NodyMainForm()
        {
            InitializeComponent();
            homePageUserControl.BringToFront();
            
        }
        Point endPoint;

        private void HomePageBtn_Click(object sender, EventArgs e)
        {
            homePageUserControl.BringToFront();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormUpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void MainFormUpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }

        private void LogoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void LogoPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }

        private void NodesPageBtn_Click(object sender, EventArgs e)
        {
            nodesPageUserControl.BringToFront();
        }

        private void RequestDatasetBtn_Click(object sender, EventArgs e)
        {
            requestDatasetUserControl.BringToFront();
        }
    }
}

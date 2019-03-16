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
    public partial class Nody_Auth : Form
    {
        Point endPoint;
        public Nody_Auth()
        {
            InitializeComponent();
            loginUserControl.BringToFront();
        }

        private void WelcomePanelMouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void WelcomePaneMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }

        private void WelcomeLabelMouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void WelcomeLabelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpperPanelMouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void UpperPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            loginUserControl.BringToFront();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            registerUserControl.BringToFront();
        }
    }
}

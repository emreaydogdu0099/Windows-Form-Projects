using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Home : Form
    {
        private bool isCollapsed1 = true;
        private bool isCollapsed2 = true;
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                panelHizmetlerimiz.Height = panelHizmetlerimiz.MaximumSize.Height;
                isCollapsed1 = false;
                timer1.Stop();
            }
            else
            {
                panelHizmetlerimiz.Height = panelHizmetlerimiz.MinimumSize.Height;
                isCollapsed1 = true;
                timer1.Stop();
            }
        }

        private void btnHizmetlerimiz_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnUnitelerimiz_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                panelUnitelerimiz.Height = panelUnitelerimiz.MaximumSize.Height;
                isCollapsed2 = false;
                timer2.Stop();
            }
            else
            {
                panelUnitelerimiz.Height = panelUnitelerimiz.MinimumSize.Height;
                isCollapsed2 = true;
                timer2.Stop();
            }
        }

        private void btnKonsol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}

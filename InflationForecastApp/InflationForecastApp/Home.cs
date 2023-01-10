using System;
using System.Windows.Forms;

namespace InflationForecastApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Main home = new Main();
            home.Show();
            this.Hide();
        }
    }
}

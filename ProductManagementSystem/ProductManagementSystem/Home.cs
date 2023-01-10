using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementSystem
{
    public partial class Home : Form
    {
        // Giriş butonuna tıklandığında ana ekrana gitmesi için ana ekrandan bir nesne oluşturmamız gerekir.
        Main _main = new Main();
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ana ekran açılsın.
            _main.Show();
            // Burası gizlensin.
            this.Hide();
        }
    }
}

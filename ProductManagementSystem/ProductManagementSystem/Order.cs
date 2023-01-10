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
    public partial class Order : Form
    {
        ProductDal _productDal = new ProductDal();

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // Alışveriş tamamlama ekranı açıldığında karttaki ürünleri datagridview'e aktarır.
            dataGridView1.DataSource = _productDal.GetCart();
            // Id satırına ihtiyaç olmadığı için gizliyoruz.
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[2].HeaderText = "Ürün Fiyatı";
            dataGridView1.Columns[3].HeaderText = "Ürün Adeti/Kilosu";
            totalLbl.Text = _productDal.GetTotalPrice().ToString();
            if (totalLbl.Text.Equals("0"))
            {
                acceptBtn.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main _main = new Main();
            _main.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Datagridview'de seçili olan satırın id'sini alıyoruz.
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _productDal.DeleteFromCart(id);
            // Datagridview'i güncelliyoruz.
            dataGridView1.DataSource = _productDal.GetCart();
            totalLbl.Text = _productDal.GetTotalPrice().ToString();
        }
        public void CompleteOrder()
        {
            string message = "";
            if (creditCartRadio.Checked)
            {
                message = creditCartRadio.Text + " ile işleminiz tamamlandı.";
                MessageBox.Show(message);
                MessageBox.Show("İyi günler dileriz.");
                _productDal.ClearCart();
                Application.Exit();
            }
            else if (cashRadio.Checked)
            {
                message = cashRadio.Text + " ile işleminiz tamamlandı.";
                MessageBox.Show(message);
                MessageBox.Show("İyi günler dileriz.");
                _productDal.ClearCart();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Lütfen ödeme yöntemini seçiniz.");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CompleteOrder();
        }
    }
}

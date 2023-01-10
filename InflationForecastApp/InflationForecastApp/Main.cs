using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InflationForecastApp
{
    public partial class Main : Form
    {
        readonly ProductDal _productDal = new ProductDal();
        private double _inflationRate;
        public Main()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text == "" || categoryTxt.Text == "" || oldPriceTxt.Text == "" || newPriceTxt.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                }
                if (Convert.ToDouble(oldPriceTxt.Text) < 0 || Convert.ToDouble(newPriceTxt.Text) < 0)
                {
                    MessageBox.Show("Lütfen fiyat alanlarını pozitif sayılar giriniz!");
                }
                else
                {
                    Product product = new Product
                    {
                        Name = nameTxt.Text,
                        Category = categoryTxt.Text,
                        OldPrice = Convert.ToDouble(oldPriceTxt.Text),
                        NewPrice = Convert.ToDouble(newPriceTxt.Text),
                    };
                    _productDal.Add(product);
                    dgwProducts.DataSource = _productDal.GetAll();
                    MessageBox.Show("Ürün eklendi!");
                    WriteInflation();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen fiyat alanlarını sayısal değerler giriniz!");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll();
            dgwProducts.Columns[0].Visible = false;
            dgwProducts.Columns[1].HeaderText = "Ürün Adı";
            dgwProducts.Columns[2].HeaderText = "Kategori";
            dgwProducts.Columns[3].HeaderText = "Eski Fiyat";
            dgwProducts.Columns[4].HeaderText = "Yeni Fiyat";
            WriteInflation();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Header hariç tıklanan satırın bilgileri textbox'lara yazılıyor
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgwProducts.Rows[e.RowIndex];
                nameTxt.Text = row.Cells[1].Value.ToString();
                categoryTxt.Text = row.Cells[2].Value.ToString();
                oldPriceTxt.Text = row.Cells[3].Value.ToString();
                newPriceTxt.Text = row.Cells[4].Value.ToString();
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text == "" || categoryTxt.Text == "" || oldPriceTxt.Text == "" || newPriceTxt.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                }
                if (Convert.ToDouble(oldPriceTxt.Text) < 0 || Convert.ToDouble(newPriceTxt.Text) < 0)
                {
                    MessageBox.Show("Lütfen fiyat alanlarını pozitif sayılar giriniz!");
                }
                else
                {
                    Product product = new Product
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = nameTxt.Text,
                        Category = categoryTxt.Text,
                        OldPrice = Convert.ToDouble(oldPriceTxt.Text),
                        NewPrice = Convert.ToDouble(newPriceTxt.Text),
                    };
                    _productDal.Update(product);
                    dgwProducts.DataSource = _productDal.GetAll();
                    MessageBox.Show("Ürün güncellendi!");
                    WriteInflation();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen fiyat alanlarını sayısal değerler giriniz!");
            }
        }

        private void WriteInflation()
        {
            _inflationRate = _productDal.GetInflationRate();
            // eğer inflationRate NaN ise yani ürün yoksa
            if (double.IsNaN(_inflationRate))
            {
                inflationLbl.Text = "Enflasyon Oranı: %0";
                inflationLbl.ForeColor = Color.Black;
            }
            else if (_inflationRate > 0)
            {
                inflationLbl.Text = "Enflasyon Oranı: %" + _inflationRate.ToString();
                inflationLbl.ForeColor = Color.Red;
            }
            else if (_inflationRate < 0)
            {
                inflationLbl.Text = "Enflasyon Oranı: %" + (_inflationRate * -1).ToString();
                inflationLbl.ForeColor = Color.Green;
            }
            else
            {
                inflationLbl.Text = "Enflasyon Oranı: %" + _inflationRate.ToString();
                inflationLbl.ForeColor = Color.Black;
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            // Arama textbox'ına yazılan değer ürün isimlerinde aranıyor
            dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(searchTxt.Text.ToLower())).ToList();
        }

        private void dgwProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // header hariç tıklanan satır siliniyor
            if (e.RowIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Ürün Silme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
                    _productDal.Delete(id);
                    dgwProducts.DataSource = _productDal.GetAll();
                    MessageBox.Show("Ürün silindi!");
                    WriteInflation();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Nothing
                }
            }
        }

    }

}

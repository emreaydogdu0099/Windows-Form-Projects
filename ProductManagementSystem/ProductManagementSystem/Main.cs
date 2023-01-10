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
    public partial class Main : Form
    {
        // Order sınıfından nesne oluşturulur.
        Order _order = new Order();
        // ProductDal sınıfından nesne oluşturulur.
        ProductDal _productDal = new ProductDal();
        public Main()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _order.Show();
            this.Hide();
        }

        private void fruitBtn_Click(object sender, EventArgs e)
        {
            // GrupBox'ın içeriği temizlenir.
            groupBox2.Controls.Clear();
            // Ürünlerin grupbox'a eklenmesi
            CreatePictureBox("Meyve", "fruits");
            countLbl.Visible = true;
            countInput.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            CreatePictureBox("Sebze", "vegetables");
            countLbl.Visible = true;
            countInput.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            CreatePictureBox("İçecek", "drinks");
            countLbl.Visible = true;
            countInput.Visible = true;
        }

        private void All_Click(object sender, EventArgs e)
        {
            if (countInput.Value < 1)
            {
                MessageBox.Show("Lütfen ürün adedini/kilosunu giriniz.");
            }
            else
            {
                _productDal.AddToCart(((PictureBox)sender).Text, Convert.ToInt32(countInput.Text), Convert.ToDecimal(((PictureBox)sender).Tag));
                MessageBox.Show("Ürün sepete eklendi!");
                countInput.Text = "0";
            }
        }

        // Veritabanından gelen değerlere göre picturebox'lar oluşturmak için oluşturulmuştur.
        private void CreatePictureBox(string name, string folderName)
        {
            int picBoxCount = 0;
            int x = 35, y = 45;

            List<Product> products = _productDal.GetByCategory(name);
            // Ürünlere tıklandığında sepete ekleme işlemi yapılması için oluşturulmuştur.
            EventHandler btn = new EventHandler(fruitBtn_Click);
            if (name == "Meyve") { btn = new EventHandler(All_Click); }
            else if (name == "Sebze") { btn = new EventHandler(All_Click); }
            else if (name == "İçecek") { btn = new EventHandler(All_Click); }

            for (int i = 0; i < products.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Text = products[i].Name;
                pictureBox.Tag = products[i].UnitPrice.ToString();
                pictureBox.ImageLocation = $"D:\\projects\\c#\\ProductManagementSystem\\ProductManagementSystem\\images\\{folderName}\\{i}.png";
                pictureBox.Size = new Size(100, 100);
                pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;              
                pictureBox.Location = new Point(x, y);
                pictureBox.Click += btn;
                groupBox2.Controls.Add(pictureBox);
                picBoxCount += 1;
                x += 300;
                if (picBoxCount == 3)
                {
                    picBoxCount = 0;
                    x = 35;
                    y += 170;
                }
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            CreatePictureBox("Meyve", "fruits");
        }

    }
}

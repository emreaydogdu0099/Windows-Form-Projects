using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Info : Form
    {
        PersonData personData = new PersonData();
        public Info(string bolum)
        {
            InitializeComponent();
            dgwKisiler.DataSource = personData.Listele(bolum);
        }
        public Info()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            personData.Ekle(new Person
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Cinsiyet = cmbCinsiyet.Text,
                Dogum = Convert.ToInt32(txtDogum.Text),
                Tur = cmbTur.Text,
                Maas = Convert.ToDecimal(txtMaas.Text),
                Izin = cmbIzin.Text,
                Bolum = cmbBolum.Text
            });
            MessageBox.Show("Personel Eklendi");
            dgwKisiler.DataSource = personData.Listele(cmbBolum.Text);
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            personData.Sil(Convert.ToInt32(dgwKisiler.CurrentRow.Cells[0].Value));
            MessageBox.Show("Personel Silindi");
            dgwKisiler.DataSource = personData.Listele(cmbBolum.Text);
            Temizle();
        }

        private void dgwKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgwKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgwKisiler.CurrentRow.Cells[2].Value.ToString();
            cmbCinsiyet.Text = dgwKisiler.CurrentRow.Cells[3].Value.ToString();
            txtDogum.Text = dgwKisiler.CurrentRow.Cells[4].Value.ToString();
            cmbTur.Text = dgwKisiler.CurrentRow.Cells[5].Value.ToString();
            txtMaas.Text = dgwKisiler.CurrentRow.Cells[6].Value.ToString();
            cmbIzin.Text = dgwKisiler.CurrentRow.Cells[7].Value.ToString();
            cmbBolum.Text = dgwKisiler.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            personData.Guncelle(new Person
            {
                Id = Convert.ToInt32(dgwKisiler.CurrentRow.Cells[0].Value),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Cinsiyet = cmbCinsiyet.Text,
                Dogum = Convert.ToInt32(txtDogum.Text),
                Tur = cmbTur.Text,
                Maas = Convert.ToDecimal(txtMaas.Text),
                Izin = cmbIzin.Text,
                Bolum = cmbBolum.Text
            });
            MessageBox.Show("Personel Güncellendi");
            dgwKisiler.DataSource = personData.Listele(cmbBolum.Text);
            Temizle();
        }

        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            cmbCinsiyet.Text = "";
            txtDogum.Clear();
            cmbTur.Text = "";
            txtMaas.Clear();
            cmbIzin.Text = "";
            cmbBolum.Text = "";
        }

    }
}

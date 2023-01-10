using SimpleWarGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWarGame
{
    public partial class WarGameGUI : Form
    {
        User user = new User();
        Random random = new Random();
        public WarGameGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.userName = txtUserName.Text;
            user.race = cmbRace.SelectedItem != null ? cmbRace.SelectedItem.ToString() : String.Empty;
            user.branch = cmbBranch.SelectedItem != null ? cmbBranch.SelectedItem.ToString() : String.Empty;

            if (String.IsNullOrWhiteSpace(user.userName) || user.race == String.Empty || user.branch == String.Empty)
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
            else
            {
                ChangeState(false);
                ChangeVisible(true);
                lblUserName.Text = user.userName;
                lblWolfManName.Text = "Wolf Man";

                lblUserHealthCount.Text = $"Health : {lblUserHealth.Width}";
                lblWolfManHealthCount.Text = $"Health : {lblWolfManHealth.Width}";
            }
        }

        public void ChangeState(bool state)
        {
            txtUserName.Enabled = state;
            cmbBranch.Enabled = state;
            cmbRace.Enabled = state;
            btnGo.Enabled = state;
        }
        public void Clear()
        {
            txtUserName.Text = "";
            cmbRace.SelectedItem = null;
            cmbBranch.SelectedItem = null;
        }

        public void ChangeVisible(bool isVisible)
        {
            //Attack Button
            btnAttack.Visible = isVisible;
            //WolfMan
            lblWolfManName.Visible = isVisible;
            lblWolfManHealthCount.Visible = isVisible;
            lblWolfManHealth.Visible = isVisible;
            pcbWolfManPicture.Visible = isVisible;
            //User
            lblUserName.Visible = isVisible;
            lblUserHealthCount.Visible = isVisible;
            lblUserHealth.Visible = isVisible;
            pcbUserPicture.Visible = isVisible;
        }

        public void ChangeVisible()
        {
            lblWolfManHealthCount.Visible = false;
            lblWolfManHealth.Visible = false;
            lblWolfManName.Visible = false;
            pcbWolfManPicture.Visible = false;
            btnAttack.Visible = false;
        }
        public void ChangeVisible(string name)
        {
            lblWolfManHealthCount.Visible = false;
            lblWolfManHealth.Visible = false;
            lblWolfManName.Visible = false;
            pcbWolfManPicture.Visible = false;
            btnAttack.Visible = false;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            user.Attack();
            lblWolfManHealth.Width -= user.damage;
            MessageBox.Show($"Düşmana verilen hasar: {user.damage}");
            lblWolfManHealthCount.Text = $"Can : {lblWolfManHealth.Width}";
            if (lblWolfManHealth.Width <= 0)
            {
                MessageBox.Show($"Winner : {user.userName}");
                ChangeVisible();
                return;
            }
            int wolfManAttack = random.Next(30, 61);
            lblUserHealth.Width -= wolfManAttack;
            MessageBox.Show($"Düşman Hasarı: {wolfManAttack}");
            if (lblUserHealth.Width <= 0)
            {
                MessageBox.Show("Winner : WolfMan");
                ChangeVisible(user.userName);
                return;
            }
            lblUserHealthCount.Text = $"Can : {lblUserHealth.Width}";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ChangeState(true);
            ChangeVisible(false);
            Clear();
            lblUserHealth.Width = 225;
            lblWolfManHealth.Width = 225;
        }
    }
}

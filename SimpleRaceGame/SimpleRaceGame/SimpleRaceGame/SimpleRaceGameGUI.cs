using SimpleRaceGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRaceGame
{
    public partial class SimpleRaceGameGUI : Form
    {
        Ford ford = new Ford();
        Renault renault = new Renault();
        Mercedes mercedes = new Mercedes();

        public SimpleRaceGameGUI()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbFord.Left += ford.speed();
            pcbRenault.Left += renault.speed();
            pcbMercedes.Left += mercedes.speed();

            if (pcbFord.Right >= lblFinish.Left)
            {
                timer.Stop();
                MessageBox.Show("Winner: Ford");
            }
            else if (pcbRenault.Right >= lblFinish.Left)
            {
                timer.Stop();
                MessageBox.Show("Winner: Renault");
            }
            else if (pcbMercedes.Right >= lblFinish.Left)
            {
                timer.Stop();
                MessageBox.Show("Winner: Mercedes");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}

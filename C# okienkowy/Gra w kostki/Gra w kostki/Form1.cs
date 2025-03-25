using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_w_kostki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private int totalScore = 0;

        private void rzuc_Click(object sender, EventArgs e)
        {
            int dice1 = random.Next(1,7);
            int dice2 = random.Next(1,7);

            DiceLabel1.Text = "Kość 1: " + dice1;
            DiceLabel2.Text = "Kość 2: " + dice2;

            int sum = dice1 + dice2;

            DiceSum.Text = "Suma" + sum;

            totalScore += sum;

            DiceTotal.Text = "Wynik całkoity: " + totalScore;

            DiceBox1.Image = Image.FromFile($"Images/dice{dice1}.png");
            DiceBox2.Image = Image.FromFile($"Images/dice{dice2}.png");
        }


    }
}

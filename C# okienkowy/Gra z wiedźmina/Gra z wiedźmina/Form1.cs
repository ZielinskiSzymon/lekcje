using Gra_z_wiedźmina;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gra_w_kostki
{
    public partial class Form1 : Form
    {
        private string gracz1 = "Gracz1";
        private string gracz2 = "Gracz2";

        private Random random = new Random();
        private int counter = 0;
        private int wynikGracza1 = 0;
        private int wynikGracza2 = 0;

        public Form1()
        {
            InitializeComponent();

            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                gracz1 = form2.Imie1;
                gracz2 = form2.Imie2;
            }

            label2.Text = "Wynik "+gracz1;
            jakiGracz.Text = gracz1;
        }

        private void rzuc_Click(object sender, EventArgs e)
        {
            if (counter < 6)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int dice3 = random.Next(1, 7);
                int dice4 = random.Next(1, 7);
                int dice5 = random.Next(1, 7);

                DiceLabel1.Text = "Kość 1: " + dice1;
                DiceLabel2.Text = "Kość 2: " + dice2;
                DiceLabel3.Text = "Kość 3: " + dice3;
                DiceLabel4.Text = "Kość 4: " + dice4;
                DiceLabel5.Text = "Kość 5: " + dice5;

                int sum = dice1 + dice2 + dice3 + dice4 + dice5;

                Wynik.Text = "Suma: " + sum;

                if (counter % 2 == 0)
                {
                    wynikGracza1 += sum;
                    jakiGracz.Text = gracz1;
                }
                else
                {
                    wynikGracza2 += sum;
                    jakiGracz.Text = gracz2;
                }

                WynikGracza1.Text = wynikGracza1.ToString();
                WynikGracza2.Text = wynikGracza2.ToString();

                DiceBox1.Image = Image.FromFile($"Images/dice{dice1}.png");
                DiceBox2.Image = Image.FromFile($"Images/dice{dice2}.png");
                DiceBox3.Image = Image.FromFile($"Images/dice{dice3}.png");
                DiceBox4.Image = Image.FromFile($"Images/dice{dice4}.png");
                DiceBox5.Image = Image.FromFile($"Images/dice{dice5}.png");

                counter++;
            }
            else
            {
                if (wynikGracza1 > wynikGracza2)
                    MessageBox.Show($"Wygrał {gracz1}!!");
                else if (wynikGracza1 < wynikGracza2)
                    MessageBox.Show($"Wygrał {gracz2}!!");
                else
                    MessageBox.Show("Remis!");
            }
        }
    }
}

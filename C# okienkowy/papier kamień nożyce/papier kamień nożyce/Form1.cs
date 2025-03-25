using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papier_kamień_nożyce
{
    public partial class Form1 : Form
    {
        private int mojWybor = 0;
        private int komputerWybor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // papier

            mojWybor = 3;
            pictureBox1.Image = Image.FromFile("Zdjecia/" + mojWybor + "zdj.png");
            losujObrazek();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kamień

            mojWybor = 1;
            pictureBox1.Image = Image.FromFile("Zdjecia/" + mojWybor + "zdj.png");
            losujObrazek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // nożyce

            mojWybor = 2;
            pictureBox1.Image = Image.FromFile("Zdjecia/" + mojWybor + "zdj.png");
            losujObrazek();
        }
        private void losujObrazek()
        {
            Random random = new Random();
            komputerWybor = random.Next(1, 4);
            pictureBox2.Image = Image.FromFile("Zdjecia/" + komputerWybor + "zdj.png");
            sprawdzWynik();
        }
        private void sprawdzWynik()
        {
            string wynik = "";

            if(mojWybor == komputerWybor)
            {
                wynik = "Remis";
            }
            else if ((mojWybor == 1 && komputerWybor == 2) || (mojWybor == 2 && komputerWybor == 3) || (mojWybor == 3 && komputerWybor == 1))
            {
                wynik = "Wygrałeś!";
            }
            else
            {
                wynik = "Przegrałeś!";
            }

            label1.Text = wynik;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egzaimin_Form_30._09._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Numer_TextChanged_1(object sender, EventArgs e)
        {
            string numer = Numer.Text;

            string imagePathPerson = Path.Combine(Application.StartupPath, "IMGS", $"{numer}-zdjecie.jpg");
            string imagePathFinger = Path.Combine(Application.StartupPath, "IMGS", $"{numer}-odcisk.jpg");


            if (File.Exists(imagePathFinger))
                pictureBoxFinger.ImageLocation = imagePathFinger;
            else
                pictureBoxFinger.Image = null;

            if (File.Exists(imagePathPerson)) 
                pictureBoxPerson.ImageLocation = imagePathPerson;
            else
                pictureBoxPerson.Image = null;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Imie.Text) || string.IsNullOrEmpty(Nazwisko.Text))
            {
                MessageBox.Show("Wprowadź dane","Błąd",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imie = Imie.Text,
                   nazwisko = Nazwisko.Text,
                   koloroczu = "";

            if(radioButton1.Checked)
            {
                koloroczu = "niebieskie";
            }else if(radioButton2.Checked)
            {
                koloroczu = "zielone";
            }else if (radioButton3.Checked)
            {
                koloroczu = "piwne";
            }

            MessageBox.Show($"{imie} {nazwisko} kolor oczu {koloroczu}", "dane paszportowe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }  
    }
}

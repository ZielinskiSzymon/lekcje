using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Referencje
{
    public partial class Form1 : Form
    {
        private int number = 0;
        private int number2 = 0;
        private string source = "source";
        private string target = "target";
        private static double euro = 4.26;
        private static double dolar = 4.5;
        private static double zabs = 4;
        private static double frank = 4.55;
        private double zl = 0;
        public Form1()
        {
            InitializeComponent();
            UpdateNumber();
            UpdateLabels();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IncreaseNumber1(ref number);
            UpdateNumber();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            IncreaseNumber10(ref number2);
            textBox2.Text = number2.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MultipleNumber2(ref number2);
            textBox2.Text = number2.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            TransferValue(ref source, ref target);
            UpdateLabels();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            zl = double.Parse(textBox1.Text);
            label8.Text = zl + "zł";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            double wynik = zl / euro;
            label10.Text = wynik.ToString("F2") + "€";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double wynik = zl / dolar;
            label10.Text = wynik.ToString("F2") + "$";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double wynik = zl / zabs;
            label10.Text = wynik.ToString("F2") + "żabsów";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double wynik = zl / frank;
            label10.Text = wynik.ToString("F2") + "CHF";
        }

        private void UpdateNumber()
        {
            label1.Text = number.ToString();
        }
        private void IncreaseNumber1(ref int value)
        {
            value += 1;
        }
        private void IncreaseNumber10(ref int value)
        {
            value += 10;
        }
        private void MultipleNumber2(ref int value)
        {
            value *= 2;
        }
        private void ResetNumber(ref int value)
        {
            value = 0;
        }
        private void UpdateLabels()
        {
            label4.Text = source.ToString();
            label5.Text = target.ToString();
        }
        private void TransferValue(ref string source, ref string target)
        {
            target = source;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            number2 = int.Parse(textBox2.Text);
        }
    }
}

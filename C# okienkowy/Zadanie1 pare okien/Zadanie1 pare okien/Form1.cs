using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_pare_okien
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string message = textBox1.Text;
            Form2 form2 = new Form2(message);
            form2.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(textBox2.Text,textBox3.Text);
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message;
            if (radioButton1.Checked)
                message = "Tak lubie programować";
            else
                message = "Tak lubie programować";

            Form4 form4 = new Form4();
            form4.MessageText = message;
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string color = "white";
            if (radioButton3.Checked)
                color = "red";
            else if (radioButton4.Checked)
                color = "green";
            else if (radioButton5.Checked)
                color = "blue";

            Form5 form5 = new Form5();
            form5.ShowDialog();
            form5.MessageText = color;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

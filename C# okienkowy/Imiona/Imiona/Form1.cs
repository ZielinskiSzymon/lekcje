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

namespace Imiona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader czytaj = new StreamReader("GirlNames.txt");
            bool nie = true;
            while (!czytaj.EndOfStream)
            {
                string name = czytaj.ReadLine().Trim();

                if (textBox1.Text.Contains(name))
                {
                    MessageBox.Show("tak");
                    nie = false;
                    break;
                }
            }

            if (nie)
            {
                MessageBox.Show("nie");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader czytaj = new StreamReader("BoyNames.txt");
            bool nie = true;
            while (!czytaj.EndOfStream)
            {
                string name = czytaj.ReadLine().Trim();

                if (textBox2.Text.Contains(name))
                {
                    MessageBox.Show("tak");
                    nie = false;
                    break;
                }
            }

            if (nie)
            {
                MessageBox.Show("nie");
            }
        }
    }
}

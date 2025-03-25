using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pare_okien
{
    public partial class Form2 : Form
    {
        public string MessageText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.MessageText = textBox1.Text;
            form1.ShowDialog();
        }

       
    }
}

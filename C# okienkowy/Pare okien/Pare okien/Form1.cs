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
    public partial class Form1 : Form
    {
        public string MessageText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.MessageText = textBox1.Text;
            form2.FormClosed += (s, args) => this.Show();
            form2.ShowDialog();
        }
    }
}

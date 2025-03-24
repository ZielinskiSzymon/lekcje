using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przesyłanie_danych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MessageSent += Form2_MessageSent;
            form2.ShowDialog();
        }

        private void Form2_MessageSent(string message)
        {
            lblMessage.Text = message;
        }

    }
}

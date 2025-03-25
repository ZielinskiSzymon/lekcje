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
    public partial class Form2 : Form
    {
        public delegate void MyEventHandler(string message);
        public event MyEventHandler MessageSent;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (MessageSent != null)
            {
                string text = txtMessage.Text;
                MessageSent(text);
            }
            this.Close();
        }
    }
}

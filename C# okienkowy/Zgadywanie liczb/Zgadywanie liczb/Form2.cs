using System;
using System.Windows.Forms;

namespace Zgadywanie_liczb
{
    public partial class Form2 : Form
    {
        public delegate void MyEventHandler(string message);
        public event MyEventHandler MessageSent;
        private int zakres = 0;

        public Form2(int zakres2)
        {
            zakres = zakres2;
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string inputText = txtLiczby.Text;
            if (!string.IsNullOrEmpty(inputText) && int.TryParse(inputText, out int number))
            {
                if (number >= 0 && number <= zakres)
                {
                    MessageSent(inputText);
                }
                else
                {
                    MessageBox.Show("Wprowadź numer w poprawnym zakresie.");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawny numer.");
            }
        }
    }
}

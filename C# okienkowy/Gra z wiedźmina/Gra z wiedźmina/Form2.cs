using System;
using System.Windows.Forms;

namespace Gra_z_wiedźmina
{
    public partial class Form2 : Form
    {
        public string Imie1 { get; private set; }
        public string Imie2 { get; private set; }
        private int counter = 0;

        public Form2()
        {
            InitializeComponent();
            label1.Text = "Podaj imie pierwszego gracza";
        }

        private void Imie_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                Imie1 = textBox1.Text;
                counter++;
                label1.Text = "Podaj imie drugiego gracza";
                textBox1.Clear();
            }
            else if (counter == 1)
            {
                Imie2 = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

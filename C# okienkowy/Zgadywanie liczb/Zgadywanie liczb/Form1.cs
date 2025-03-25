using System;
using System.Windows.Forms;

namespace Zgadywanie_liczb
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int wylosowana;
        private int ileRazy = 1;
        private int zakres = 100;
        private Form2 form2;
        

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            form2 = new Form2(zakres);
            form2.MessageSent += Form2_MessageSent;
            wylosowana = random.Next(0, zakres);
            form2.ShowDialog();
            form2.Close();
        }

        private void Form2_MessageSent(string message)
        {
            if (ileRazy > 10)
            {
                listBox1.Items.Add("Maksymalnie można zgadnąć 10 razy");
                return;
            }

            if (int.TryParse(message, out int number))
            {
                if (number > wylosowana)
                    listBox1.Items.Add(number + " -> za duża");
                else if (number < wylosowana)
                    listBox1.Items.Add(number + " -> za mała");
                else
                {
                    listBox1.Items.Add($"Zgadłeś za {ileRazy} razem");
                }

                ileRazy++;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();

            switch(item){
                case "Łatwy":
                    zakres = 100;
                    break;
                case "Średni":
                    zakres = 1000;
                    break;
                case "Trudny":
                    zakres = 10000;
                    break;
                default:
                    zakres = 100;
                    break;
            }
        }
    }
}

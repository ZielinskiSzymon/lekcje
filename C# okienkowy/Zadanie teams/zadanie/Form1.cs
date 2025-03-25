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

namespace zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zaladuj();
        }
        public List<string> lista = new List<string>();

        public void zaladuj()
        {
            StreamReader teams = new StreamReader("teams.txt");
            StreamReader wygrane = new StreamReader("WorldSeriesWinners.txt");

            ListBox listbox = listBox1; 

            while (!teams.EndOfStream)
                listBox1.Items.Add(teams.ReadLine());

            while (!wygrane.EndOfStream)
                lista.Add(wygrane.ReadLine());
        }

        private void zmiana(object sender, EventArgs e)
        {
            string nazwa = listBox1.SelectedItem.ToString();
            int licznik = 0;

            foreach (string item in lista)
                if (item == nazwa)
                    licznik++;

            MessageBox.Show("Ten zespoł w latach 1903 do 2012 wygral " + licznik + " razy");
        }
    }
}

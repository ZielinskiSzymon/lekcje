using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy_Okienkowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortowanieWybieranie_Click(object sender, EventArgs e)
        {
            Wybieranie wybieranie = new Wybieranie();
            wybieranie.ShowDialog();
        }

        private void btnPierwsze_Click(object sender, EventArgs e)
        {
            Pierwsze pierwsze = new Pierwsze();
            pierwsze.ShowDialog();
        }

        private void btnSzukanieWartownik_Click(object sender, EventArgs e)
        {
            Wartownik wartownik = new Wartownik();
            wartownik.ShowDialog();
        }
    }
}

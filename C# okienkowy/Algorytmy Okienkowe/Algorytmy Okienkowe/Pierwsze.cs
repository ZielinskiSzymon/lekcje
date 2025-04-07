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
    public partial class Pierwsze : Form
    {
        public Pierwsze()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxOd.Text, out int od) && int.TryParse(textBoxDo.Text, out int dok))
            {
                if (od >= 0 && dok > od)
                {
                    var liczbyPierwsze = ZnajdzLiczbyPierwsze(od, dok);
                    labelWynik.Text = $"Liczby pierwsze w zakresie {od}-{dok}:\n{string.Join(", ", liczbyPierwsze)}";
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy zakres. 'Od' musi być mniejsze niż 'do' i obie wartości nieujemne.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawne liczby całkowite w oba pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<int> ZnajdzLiczbyPierwsze(int od, int dok)
        {
            List<int> liczbyPierwsze = new List<int>();
            for (int i = Math.Max(2, od); i <= dok; i++)
            {
                if (CzyPierwsza(i))
                {
                    liczbyPierwsze.Add(i);
                }
            }
            return liczbyPierwsze;
        }

        private bool CzyPierwsza(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}

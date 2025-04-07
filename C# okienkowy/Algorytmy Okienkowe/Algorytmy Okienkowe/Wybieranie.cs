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
    public partial class Wybieranie : Form
    {
        public Wybieranie()
        {
            InitializeComponent();
        }
        private void buttonSortuj_Click(object sender, EventArgs e)
        {
            try
            {
                // Parsowanie liczb z tekstu
                int[] liczby = Array.ConvertAll(textBoxLiczby.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

                // Wywołanie sortowania
                SelectionSort(liczby);

                // Wyświetlenie wyniku
                labelWynik.Text = "Posortowane liczby:\n" + string.Join(" ", liczby);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadź poprawne liczby całkowite oddzielone spacjami.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Wprowadzona liczba jest za duża.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Zamiana miejscami
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}

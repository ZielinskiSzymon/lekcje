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
    public partial class Wartownik : Form
    {
        public Wartownik()
        {
            InitializeComponent();
        }

        private void buttonSortuj_Click(object sender, EventArgs e)
        {
            try
            {
                // Parsowanie liczb z tekstu
                string[] elements = textBoxLiczby.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[elements.Length + 1]; // +1 dla wartownika

                for (int i = 0; i < elements.Length; i++)
                {
                    numbers[i + 1] = int.Parse(elements[i]); // indeks 0 zostaje dla wartownika
                }

                // Wywołanie sortowania
                InsertionSortWithSentinel(numbers);

                // Pominięcie wartownika w wynikach (indeks 0)
                int[] result = new int[numbers.Length - 1];
                Array.Copy(numbers, 1, result, 0, result.Length);

                // Wyświetlenie wyniku
                labelWynik.Text = "Posortowane liczby:\n" + string.Join(" ", result);
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

        private void InsertionSortWithSentinel(int[] array)
        {
            int n = array.Length - 1; // pomijamy pozycję 0 - to nasz wartownik

            for (int i = 2; i <= n; i++)
            {
                int value = array[i];
                int j = i - 1;

                // Ustawienie wartownika
                array[0] = value;

                while (array[j] > value)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}

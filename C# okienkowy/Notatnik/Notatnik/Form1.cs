using System;
using System.IO;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class status : Form
    {
        private string FilePath = null;

        public status()
        {
            InitializeComponent();
            textBox1.Multiline = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName;
                    textBox1.Text = File.ReadAllText(FilePath);
                    UpdateStatusBar(Path.GetFileName(FilePath));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                SaveFileAs();
            }
            else
            {
                SaveFile(FilePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void SaveFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, textBox1.Text);
                MessageBox.Show("Plik został zapisany.");
                UpdateStatusBar(Path.GetFileName(filePath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd przy zapisywaniu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFileAs()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = sfd.FileName;
                    SaveFile(FilePath);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("Nie wybrano pliku do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                File.Delete(FilePath);
                MessageBox.Show("Plik został usunięty.");
                textBox1.Clear();
                FilePath = null;
                UpdateStatusBar("Brak pliku");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd przy usuwaniu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            FilePath = null;
            UpdateStatusBar("Nowy plik");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStatusBar(string fileName)
        {
           this.Text = $"Aktualny plik: {fileName}";
        }
    }
}

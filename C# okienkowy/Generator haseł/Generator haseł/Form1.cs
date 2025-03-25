using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Generator_haseł
{
    public partial class Form1 : Form
    {
        private static readonly string SpecialCharacters = "!@#$%^&*";
        private static readonly string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string LowerCaseLetters = "abcdefghijklmnoprstuwxyz";
        private static readonly string Digits = "1234567890";

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            trackBarLength.Value = 6;
            lblLenght.Text = trackBarLength.Value.ToString();
        }

        private void trackBarLength_Scroll(object sender, EventArgs e)
        {
            lblLenght.Text = trackBarLength.Value.ToString();
        }

        private void btngeneratePassword_Click(object sender, EventArgs e)
        {
            // Generowanie hasła na podstawie wybranych opcji
            string generatePassword = GeneratePassword(trackBarLength.Value,
                chkLowerCase.Checked,
                chkNumbers.Checked,
                chkUpperCase.Checked,
                chkSpecialChars.Checked);
            txtPassword.Text = generatePassword;
        }

        private string GeneratePassword(int length, bool includeLower, bool includeNumbers, bool includeUpper, bool includeSpecial)
        {
            StringBuilder charSet = new StringBuilder();

            // Dodawanie wybranych zestawów znaków
            if (includeLower) charSet.Append(LowerCaseLetters);
            if (includeNumbers) charSet.Append(Digits);
            if (includeUpper) charSet.Append(UpperCaseLetters);
            if (includeSpecial) charSet.Append(SpecialCharacters);

            // Sprawdzanie, czy użytkownik wybrał chociaż jedną opcję
            if (charSet.Length == 0)
            {
                MessageBox.Show("Wybieraj co najmniej jedną opcje znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }

            // Tworzenie hasła
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                password.Append(charSet[random.Next(charSet.Length)]);
            }
            return password.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Kopiowanie hasła do schowka
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Hasło skopiowane do schowka!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File(.txt) |.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtPassword.Text);
                MessageBox.Show("Zapisano");
            }
        }
    }
}

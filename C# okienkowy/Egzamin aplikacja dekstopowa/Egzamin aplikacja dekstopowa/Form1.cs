using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egzamin_aplikacja_dekstopowa
{
    public partial class Form1 : Form
    {
        private string generatedpassword = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int passwordLenght = int.Parse(textBox4.Text);

            bool useUppercase = checkBox1.Checked;
            bool useDigits = checkBox2.Checked;
            bool useSpecialChars = checkBox3.Checked;
            generatedpassword = GeneratePassword(passwordLenght,useUppercase,useDigits,useSpecialChars);
        }
        private string GeneratePassword(int lenght, bool useUpercase,bool useDigits, bool useSpecialChars)
        {
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()_+-=";

            string allowedChars = lowercase;
            List<char> password = new List<char>();
            Random random = new Random();

            if (useUpercase)
            {
                allowedChars += uppercase;
                password.Add(uppercase[random.Next(uppercase.Length)]);
            }

            if(useDigits)
            {
                allowedChars += digits;
                password.Add(digits[random.Next(digits.Length)]);
            }

            if (useSpecialChars)
            {
                allowedChars += specialChars;
                password.Add(specialChars[random.Next(specialChars.Length)]);
            }

            while (password.Count < lenght)
            {
                password.Add(allowedChars[random.Next(allowedChars.Length)]);
            }

            return new string(password.OrderBy(x => random.Next()).ToArray());
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string employeeName = textBox1.Text;
            string employeeSurname = textBox2.Text;
            string position = comboBox1.SelectedItem.ToString();

            MessageBox.Show($"Dane pracownika: {employeeName} {employeeSurname} {position}, Hasło: {generatedpassword}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

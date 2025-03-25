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

namespace Okna_logowania
{
    public partial class Rejestracja : Form
    {
        private string username;
        private string password1;
        private string password2;

        public Rejestracja()
        {
            InitializeComponent();
            lblName.Text = "";
            lblPass1.Text = "";
            lblPass2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            password1 = txtPassword1.Text.Trim();
            password2 = txtPassword2.Text.Trim();

            lblPass1.Text = "";
            lblPass2.Text = "";

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password1) && !string.IsNullOrEmpty(password2))
            {
                if (UsernameChecker(username))
                {
                    if (password1.Length >= 8)
                    {
                        if (password1 == password2)
                        {
                            using (StreamWriter name = new StreamWriter("nazwa.txt", true))
                            {
                                name.WriteLine(username);
                            }
                            using (StreamWriter pass = new StreamWriter("haslo.txt", true))
                            {
                                pass.WriteLine(password1);
                            }

                            MessageBox.Show("Zarejestrowano");
                            Logowanie logowanie = new Logowanie();
                            this.Hide();
                            logowanie.ShowDialog();
                            this.Close();
                        }
                        else lblPass2.Text = "Hasła nie są takie same";
                    }
                    else lblPass1.Text = "Hasło jest za krótkie";
                }
                else lblName.Text = "Nazwa użytkownika zajęta";
            }
            else
            {
                if (string.IsNullOrEmpty(username)) lblName.Text = "Wpisz nazwę użytkownika";
                if (string.IsNullOrEmpty(password1)) lblPass1.Text = "Wpisz hasło";
                if (string.IsNullOrEmpty(password2)) lblPass2.Text = "Wpisz hasło";
            }
        }

        private bool UsernameChecker(string name)
        {
            using (StreamReader names = new StreamReader("nazwa.txt"))
            {
                while (!names.EndOfStream)
                {
                    if (names.ReadLine() == name)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

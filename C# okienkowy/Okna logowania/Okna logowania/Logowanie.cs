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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nazwa = (String)name.Text;
            String haslo = (String)password.Text;

            bool isValidUser = false;

            using (StreamReader usernameReader = new StreamReader("nazwa.txt"))
            using (StreamReader passwordReader = new StreamReader("haslo.txt"))
            {
                string usernameLine;
                while ((usernameLine = usernameReader.ReadLine()) != null)
                {
                    string passwordLine = passwordReader.ReadLine();
                    if (usernameLine == nazwa && passwordLine == haslo)
                    {
                        isValidUser = true;
                        break;
                    }
                }
            }

            if (isValidUser)
            {
                EkranKoncowy ekranKoncowy = new EkranKoncowy(nazwa, haslo);
                this.Hide();
                ekranKoncowy.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło lub nazwa");
            }
        }
    }
}

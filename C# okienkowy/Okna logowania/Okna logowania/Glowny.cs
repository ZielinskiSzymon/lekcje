using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okna_logowania
{
    public partial class Glowny : Form
    {
        public Glowny()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            this.Hide();
            logowanie.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            this.Hide();
            rejestracja.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class EkranKoncowy : Form
    {
        public EkranKoncowy(string nazwa, string haslo)
        {
            InitializeComponent();
            label1.Text = "Witaj " + nazwa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glowny glowny = new Glowny();
            this.Hide();
            glowny.ShowDialog();
            this.Close();
        }
    }
}

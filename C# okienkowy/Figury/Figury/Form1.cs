using System;
using System.Windows.Forms;

namespace Figury
{
    public partial class Form1 : Form
    {
        public static string figura = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figura = "";
            Rysuj(int.Parse(textBox1.Text));

            label1.Text = figura;

        }
        public static void Spacja(int s)
        {
            for (int i = 0; i < s; i++)
                figura += " ";
        }

        public static void Gwiazdka(int g)
        {
            for (int i = 0; i < g; i++)
                figura +="# ";
        }

        public static void Rysuj(int y)
        {
            for (int i = 0; i < y; i++)
            {
                Spacja((y - i - 1) * 2);
                Gwiazdka(2 * i + 1);
                figura+= "\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_pare_okien
{
    public partial class Form5 : Form
    {
        static string color;
        public string MessageText
        {
            set { color = value; }
        }
        public Form5()
        {
            switch (color) {
                case "red":
                    this.BackColor = Color.Red;
                    break;
                case "green":
                    this.BackColor = Color.Green;
                    break;
                case "blue":
                    this.BackColor = Color.Blue;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
            InitializeComponent();
            label1.Text = color;
        }
    }
}

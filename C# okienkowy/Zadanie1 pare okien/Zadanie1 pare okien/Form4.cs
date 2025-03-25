using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie1_pare_okien
{
    public partial class Form4 : Form
    {
        public string MessageText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public Form4()
        {
            InitializeComponent();
        }

    }
}

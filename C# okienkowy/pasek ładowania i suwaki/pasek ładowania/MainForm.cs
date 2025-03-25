using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasek_ładowania_i_suwaki
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeTrackbars();
            panel1.Height = 50;
            panel1.Width = 50;
            panel1.BackColor = Color.FromArgb(100, 100, 100);
            Red.Value = 100;
            Green.Value = 100;
            Blue.Value = 100;
            Width.Value = 50;
            Height.Value = 50;

        }

        private void InitializeTrackbars()
        {
            // Min wartość
            Red.Minimum = 0;
            Green.Minimum = 0;
            Blue.Minimum = 0;
            Width.Minimum = 50;
            Height.Minimum = 50;

            // Max wartość
            Red.Maximum = 255;
            Green.Maximum = 255;
            Blue.Maximum = 255;
            Width.Maximum = 700;
            Height.Maximum = 300;

            // Przeskok
            Red.TickFrequency = 1;
            Green.TickFrequency = 1;
            Blue.TickFrequency = 1;
            Width.TickFrequency = 1;
            Height.TickFrequency = 1;

            // Funkcja na zmiane wwartośći
            Red.ValueChanged += new EventHandler(TrackBar_ValueChanged);
            Green.ValueChanged += new EventHandler(TrackBar_ValueChanged);
            Blue.ValueChanged += new EventHandler(TrackBar_ValueChanged);
            Width.ValueChanged += new EventHandler(TrackBar_ValueChanged);
            Height.ValueChanged += new EventHandler(TrackBar_ValueChanged);

        }
        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelColor();
        }
        private void UpdatePanelColor()
        {
            int red = Red.Value, green = Green.Value, blue = Blue.Value, wide = Width.Value, height = Height.Value;

            panel1.BackColor = Color.FromArgb(red, green, blue);
            panel1.Height = height;
            panel1.Width = wide;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = 50;
            panel1.Width = 50;
            panel1.BackColor = Color.FromArgb(100,100,100);
            Red.Value = 100;
            Green.Value = 100;
            Blue.Value = 100;
            Width.Value = 50;
            Height.Value = 50;
        }
    }
}

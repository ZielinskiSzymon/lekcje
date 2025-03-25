using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suwaczki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTrackbars();
        }

        private void InitializeTrackbars()
        {
            // Min wartość
            Red.Minimum = 0;
            Green.Minimum = 0;
            Blue.Minimum = 0;

            // Max wartość
            Red.Maximum = 255;
            Green.Maximum = 255;
            Blue.Maximum = 255;

            // Przeskok
            Red.TickFrequency = 1;
            Green.TickFrequency = 1;
            Blue.TickFrequency = 1;

            // Funkcja na zmiane wwartośći
            Red.ValueChanged += new EventHandler(TrackBar_ValueChanged);
            Green.ValueChanged += new EventHandler(TrackBar_ValueChanged);
            Blue.ValueChanged += new EventHandler(TrackBar_ValueChanged);
        }
        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelColor();
        }
        private void UpdatePanelColor()
        {
            int red = Red.Value, green = Green.Value, blue = Blue.Value;

            this.BackColor = Color.FromArgb(red, green, blue);

            label1.Text = $"RGB: ({red}, {green}, {blue})";
        }


    }
}

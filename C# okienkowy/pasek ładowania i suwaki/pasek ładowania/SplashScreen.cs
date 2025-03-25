using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasek_ładowania_i_suwaki
{
    public partial class SplashScreen : Form
    {
        private Timer timer;
        private int progresValue = 0;
        public SplashScreen()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            progresValue++;

            if(progresValue <= 100)
                progressBar1.Value=progresValue;
            else
            {
                timer.Stop();
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}

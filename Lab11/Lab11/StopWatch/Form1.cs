using System;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private int hours, minutes, seconds, milliseconds;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLabel()
        {
            label1.Text = $"{hours:00}:{minutes:00}:{seconds:00}:{milliseconds:00}";
        }


        private void stopBTN_Click(object sender, EventArgs e) => timer1.Stop();

        private void startBTN_Click(object sender, EventArgs e) => timer1.Start();

        private void resetBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = minutes = seconds = milliseconds = 0;
            UpdateLabel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds += 15;

            if (milliseconds >= 1000)
            {
                milliseconds = 0;
                seconds++;
            }
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }
            UpdateLabel();
        }
    }
}

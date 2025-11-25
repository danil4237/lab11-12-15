using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        int counter = 0;
        private int seconds;

        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000;
        }
        private void UpdateLabel()
        {
            TimerOP.Text = $"Время: {seconds}";
            Counter1.Text = $"Нажатий: {counter}";
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            timer2.Start();
            counter++;
            UpdateLabel();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            seconds = 0;
            counter = 0;
            UpdateLabel();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            UpdateLabel();
        }
    }
}

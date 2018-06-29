using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MigraineAway
{
    public partial class MainForm : Form
    {
        private System.Timers.Timer countdownTimer;
        TimeSpan countdownTime;
        private TimeSpan ONE_SECOND = new TimeSpan(0, 0, 1);

        public MainForm()
        {
            InitializeComponent();
            countdownTimer = new System.Timers.Timer(1000) {
                AutoReset = false
            };
            countdownTimer.Elapsed += CountdownTimer_Elapsed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            breakTimeTextBox.Text = ConfigurationManager.AppSettings["BreakTime"];
            workTimeTextBox.Text = ConfigurationManager.AppSettings["WorkTime"];
        }

        private void startWorkButton_Click(object sender, EventArgs e)
        {
            try
            {
                countdownTime = TimeSpan.Parse(workTimeTextBox.Text);
                countdownTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            countdownTime = countdownTime.Subtract(ONE_SECOND);
            if (countdownTime <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                // End of time, flash timer warning
            }
            else
            {
                // FIXME: Change label text update to same thread
                timerLabel.Text = countdownTime.ToString();
                countdownTimer.Start();
            }
        }
    }
}

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
            catch (OverflowException)
            {
                MessageBox.Show("One value in work time is too large or has incorrect number of digits");
            }
            catch (FormatException)
            {
                MessageBox.Show("Work time value is not in correct format (hh:mm:ss)");
            }
            catch (Exception ex)
            {
                var t = ex.GetType();
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void startBreakButton_Click(object sender, EventArgs e)
        {
            try
            {
                countdownTime = TimeSpan.Parse(breakTimeTextBox.Text);
                countdownTimer.Start();
            }
            catch (OverflowException)
            {
                MessageBox.Show("One value in break time is too large or has incorrect number of digits");
            }
            catch (FormatException)
            {
                MessageBox.Show("Break time value is not in correct format (hh:mm:ss)");
            }
            catch (Exception ex)
            {
                var t = ex.GetType();
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
                countdownTimer.Start();
            }

            timerLabel.Invoke((MethodInvoker)(() => timerLabel.Text = countdownTime.ToString()));
        }
    }
}

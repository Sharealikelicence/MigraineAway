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
using MigraineAway.Enums;
using MigraineAway.Forms;

namespace MigraineAway
{

    public partial class MainForm : Form
    {
        private System.Timers.Timer countdownTimer;
        private System.Timers.Timer animationTimer;

        Color annimationColour = ColorTranslator.FromHtml("#1e8acb");

        TimeSpan countdownTime;
        private TimeSpan ONE_SECOND = new TimeSpan(0, 0, 1);
        bool colourToggle = true;

        public MainForm()
        {
            InitializeComponent();

            animationTimer = new System.Timers.Timer(1000)
            {
                AutoReset = true
            };
            animationTimer.Elapsed += AnimationTimer_Elapsed;

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
            StartTimer(TimeName.WORK, workTimeTextBox.Text);
        }

        private void startBreakButton_Click(object sender, EventArgs e)
        {
            StartTimer(TimeName.BREAK, breakTimeTextBox.Text);
        }

        private void StartTimer(TimeName timeName,string timeValue)
        {
            // Get human readable version of time name
            string timeNameDescription = EnumDescription.Get<TimeName>(timeName);

            // Stop colour annimation, if it is currently going
            StopAnimation();

            try
            {
                countdownTime = TimeSpan.Parse(timeValue);
                countdownTimer.Start();
                if (timeName == TimeName.WORK)
                    this.WindowState = FormWindowState.Minimized;
            }
            catch (OverflowException)
            {
                MessageBox.Show("One value in " + timeNameDescription + " time is too large or has incorrect number of digits");
            }
            catch (FormatException)
            {
                MessageBox.Show(timeNameDescription + " time value is not in correct format (hh:mm:ss)");
            }
            catch (Exception ex)
            {
                var t = ex.GetType();
                MessageBox.Show("Exception in " + timeNameDescription + " time : " + ex.Message);
            }
        }

        private void StartAnimation()
        {
            animationTimer.Start();
        }

        private void StopAnimation()
        {
            this.BackColor = Color.Beige;
            animationTimer.Stop();
        }

        #region Timer Event Handlers

        private void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            countdownTime = countdownTime.Subtract(ONE_SECOND);
            if (countdownTime <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                // End of time, flash timer warning
                this.Invoke((MethodInvoker)(() => this.WindowState = FormWindowState.Normal));
                this.Invoke((MethodInvoker)(() => this.TopMost = true));
                this.Invoke((MethodInvoker)(() => this.StartAnimation()));
            }
            else
            {
                countdownTimer.Start();
            }

            timerLabel.Invoke((MethodInvoker)(() => timerLabel.Text = countdownTime.ToString()));
        }

        private void AnimationTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)(() => this.BackColor = (this.colourToggle) ? Color.Beige : this.annimationColour));
            this.Invoke((MethodInvoker)(() => this.colourToggle = !this.colourToggle));
        }

        #endregion

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
    }
}

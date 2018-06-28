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

        public MainForm()
        {
            InitializeComponent();
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
                TimeSpan workTimeSpan = TimeSpan.Parse(workTimeTextBox.Text);
                countdownTimer = new System.Timers.Timer(workTimeSpan.TotalMilliseconds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}

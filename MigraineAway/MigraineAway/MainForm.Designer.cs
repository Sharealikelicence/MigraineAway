namespace MigraineAway
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workTimeLabel = new System.Windows.Forms.Label();
            this.breakTimeLabel = new System.Windows.Forms.Label();
            this.workTimeTextBox = new System.Windows.Forms.TextBox();
            this.breakTimeTextBox = new System.Windows.Forms.TextBox();
            this.startWorkButton = new System.Windows.Forms.Button();
            this.startBreakButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workTimeLabel
            // 
            this.workTimeLabel.AutoSize = true;
            this.workTimeLabel.Location = new System.Drawing.Point(19, 8);
            this.workTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workTimeLabel.Name = "workTimeLabel";
            this.workTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.workTimeLabel.TabIndex = 0;
            this.workTimeLabel.Text = "Work Time";
            // 
            // breakTimeLabel
            // 
            this.breakTimeLabel.AutoSize = true;
            this.breakTimeLabel.Location = new System.Drawing.Point(278, 7);
            this.breakTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.breakTimeLabel.Name = "breakTimeLabel";
            this.breakTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.breakTimeLabel.TabIndex = 1;
            this.breakTimeLabel.Text = "Break Time";
            // 
            // workTimeTextBox
            // 
            this.workTimeTextBox.Location = new System.Drawing.Point(86, 5);
            this.workTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.workTimeTextBox.Name = "workTimeTextBox";
            this.workTimeTextBox.Size = new System.Drawing.Size(98, 20);
            this.workTimeTextBox.TabIndex = 2;
            // 
            // breakTimeTextBox
            // 
            this.breakTimeTextBox.Location = new System.Drawing.Point(356, 3);
            this.breakTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breakTimeTextBox.Name = "breakTimeTextBox";
            this.breakTimeTextBox.Size = new System.Drawing.Size(110, 20);
            this.breakTimeTextBox.TabIndex = 3;
            // 
            // startWorkButton
            // 
            this.startWorkButton.Location = new System.Drawing.Point(69, 106);
            this.startWorkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(434, 106);
            this.startWorkButton.TabIndex = 4;
            this.startWorkButton.Text = "Start Work";
            this.startWorkButton.UseVisualStyleBackColor = true;
            this.startWorkButton.Click += new System.EventHandler(this.startWorkButton_Click);
            // 
            // startBreakButton
            // 
            this.startBreakButton.Location = new System.Drawing.Point(69, 225);
            this.startBreakButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startBreakButton.Name = "startBreakButton";
            this.startBreakButton.Size = new System.Drawing.Size(433, 102);
            this.startBreakButton.TabIndex = 5;
            this.startBreakButton.Text = "Start Break";
            this.startBreakButton.UseVisualStyleBackColor = true;
            this.startBreakButton.Click += new System.EventHandler(this.startBreakButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(61, 42);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(190, 51);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.startBreakButton);
            this.Controls.Add(this.startWorkButton);
            this.Controls.Add(this.breakTimeTextBox);
            this.Controls.Add(this.workTimeTextBox);
            this.Controls.Add(this.breakTimeLabel);
            this.Controls.Add(this.workTimeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MigraineAway";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workTimeLabel;
        private System.Windows.Forms.Label breakTimeLabel;
        private System.Windows.Forms.TextBox workTimeTextBox;
        private System.Windows.Forms.TextBox breakTimeTextBox;
        private System.Windows.Forms.Button startWorkButton;
        private System.Windows.Forms.Button startBreakButton;
        private System.Windows.Forms.Label timerLabel;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.workTimeLabel = new System.Windows.Forms.Label();
            this.breakTimeLabel = new System.Windows.Forms.Label();
            this.workTimeTextBox = new System.Windows.Forms.TextBox();
            this.breakTimeTextBox = new System.Windows.Forms.TextBox();
            this.startWorkButton = new System.Windows.Forms.Button();
            this.startBreakButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // workTimeLabel
            // 
            this.workTimeLabel.AutoSize = true;
            this.workTimeLabel.Location = new System.Drawing.Point(19, 44);
            this.workTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workTimeLabel.Name = "workTimeLabel";
            this.workTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.workTimeLabel.TabIndex = 0;
            this.workTimeLabel.Text = "Work Time";
            // 
            // breakTimeLabel
            // 
            this.breakTimeLabel.AutoSize = true;
            this.breakTimeLabel.Location = new System.Drawing.Point(267, 44);
            this.breakTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.breakTimeLabel.Name = "breakTimeLabel";
            this.breakTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.breakTimeLabel.TabIndex = 1;
            this.breakTimeLabel.Text = "Break Time";
            // 
            // workTimeTextBox
            // 
            this.workTimeTextBox.Location = new System.Drawing.Point(86, 41);
            this.workTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workTimeTextBox.Name = "workTimeTextBox";
            this.workTimeTextBox.Size = new System.Drawing.Size(98, 20);
            this.workTimeTextBox.TabIndex = 2;
            // 
            // breakTimeTextBox
            // 
            this.breakTimeTextBox.Location = new System.Drawing.Point(345, 40);
            this.breakTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.breakTimeTextBox.Name = "breakTimeTextBox";
            this.breakTimeTextBox.Size = new System.Drawing.Size(110, 20);
            this.breakTimeTextBox.TabIndex = 3;
            // 
            // startWorkButton
            // 
            this.startWorkButton.Location = new System.Drawing.Point(21, 116);
            this.startWorkButton.Margin = new System.Windows.Forms.Padding(2);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(434, 106);
            this.startWorkButton.TabIndex = 4;
            this.startWorkButton.Text = "Start Work";
            this.startWorkButton.UseVisualStyleBackColor = true;
            this.startWorkButton.Click += new System.EventHandler(this.startWorkButton_Click);
            // 
            // startBreakButton
            // 
            this.startBreakButton.Location = new System.Drawing.Point(21, 235);
            this.startBreakButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.timerLabel.Location = new System.Drawing.Point(12, 63);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(190, 51);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "00:00:00";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(477, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 363);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.startBreakButton);
            this.Controls.Add(this.startWorkButton);
            this.Controls.Add(this.breakTimeTextBox);
            this.Controls.Add(this.workTimeTextBox);
            this.Controls.Add(this.breakTimeLabel);
            this.Controls.Add(this.workTimeLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MigraineAway";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


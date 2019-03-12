namespace Project___Look_Arch_Job_Managment
{
    partial class frmTimers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimers));
            this.tabControlTimers = new System.Windows.Forms.TabControl();
            this.tabPageTimers = new System.Windows.Forms.TabPage();
            this.timerInput = new System.Windows.Forms.TextBox();
            this.buttonTimerReset = new System.Windows.Forms.Button();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStopwatch = new System.Windows.Forms.Panel();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.panelTimerTimer = new System.Windows.Forms.Panel();
            this.panelTimerStopwatch = new System.Windows.Forms.Panel();
            this.tabPageStopwatch = new System.Windows.Forms.TabPage();
            this.buttonStopwatchReset = new System.Windows.Forms.Button();
            this.buttonStopwatchStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelStopwatch = new System.Windows.Forms.Label();
            this.panelStopwatchTimer = new System.Windows.Forms.Panel();
            this.panelStopwatchStopwatch = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlTimers.SuspendLayout();
            this.tabPageTimers.SuspendLayout();
            this.tabPageStopwatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTimers
            // 
            this.tabControlTimers.Controls.Add(this.tabPageTimers);
            this.tabControlTimers.Controls.Add(this.tabPageStopwatch);
            this.tabControlTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTimers.Location = new System.Drawing.Point(12, 30);
            this.tabControlTimers.Name = "tabControlTimers";
            this.tabControlTimers.SelectedIndex = 0;
            this.tabControlTimers.Size = new System.Drawing.Size(512, 394);
            this.tabControlTimers.TabIndex = 0;
            // 
            // tabPageTimers
            // 
            this.tabPageTimers.Controls.Add(this.timerInput);
            this.tabPageTimers.Controls.Add(this.buttonTimerReset);
            this.tabPageTimers.Controls.Add(this.buttonTimerStart);
            this.tabPageTimers.Controls.Add(this.panel1);
            this.tabPageTimers.Controls.Add(this.panelStopwatch);
            this.tabPageTimers.Controls.Add(this.lblStopwatch);
            this.tabPageTimers.Controls.Add(this.lblTimer);
            this.tabPageTimers.Controls.Add(this.panelTimer);
            this.tabPageTimers.Controls.Add(this.panelTimerTimer);
            this.tabPageTimers.Controls.Add(this.panelTimerStopwatch);
            this.tabPageTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageTimers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPageTimers.Location = new System.Drawing.Point(4, 24);
            this.tabPageTimers.Name = "tabPageTimers";
            this.tabPageTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimers.Size = new System.Drawing.Size(504, 366);
            this.tabPageTimers.TabIndex = 0;
            this.tabPageTimers.Text = "Timer";
            this.tabPageTimers.UseVisualStyleBackColor = true;
            // 
            // timerInput
            // 
            this.timerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerInput.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerInput.Location = new System.Drawing.Point(75, 147);
            this.timerInput.Name = "timerInput";
            this.timerInput.Size = new System.Drawing.Size(345, 69);
            this.timerInput.TabIndex = 14;
            this.timerInput.Text = "HH:MM:SS";
            this.timerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTimerReset
            // 
            this.buttonTimerReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonTimerReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTimerReset.FlatAppearance.BorderSize = 0;
            this.buttonTimerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimerReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTimerReset.Location = new System.Drawing.Point(127, 323);
            this.buttonTimerReset.Name = "buttonTimerReset";
            this.buttonTimerReset.Size = new System.Drawing.Size(94, 31);
            this.buttonTimerReset.TabIndex = 11;
            this.buttonTimerReset.Text = "RESET";
            this.buttonTimerReset.UseVisualStyleBackColor = false;
            this.buttonTimerReset.Click += new System.EventHandler(this.buttonTimerReset_Click);
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTimerStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTimerStart.FlatAppearance.BorderSize = 0;
            this.buttonTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimerStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTimerStart.Location = new System.Drawing.Point(16, 323);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(94, 31);
            this.buttonTimerStart.TabIndex = 10;
            this.buttonTimerStart.Text = "START";
            this.buttonTimerStart.UseVisualStyleBackColor = false;
            this.buttonTimerStart.Click += new System.EventHandler(this.buttonTimerStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 1);
            this.panel1.TabIndex = 2;
            // 
            // panelStopwatch
            // 
            this.panelStopwatch.BackColor = System.Drawing.Color.Gainsboro;
            this.panelStopwatch.Location = new System.Drawing.Point(254, 63);
            this.panelStopwatch.Name = "panelStopwatch";
            this.panelStopwatch.Size = new System.Drawing.Size(250, 1);
            this.panelStopwatch.TabIndex = 1;
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopwatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStopwatch.Location = new System.Drawing.Point(318, 24);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(104, 16);
            this.lblStopwatch.TabIndex = 2;
            this.lblStopwatch.Text = "STOPWATCH";
            this.lblStopwatch.Click += new System.EventHandler(this.lblStopwatch_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer.Location = new System.Drawing.Point(72, 24);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(55, 16);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "TIMER";
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTimer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panelTimer.Location = new System.Drawing.Point(1, 63);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(255, 1);
            this.panelTimer.TabIndex = 0;
            // 
            // panelTimerTimer
            // 
            this.panelTimerTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimerTimer.Name = "panelTimerTimer";
            this.panelTimerTimer.Size = new System.Drawing.Size(256, 64);
            this.panelTimerTimer.TabIndex = 12;
            // 
            // panelTimerStopwatch
            // 
            this.panelTimerStopwatch.Location = new System.Drawing.Point(254, 0);
            this.panelTimerStopwatch.Name = "panelTimerStopwatch";
            this.panelTimerStopwatch.Size = new System.Drawing.Size(251, 64);
            this.panelTimerStopwatch.TabIndex = 13;
            this.panelTimerStopwatch.Click += new System.EventHandler(this.panelTimerStopwatch_Click);
            // 
            // tabPageStopwatch
            // 
            this.tabPageStopwatch.Controls.Add(this.buttonStopwatchReset);
            this.tabPageStopwatch.Controls.Add(this.buttonStopwatchStart);
            this.tabPageStopwatch.Controls.Add(this.panel2);
            this.tabPageStopwatch.Controls.Add(this.panel3);
            this.tabPageStopwatch.Controls.Add(this.label2);
            this.tabPageStopwatch.Controls.Add(this.label3);
            this.tabPageStopwatch.Controls.Add(this.panel4);
            this.tabPageStopwatch.Controls.Add(this.labelStopwatch);
            this.tabPageStopwatch.Controls.Add(this.panelStopwatchTimer);
            this.tabPageStopwatch.Controls.Add(this.panelStopwatchStopwatch);
            this.tabPageStopwatch.Location = new System.Drawing.Point(4, 24);
            this.tabPageStopwatch.Name = "tabPageStopwatch";
            this.tabPageStopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStopwatch.Size = new System.Drawing.Size(504, 366);
            this.tabPageStopwatch.TabIndex = 1;
            this.tabPageStopwatch.Text = "Stopwatch";
            this.tabPageStopwatch.UseVisualStyleBackColor = true;
            // 
            // buttonStopwatchReset
            // 
            this.buttonStopwatchReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonStopwatchReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStopwatchReset.FlatAppearance.BorderSize = 0;
            this.buttonStopwatchReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopwatchReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopwatchReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStopwatchReset.Location = new System.Drawing.Point(127, 324);
            this.buttonStopwatchReset.Name = "buttonStopwatchReset";
            this.buttonStopwatchReset.Size = new System.Drawing.Size(94, 31);
            this.buttonStopwatchReset.TabIndex = 18;
            this.buttonStopwatchReset.Text = "RESET";
            this.buttonStopwatchReset.UseVisualStyleBackColor = false;
            this.buttonStopwatchReset.Click += new System.EventHandler(this.buttonStopwatchReset_Click);
            // 
            // buttonStopwatchStart
            // 
            this.buttonStopwatchStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStopwatchStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStopwatchStart.FlatAppearance.BorderSize = 0;
            this.buttonStopwatchStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopwatchStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopwatchStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStopwatchStart.Location = new System.Drawing.Point(16, 324);
            this.buttonStopwatchStart.Name = "buttonStopwatchStart";
            this.buttonStopwatchStart.Size = new System.Drawing.Size(94, 31);
            this.buttonStopwatchStart.TabIndex = 17;
            this.buttonStopwatchStart.Text = "START";
            this.buttonStopwatchStart.UseVisualStyleBackColor = false;
            this.buttonStopwatchStart.Click += new System.EventHandler(this.buttonStopwatchStart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(254, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(318, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "STOPWATCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(72, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "TIMER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(1, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 1);
            this.panel4.TabIndex = 12;
            // 
            // labelStopwatch
            // 
            this.labelStopwatch.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopwatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStopwatch.Location = new System.Drawing.Point(16, 143);
            this.labelStopwatch.Name = "labelStopwatch";
            this.labelStopwatch.Size = new System.Drawing.Size(468, 70);
            this.labelStopwatch.TabIndex = 4;
            this.labelStopwatch.Text = "00:00:00";
            this.labelStopwatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelStopwatchTimer
            // 
            this.panelStopwatchTimer.Location = new System.Drawing.Point(0, 0);
            this.panelStopwatchTimer.Name = "panelStopwatchTimer";
            this.panelStopwatchTimer.Size = new System.Drawing.Size(253, 65);
            this.panelStopwatchTimer.TabIndex = 19;
            this.panelStopwatchTimer.Click += new System.EventHandler(this.panelStopwatchTimer_Click);
            // 
            // panelStopwatchStopwatch
            // 
            this.panelStopwatchStopwatch.Location = new System.Drawing.Point(252, 0);
            this.panelStopwatchStopwatch.Name = "panelStopwatchStopwatch";
            this.panelStopwatchStopwatch.Size = new System.Drawing.Size(253, 65);
            this.panelStopwatchStopwatch.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 458);
            this.Controls.Add(this.tabControlTimers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimers_FormClosing);
            this.tabControlTimers.ResumeLayout(false);
            this.tabPageTimers.ResumeLayout(false);
            this.tabPageTimers.PerformLayout();
            this.tabPageStopwatch.ResumeLayout(false);
            this.tabPageStopwatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTimers;
        private System.Windows.Forms.TabPage tabPageTimers;
        private System.Windows.Forms.TabPage tabPageStopwatch;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Panel panelStopwatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTimerReset;
        private System.Windows.Forms.Button buttonTimerStart;
        private System.Windows.Forms.Panel panelTimerTimer;
        private System.Windows.Forms.Panel panelTimerStopwatch;
        private System.Windows.Forms.Button buttonStopwatchReset;
        private System.Windows.Forms.Button buttonStopwatchStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelStopwatch;
        private System.Windows.Forms.Panel panelStopwatchTimer;
        private System.Windows.Forms.Panel panelStopwatchStopwatch;
        private System.Windows.Forms.TextBox timerInput;
        private System.Windows.Forms.Timer timer1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Reflection;


namespace Project___Look_Arch_Job_Managment
{
    public partial class frmTimers : Form
    {
        //Timer Global

        private System.Timers.Timer timerClock = new System.Timers.Timer();
        private int clockTime = 0;
        private int alarmTime = 0;
        bool buttonStartedTimer = false;

        //End


        //Stopwatch Global

        Stopwatch stopWatch = new Stopwatch();
        bool buttonStarted = false;
        string elapsedTime = null;

        //End

        public frmTimers()
        {
            InitializeComponent();
            InitializeTimer();
            //InitializeNotifyMenu();
        }


        //Form Close Validation

        private void frmTimers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (stopWatch.IsRunning == true || timerInput.Text != "HH:MM:SS")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to stop the timer?", "Stop Timer", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                
            }

            else
            {
                e.Cancel = true;
            }


        }

        //Switch Tabs

        private void panelTimerStopwatch_Click(object sender, EventArgs e)
        {
            tabControlTimers.SelectedTab = tabPageStopwatch;
        }

        private void panelStopwatchTimer_Click(object sender, EventArgs e)
        {
            tabControlTimers.SelectedTab = tabPageTimers;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tabControlTimers.SelectedTab = tabPageTimers;
        }

        private void lblStopwatch_Click(object sender, EventArgs e)
        {
            tabControlTimers.SelectedTab = tabPageStopwatch;
        }


        //Stopwatch Code

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            TimeSpan ts = stopWatch.Elapsed;

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            labelStopwatch.Text = elapsedTime;

        }
    

        private void buttonStopwatchStart_Click(object sender, EventArgs e)
        {
            if (buttonStarted == false || elapsedTime == "00:00:00")
            {
                stopWatch.Start();
                timer1.Start();

                buttonStarted = true;
            }

            else if (buttonStarted == true)
            {
                stopWatch.Stop();
                timer1.Stop();

                buttonStarted = false;

                DialogResult result = MessageBox.Show("Would you like to save time?", "Save Time", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveTimeStopwatch();
                }
                else
                {
                    
                }
            }
        }

        private void saveTimeStopwatch()
        {
            //var timeToStrip = Convert.ToDateTime(elapsedTime);

            var timeToStrip = Convert.ToDateTime(elapsedTime);

            string stripHours = Convert.ToDateTime(timeToStrip).ToString("HH");
            string stripMinutes = Convert.ToDateTime(timeToStrip).ToString("mm");
            string stripSeconds = Convert.ToDateTime(timeToStrip).ToString("ss");

            double timeInHours = Math.Round((Convert.ToDouble(stripSeconds) / 60 / 60) + (Convert.ToDouble(stripMinutes) / 60) + (Convert.ToDouble(stripHours)),2);

            //Show Form With Time Pre Inputted

            var formAddTimesheet = new frmAddTimesheet();
            formAddTimesheet.addRecordedTime(timeInHours);
            formAddTimesheet.Show();

            resetStopWatch();

        }

        private void buttonStopwatchReset_Click(object sender, EventArgs e)
        {
            resetStopWatch();
        }

        private void resetStopWatch()
        {
            stopWatch.Stop();
            stopWatch.Reset();
            timer1.Stop();

            elapsedTime = "00:00:00";
            labelStopwatch.Text = elapsedTime;
        }



        //Timer Code

        public void InitializeTimer()
        {
            this.timerClock.Elapsed += new ElapsedEventHandler(OnTimer);
            this.timerClock.Interval = 1000;
            this.timerClock.Enabled = true;
        }

        private void buttonTimerReset_Click(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            try
            {
                timerClock.Stop();
                this.clockTime = 0;
                this.alarmTime = 0;
                this.timerInput.Text = "HH:MM:SS";
                buttonStartedTimer = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ResetButton_Click(): " + ex.Message);
            }
        }

        private void buttonTimerStart_Click(object sender, EventArgs e)
        {

            if (buttonStartedTimer == false /*|| timerInput.Text == "HH:MM:SS" || timerInput.Text == "00:00:00"*/)
            {
                timerClock.Start();
                buttonStartedTimer = true;
                this.clockTime = 0;
                inputToSeconds(this.timerInput.Text);
            }

            else if (buttonStartedTimer == true)
            {
                timerClock.Stop();

                buttonStartedTimer = false;
                DialogResult result = MessageBox.Show("Would you like to save time?", "Save Time", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveTimeTimer();
                    buttonTimerReset_Click(null, null);
                }
                else
                {
                    timerClock.Start();
                    buttonStartedTimer = true;
                }
            }
        }

        private delegate void SetTextBoxTextHandler(string text);
        private void SetTextBoxt(string text)
        {
            timerInput.Text = text;
        }

        public void OnTimer(Object source, ElapsedEventArgs e)
        {
            try
            {
                clockTime++;
                int countdown = alarmTime - clockTime;
                if (alarmTime != 0)
                {
                    string formattedTime = secondsToTime(countdown);
                    if (timerInput.InvokeRequired)
                    {
                        timerInput.BeginInvoke(new SetTextBoxTextHandler(SetTextBoxt), new object[] { formattedTime });
                    }
                    else timerInput.Text = formattedTime;
                }

                if (clockTime == alarmTime)
                {
                    timerClock.Enabled = false;
                    if (timerInput.InvokeRequired)
                    {
                        timerInput.BeginInvoke(new SetTextBoxTextHandler(SetTextBoxt), new object[] { "00:00:00" });
                    }
                    else timerInput.Text = "00:00:00";
                    //Form2 b = new Form2();
                    //b.ShowDialog();

                    DialogResult result = MessageBox.Show("Time is over: Would you like to save time?", "Save Time", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        saveTimeTimer();
                    }
                    buttonTimerReset_Click(null, null);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("OnTimer(): " + ex.Message);
            }
        }

        private void inputToSeconds(string timerInput)
        {
            try
            {
                string[] timeArray = new string[3];
                int minutes = 0;
                int hours = 0;
                int seconds = 0;
                int occurence = 0;
                int length = 0;

                occurence = timerInput.LastIndexOf(":");
                length = timerInput.Length;

                //Check for invalid input
                if (occurence == -1 || length != 8)
                {
                    MessageBox.Show("Invalid Time Format.");
                    buttonTimerReset_Click(null, null);
                }
                else
                {
                    timeArray = timerInput.Split(':');

                    seconds = Convert.ToInt32(timeArray[2]);
                    minutes = Convert.ToInt32(timeArray[1]);
                    hours = Convert.ToInt32(timeArray[0]);

                    this.alarmTime += seconds;
                    this.alarmTime += minutes * 60;
                    this.alarmTime += (hours * 60) * 60;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("inputToSeconds(): " + e.Message);
            }
        }

        public string secondsToTime(int seconds)
        {
            int minutes = 0;
            int hours = 0;

            while (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            while (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            string strHours = hours.ToString();
            string strMinutes = minutes.ToString();
            string strSeconds = seconds.ToString();

            if (strHours.Length < 2) strHours = "0" + strHours;
            if (strMinutes.Length < 2) strMinutes = "0" + strMinutes;
            if (strSeconds.Length < 2) strSeconds = "0" + strSeconds;

            return strHours + ":" + strMinutes + ":" + strSeconds;

            //Remaining time Above
        }

        private void saveTimeTimer()
        {

            //Show Form With Time Pre Inputted
            //SQL with Elapsed Time
        }


    }
}

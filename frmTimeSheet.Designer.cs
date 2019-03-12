namespace Project___Look_Arch_Job_Managment
{
    partial class frmTimeSheet
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.projectID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStaff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWordstageID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBillable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.btnUpdateTime = new System.Windows.Forms.Button();
            this.btnTimers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.timesheetID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectID,
            this.projectTitle,
            this.clmStaff,
            this.clmWordstageID,
            this.clmDate,
            this.clmBillable,
            this.clmHours,
            this.timesheetID});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(11, 116);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 413);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // projectID
            // 
            this.projectID.Text = "Project ID";
            this.projectID.Width = 71;
            // 
            // projectTitle
            // 
            this.projectTitle.Text = "Project Title";
            this.projectTitle.Width = 169;
            // 
            // clmStaff
            // 
            this.clmStaff.Text = "Staff Member";
            this.clmStaff.Width = 117;
            // 
            // clmWordstageID
            // 
            this.clmWordstageID.Text = "Workstage";
            this.clmWordstageID.Width = 90;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 95;
            // 
            // clmBillable
            // 
            this.clmBillable.Text = "Billable";
            this.clmBillable.Width = 96;
            // 
            // clmHours
            // 
            this.clmHours.Text = "Hours";
            this.clmHours.Width = 66;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.ItemHeight = 16;
            this.comboBoxPeriod.Location = new System.Drawing.Point(591, 75);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPeriod.TabIndex = 3;
            this.comboBoxPeriod.Text = "Period of Time";
            // 
            // btnAddTime
            // 
            this.btnAddTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTime.FlatAppearance.BorderSize = 0;
            this.btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTime.Location = new System.Drawing.Point(11, 70);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(73, 31);
            this.btnAddTime.TabIndex = 4;
            this.btnAddTime.Text = "Add";
            this.btnAddTime.UseVisualStyleBackColor = false;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.ItemHeight = 16;
            this.comboBoxEmployee.Location = new System.Drawing.Point(472, 75);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(113, 24);
            this.comboBoxEmployee.TabIndex = 5;
            this.comboBoxEmployee.Text = "Employee";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.ItemHeight = 16;
            this.comboBoxDate.Location = new System.Drawing.Point(366, 75);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(100, 24);
            this.comboBoxDate.TabIndex = 6;
            this.comboBoxDate.Text = "Date";
            // 
            // btnUpdateTime
            // 
            this.btnUpdateTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateTime.FlatAppearance.BorderSize = 0;
            this.btnUpdateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateTime.Location = new System.Drawing.Point(99, 70);
            this.btnUpdateTime.Name = "btnUpdateTime";
            this.btnUpdateTime.Size = new System.Drawing.Size(80, 31);
            this.btnUpdateTime.TabIndex = 7;
            this.btnUpdateTime.Text = "Update";
            this.btnUpdateTime.UseVisualStyleBackColor = false;
            this.btnUpdateTime.Click += new System.EventHandler(this.btnUpdateTime_Click);
            // 
            // btnTimers
            // 
            this.btnTimers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnTimers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimers.FlatAppearance.BorderSize = 0;
            this.btnTimers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimers.Location = new System.Drawing.Point(591, 20);
            this.btnTimers.Name = "btnTimers";
            this.btnTimers.Size = new System.Drawing.Size(121, 35);
            this.btnTimers.TabIndex = 8;
            this.btnTimers.Text = "Timers";
            this.btnTimers.UseVisualStyleBackColor = false;
            this.btnTimers.Click += new System.EventHandler(this.btnTimers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(472, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Administration";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time Sheet";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(195, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 31);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // timesheetID
            // 
            this.timesheetID.Width = 0;
            // 
            // frmTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 540);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimers);
            this.Controls.Add(this.btnUpdateTime);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimeSheet";
            this.Text = "frmTimeSheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader projectID;
        private System.Windows.Forms.ColumnHeader projectTitle;
        private System.Windows.Forms.ColumnHeader clmStaff;
        private System.Windows.Forms.ColumnHeader clmWordstageID;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmBillable;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Button btnUpdateTime;
        private System.Windows.Forms.Button btnTimers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clmHours;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ColumnHeader timesheetID;
    }
}
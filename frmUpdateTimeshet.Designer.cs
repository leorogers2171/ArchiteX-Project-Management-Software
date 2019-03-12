namespace Project___Look_Arch_Job_Managment
{
    partial class frmUpdateTimeshet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateTimeshet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimesheet = new System.Windows.Forms.DateTimePicker();
            this.comboBoxChargable = new System.Windows.Forms.ComboBox();
            this.comboBoxExtraTime = new System.Windows.Forms.ComboBox();
            this.lblExtraTime = new System.Windows.Forms.Label();
            this.comboBoxWorkstage = new System.Windows.Forms.ComboBox();
            this.comboBoxStaffName = new System.Windows.Forms.ComboBox();
            this.btnUpdateTimesheet = new System.Windows.Forms.Button();
            this.lblChargable = new System.Windows.Forms.Label();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblWorkType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxHoursSpent = new System.Windows.Forms.TextBox();
            this.lblHoursSpent = new System.Windows.Forms.Label();
            this.comboBoxProjectName = new System.Windows.Forms.ComboBox();
            this.lblWorkstage = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblTimesheet = new System.Windows.Forms.Label();
            this.txtBoxTimesheetID = new System.Windows.Forms.TextBox();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 89);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimesheet
            // 
            this.dateTimesheet.Location = new System.Drawing.Point(243, 308);
            this.dateTimesheet.Name = "dateTimesheet";
            this.dateTimesheet.Size = new System.Drawing.Size(158, 20);
            this.dateTimesheet.TabIndex = 42;
            // 
            // comboBoxChargable
            // 
            this.comboBoxChargable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChargable.FormattingEnabled = true;
            this.comboBoxChargable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxChargable.Location = new System.Drawing.Point(242, 424);
            this.comboBoxChargable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChargable.Name = "comboBoxChargable";
            this.comboBoxChargable.Size = new System.Drawing.Size(159, 21);
            this.comboBoxChargable.TabIndex = 41;
            // 
            // comboBoxExtraTime
            // 
            this.comboBoxExtraTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtraTime.FormattingEnabled = true;
            this.comboBoxExtraTime.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxExtraTime.Location = new System.Drawing.Point(241, 461);
            this.comboBoxExtraTime.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExtraTime.Name = "comboBoxExtraTime";
            this.comboBoxExtraTime.Size = new System.Drawing.Size(159, 21);
            this.comboBoxExtraTime.TabIndex = 40;
            // 
            // lblExtraTime
            // 
            this.lblExtraTime.AutoSize = true;
            this.lblExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraTime.Location = new System.Drawing.Point(109, 462);
            this.lblExtraTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtraTime.Name = "lblExtraTime";
            this.lblExtraTime.Size = new System.Drawing.Size(75, 17);
            this.lblExtraTime.TabIndex = 39;
            this.lblExtraTime.Text = "Extra Time";
            // 
            // comboBoxWorkstage
            // 
            this.comboBoxWorkstage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkstage.FormattingEnabled = true;
            this.comboBoxWorkstage.Items.AddRange(new object[] {
            "Stage 1 - Planning (RIBA 1, 2, 3)",
            "Stage 2 - Building Regulations (RIBA 4)",
            "Stage 3 - Construction Information (RIBA 5)",
            "Stage 4 - Contract Administration (RIBA 5 - 6)"});
            this.comboBoxWorkstage.Location = new System.Drawing.Point(241, 226);
            this.comboBoxWorkstage.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWorkstage.Name = "comboBoxWorkstage";
            this.comboBoxWorkstage.Size = new System.Drawing.Size(159, 21);
            this.comboBoxWorkstage.TabIndex = 38;
            // 
            // comboBoxStaffName
            // 
            this.comboBoxStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStaffName.FormattingEnabled = true;
            this.comboBoxStaffName.Location = new System.Drawing.Point(241, 184);
            this.comboBoxStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStaffName.Name = "comboBoxStaffName";
            this.comboBoxStaffName.Size = new System.Drawing.Size(159, 21);
            this.comboBoxStaffName.TabIndex = 37;
            // 
            // btnUpdateTimesheet
            // 
            this.btnUpdateTimesheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdateTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTimesheet.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateTimesheet.Location = new System.Drawing.Point(112, 519);
            this.btnUpdateTimesheet.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTimesheet.Name = "btnUpdateTimesheet";
            this.btnUpdateTimesheet.Size = new System.Drawing.Size(288, 35);
            this.btnUpdateTimesheet.TabIndex = 36;
            this.btnUpdateTimesheet.Text = "Update Timesheet";
            this.btnUpdateTimesheet.UseVisualStyleBackColor = false;
            this.btnUpdateTimesheet.Click += new System.EventHandler(this.btnUpdateTimesheet_Click);
            // 
            // lblChargable
            // 
            this.lblChargable.AutoSize = true;
            this.lblChargable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargable.Location = new System.Drawing.Point(109, 425);
            this.lblChargable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChargable.Name = "lblChargable";
            this.lblChargable.Size = new System.Drawing.Size(73, 17);
            this.lblChargable.TabIndex = 35;
            this.lblChargable.Text = "Chargable";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRate.Location = new System.Drawing.Point(243, 386);
            this.txtBoxRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(158, 23);
            this.txtBoxRate.TabIndex = 34;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(109, 387);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 17);
            this.lblRate.TabIndex = 33;
            this.lblRate.Text = "Rate";
            // 
            // lblWorkType
            // 
            this.lblWorkType.AutoSize = true;
            this.lblWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkType.Location = new System.Drawing.Point(109, 349);
            this.lblWorkType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkType.Name = "lblWorkType";
            this.lblWorkType.Size = new System.Drawing.Size(77, 17);
            this.lblWorkType.TabIndex = 31;
            this.lblWorkType.Text = "Work Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(109, 308);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date";
            // 
            // txtBoxHoursSpent
            // 
            this.txtBoxHoursSpent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHoursSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoursSpent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxHoursSpent.Location = new System.Drawing.Point(243, 266);
            this.txtBoxHoursSpent.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHoursSpent.Name = "txtBoxHoursSpent";
            this.txtBoxHoursSpent.Size = new System.Drawing.Size(158, 23);
            this.txtBoxHoursSpent.TabIndex = 29;
            // 
            // lblHoursSpent
            // 
            this.lblHoursSpent.AutoSize = true;
            this.lblHoursSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursSpent.Location = new System.Drawing.Point(109, 267);
            this.lblHoursSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursSpent.Name = "lblHoursSpent";
            this.lblHoursSpent.Size = new System.Drawing.Size(87, 17);
            this.lblHoursSpent.TabIndex = 28;
            this.lblHoursSpent.Text = "Hours Spent";
            // 
            // comboBoxProjectName
            // 
            this.comboBoxProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjectName.FormattingEnabled = true;
            this.comboBoxProjectName.Location = new System.Drawing.Point(241, 143);
            this.comboBoxProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProjectName.Name = "comboBoxProjectName";
            this.comboBoxProjectName.Size = new System.Drawing.Size(159, 21);
            this.comboBoxProjectName.TabIndex = 27;
            // 
            // lblWorkstage
            // 
            this.lblWorkstage.AutoSize = true;
            this.lblWorkstage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkstage.Location = new System.Drawing.Point(109, 226);
            this.lblWorkstage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkstage.Name = "lblWorkstage";
            this.lblWorkstage.Size = new System.Drawing.Size(76, 17);
            this.lblWorkstage.TabIndex = 26;
            this.lblWorkstage.Text = "Workstage";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(109, 185);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(78, 17);
            this.lblStaffID.TabIndex = 25;
            this.lblStaffID.Text = "Staff Name";
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(109, 143);
            this.lblProjectID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(93, 17);
            this.lblProjectID.TabIndex = 24;
            this.lblProjectID.Text = "Project Name";
            // 
            // lblTimesheet
            // 
            this.lblTimesheet.AutoSize = true;
            this.lblTimesheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesheet.Location = new System.Drawing.Point(109, 106);
            this.lblTimesheet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimesheet.Name = "lblTimesheet";
            this.lblTimesheet.Size = new System.Drawing.Size(91, 17);
            this.lblTimesheet.TabIndex = 43;
            this.lblTimesheet.Text = "Timesheet ID";
            // 
            // txtBoxTimesheetID
            // 
            this.txtBoxTimesheetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTimesheetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTimesheetID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxTimesheetID.Location = new System.Drawing.Point(241, 104);
            this.txtBoxTimesheetID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTimesheetID.Name = "txtBoxTimesheetID";
            this.txtBoxTimesheetID.ReadOnly = true;
            this.txtBoxTimesheetID.Size = new System.Drawing.Size(158, 23);
            this.txtBoxTimesheetID.TabIndex = 44;
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Location = new System.Drawing.Point(243, 346);
            this.comboBoxWorkType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(159, 21);
            this.comboBoxWorkType.TabIndex = 45;
            // 
            // frmUpdateTimeshet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 573);
            this.Controls.Add(this.comboBoxWorkType);
            this.Controls.Add(this.txtBoxTimesheetID);
            this.Controls.Add(this.lblTimesheet);
            this.Controls.Add(this.dateTimesheet);
            this.Controls.Add(this.comboBoxChargable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxExtraTime);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.lblExtraTime);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.comboBoxWorkstage);
            this.Controls.Add(this.lblWorkstage);
            this.Controls.Add(this.comboBoxStaffName);
            this.Controls.Add(this.comboBoxProjectName);
            this.Controls.Add(this.btnUpdateTimesheet);
            this.Controls.Add(this.lblHoursSpent);
            this.Controls.Add(this.lblChargable);
            this.Controls.Add(this.txtBoxHoursSpent);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblWorkType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateTimeshet";
            this.Text = "ArchiteX";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimesheet;
        private System.Windows.Forms.ComboBox comboBoxChargable;
        private System.Windows.Forms.ComboBox comboBoxExtraTime;
        private System.Windows.Forms.Label lblExtraTime;
        private System.Windows.Forms.ComboBox comboBoxWorkstage;
        private System.Windows.Forms.ComboBox comboBoxStaffName;
        private System.Windows.Forms.Button btnUpdateTimesheet;
        private System.Windows.Forms.Label lblChargable;
        private System.Windows.Forms.TextBox txtBoxRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblWorkType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBoxHoursSpent;
        private System.Windows.Forms.Label lblHoursSpent;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
        private System.Windows.Forms.Label lblWorkstage;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblTimesheet;
        private System.Windows.Forms.TextBox txtBoxTimesheetID;
        private System.Windows.Forms.ComboBox comboBoxWorkType;
    }
}
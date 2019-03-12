namespace Project___Look_Arch_Job_Managment
{
    partial class frmAddTimesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTimesheet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblWorkstage = new System.Windows.Forms.Label();
            this.lblHoursSpent = new System.Windows.Forms.Label();
            this.txtBoxHoursSpent = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWorkType = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.lblChargable = new System.Windows.Forms.Label();
            this.btnAddTimesheet = new System.Windows.Forms.Button();
            this.comboBoxStaffName = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkstage = new System.Windows.Forms.ComboBox();
            this.lblExtraTime = new System.Windows.Forms.Label();
            this.comboBoxExtraTime = new System.Windows.Forms.ComboBox();
            this.comboBoxChargable = new System.Windows.Forms.ComboBox();
            this.dateTimesheet = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.comboBoxProjectName = new System.Windows.Forms.ComboBox();
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
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(109, 137);
            this.lblProjectID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(93, 17);
            this.lblProjectID.TabIndex = 2;
            this.lblProjectID.Text = "Project Name";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(109, 179);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(78, 17);
            this.lblStaffName.TabIndex = 3;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblWorkstage
            // 
            this.lblWorkstage.AutoSize = true;
            this.lblWorkstage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkstage.Location = new System.Drawing.Point(109, 220);
            this.lblWorkstage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkstage.Name = "lblWorkstage";
            this.lblWorkstage.Size = new System.Drawing.Size(76, 17);
            this.lblWorkstage.TabIndex = 5;
            this.lblWorkstage.Text = "Workstage";
            // 
            // lblHoursSpent
            // 
            this.lblHoursSpent.AutoSize = true;
            this.lblHoursSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursSpent.Location = new System.Drawing.Point(109, 292);
            this.lblHoursSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursSpent.Name = "lblHoursSpent";
            this.lblHoursSpent.Size = new System.Drawing.Size(87, 17);
            this.lblHoursSpent.TabIndex = 7;
            this.lblHoursSpent.Text = "Hours Spent";
            // 
            // txtBoxHoursSpent
            // 
            this.txtBoxHoursSpent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHoursSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoursSpent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxHoursSpent.Location = new System.Drawing.Point(243, 291);
            this.txtBoxHoursSpent.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHoursSpent.Name = "txtBoxHoursSpent";
            this.txtBoxHoursSpent.Size = new System.Drawing.Size(158, 23);
            this.txtBoxHoursSpent.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(109, 333);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblWorkType
            // 
            this.lblWorkType.AutoSize = true;
            this.lblWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkType.Location = new System.Drawing.Point(109, 374);
            this.lblWorkType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkType.Name = "lblWorkType";
            this.lblWorkType.Size = new System.Drawing.Size(77, 17);
            this.lblWorkType.TabIndex = 11;
            this.lblWorkType.Text = "Work Type";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(109, 412);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 17);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRate.Location = new System.Drawing.Point(243, 411);
            this.txtBoxRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(158, 23);
            this.txtBoxRate.TabIndex = 14;
            // 
            // lblChargable
            // 
            this.lblChargable.AutoSize = true;
            this.lblChargable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargable.Location = new System.Drawing.Point(109, 450);
            this.lblChargable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChargable.Name = "lblChargable";
            this.lblChargable.Size = new System.Drawing.Size(73, 17);
            this.lblChargable.TabIndex = 15;
            this.lblChargable.Text = "Chargable";
            // 
            // btnAddTimesheet
            // 
            this.btnAddTimesheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimesheet.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTimesheet.Location = new System.Drawing.Point(112, 544);
            this.btnAddTimesheet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTimesheet.Name = "btnAddTimesheet";
            this.btnAddTimesheet.Size = new System.Drawing.Size(288, 35);
            this.btnAddTimesheet.TabIndex = 17;
            this.btnAddTimesheet.Text = "Add Time Record";
            this.btnAddTimesheet.UseVisualStyleBackColor = false;
            this.btnAddTimesheet.Click += new System.EventHandler(this.btnAddTimesheet_Click);
            // 
            // comboBoxStaffName
            // 
            this.comboBoxStaffName.FormattingEnabled = true;
            this.comboBoxStaffName.Location = new System.Drawing.Point(241, 178);
            this.comboBoxStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStaffName.Name = "comboBoxStaffName";
            this.comboBoxStaffName.Size = new System.Drawing.Size(159, 21);
            this.comboBoxStaffName.TabIndex = 18;
            // 
            // comboBoxWorkstage
            // 
            this.comboBoxWorkstage.FormattingEnabled = true;
            this.comboBoxWorkstage.Items.AddRange(new object[] {
            "Stage 1 - Planning (RIBA 1, 2, 3)",
            "Stage 2 - Building Regulations (RIBA 4)",
            "Stage 3 - Construction Information (RIBA 5)",
            "Stage 4 - Contract Administration (RIBA 5 - 6)"});
            this.comboBoxWorkstage.Location = new System.Drawing.Point(241, 220);
            this.comboBoxWorkstage.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWorkstage.Name = "comboBoxWorkstage";
            this.comboBoxWorkstage.Size = new System.Drawing.Size(159, 21);
            this.comboBoxWorkstage.TabIndex = 19;
            this.comboBoxWorkstage.Text = "Stage 1 - Planning (RIBA 1, 2, 3)";
            // 
            // lblExtraTime
            // 
            this.lblExtraTime.AutoSize = true;
            this.lblExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraTime.Location = new System.Drawing.Point(109, 487);
            this.lblExtraTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtraTime.Name = "lblExtraTime";
            this.lblExtraTime.Size = new System.Drawing.Size(75, 17);
            this.lblExtraTime.TabIndex = 20;
            this.lblExtraTime.Text = "Extra Time";
            // 
            // comboBoxExtraTime
            // 
            this.comboBoxExtraTime.FormattingEnabled = true;
            this.comboBoxExtraTime.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxExtraTime.Location = new System.Drawing.Point(243, 487);
            this.comboBoxExtraTime.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExtraTime.Name = "comboBoxExtraTime";
            this.comboBoxExtraTime.Size = new System.Drawing.Size(159, 21);
            this.comboBoxExtraTime.TabIndex = 21;
            this.comboBoxExtraTime.Text = "No";
            // 
            // comboBoxChargable
            // 
            this.comboBoxChargable.DisplayMember = "Yes";
            this.comboBoxChargable.FormattingEnabled = true;
            this.comboBoxChargable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxChargable.Location = new System.Drawing.Point(243, 449);
            this.comboBoxChargable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChargable.Name = "comboBoxChargable";
            this.comboBoxChargable.Size = new System.Drawing.Size(159, 21);
            this.comboBoxChargable.TabIndex = 22;
            this.comboBoxChargable.Text = "Yes";
            // 
            // dateTimesheet
            // 
            this.dateTimesheet.Location = new System.Drawing.Point(243, 333);
            this.dateTimesheet.Name = "dateTimesheet";
            this.dateTimesheet.Size = new System.Drawing.Size(158, 20);
            this.dateTimesheet.TabIndex = 23;
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Location = new System.Drawing.Point(243, 373);
            this.comboBoxWorkType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(159, 21);
            this.comboBoxWorkType.TabIndex = 24;
            // 
            // comboBoxProjectName
            // 
            this.comboBoxProjectName.FormattingEnabled = true;
            this.comboBoxProjectName.Location = new System.Drawing.Point(241, 137);
            this.comboBoxProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProjectName.Name = "comboBoxProjectName";
            this.comboBoxProjectName.Size = new System.Drawing.Size(159, 21);
            this.comboBoxProjectName.TabIndex = 6;
            // 
            // frmAddTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 610);
            this.Controls.Add(this.comboBoxWorkType);
            this.Controls.Add(this.dateTimesheet);
            this.Controls.Add(this.comboBoxChargable);
            this.Controls.Add(this.comboBoxExtraTime);
            this.Controls.Add(this.lblExtraTime);
            this.Controls.Add(this.comboBoxWorkstage);
            this.Controls.Add(this.comboBoxStaffName);
            this.Controls.Add(this.btnAddTimesheet);
            this.Controls.Add(this.lblChargable);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblWorkType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBoxHoursSpent);
            this.Controls.Add(this.lblHoursSpent);
            this.Controls.Add(this.comboBoxProjectName);
            this.Controls.Add(this.lblWorkstage);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddTimesheet";
            this.Text = "ArchiteX";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblWorkstage;
        private System.Windows.Forms.Label lblHoursSpent;
        private System.Windows.Forms.TextBox txtBoxHoursSpent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWorkType;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtBoxRate;
        private System.Windows.Forms.Label lblChargable;
        private System.Windows.Forms.Button btnAddTimesheet;
        private System.Windows.Forms.ComboBox comboBoxStaffName;
        private System.Windows.Forms.ComboBox comboBoxWorkstage;
        private System.Windows.Forms.Label lblExtraTime;
        private System.Windows.Forms.ComboBox comboBoxExtraTime;
        private System.Windows.Forms.ComboBox comboBoxChargable;
        private System.Windows.Forms.DateTimePicker dateTimesheet;
        private System.Windows.Forms.ComboBox comboBoxWorkType;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
    }
}
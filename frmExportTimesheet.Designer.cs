﻿namespace Project___Look_Arch_Job_Managment
{
    partial class frmExportTimesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportTimesheet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.comboBoxExportTimesheetRange = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 89);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(367, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Export Timesheet into Excel or PDF format to easly adapt\r\nthe data.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(269, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Export To Excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddProject.Location = new System.Drawing.Point(99, 249);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(147, 35);
            this.btnAddProject.TabIndex = 20;
            this.btnAddProject.Text = "Export To PDF";
            this.btnAddProject.UseVisualStyleBackColor = false;
            // 
            // comboBoxExportTimesheetRange
            // 
            this.comboBoxExportTimesheetRange.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxExportTimesheetRange.FormattingEnabled = true;
            this.comboBoxExportTimesheetRange.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "All Records"});
            this.comboBoxExportTimesheetRange.Location = new System.Drawing.Point(209, 192);
            this.comboBoxExportTimesheetRange.Name = "comboBoxExportTimesheetRange";
            this.comboBoxExportTimesheetRange.Size = new System.Drawing.Size(122, 21);
            this.comboBoxExportTimesheetRange.TabIndex = 23;
            this.comboBoxExportTimesheetRange.Text = "Weekly";
            // 
            // frmExportTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 316);
            this.Controls.Add(this.comboBoxExportTimesheetRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExportTimesheet";
            this.Text = "ArchiteX";
            this.Load += new System.EventHandler(this.frmExportTimesheet_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ComboBox comboBoxExportTimesheetRange;
    }
}
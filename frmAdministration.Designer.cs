namespace Project___Look_Arch_Job_Managment
{
    partial class frmAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUpdateWorktype = new System.Windows.Forms.TabPage();
            this.comboBoxWorktypeID = new System.Windows.Forms.ComboBox();
            this.buttonUUpdateworktype = new System.Windows.Forms.Button();
            this.textBoxUDescription = new System.Windows.Forms.TextBox();
            this.labelUWorktype = new System.Windows.Forms.Label();
            this.labelUDescription = new System.Windows.Forms.Label();
            this.labelUWorktypeID = new System.Windows.Forms.Label();
            this.textBoxUWorktype = new System.Windows.Forms.TextBox();
            this.tabAddWorktype = new System.Windows.Forms.TabPage();
            this.buttonAAddWorktype = new System.Windows.Forms.Button();
            this.textBoxADescription = new System.Windows.Forms.TextBox();
            this.labelADescription = new System.Windows.Forms.Label();
            this.textBoxAWorktypeID = new System.Windows.Forms.TextBox();
            this.textBoxAWorktype = new System.Windows.Forms.TextBox();
            this.labelAWorktypeID = new System.Windows.Forms.Label();
            this.labelAWorktype = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmWorktypeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWorktype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabUpdateWorktype.SuspendLayout();
            this.tabAddWorktype.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 89);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUpdateWorktype);
            this.tabControl1.Controls.Add(this.tabAddWorktype);
            this.tabControl1.Location = new System.Drawing.Point(383, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 433);
            this.tabControl1.TabIndex = 19;
            // 
            // tabUpdateWorktype
            // 
            this.tabUpdateWorktype.Controls.Add(this.comboBoxWorktypeID);
            this.tabUpdateWorktype.Controls.Add(this.buttonUUpdateworktype);
            this.tabUpdateWorktype.Controls.Add(this.textBoxUDescription);
            this.tabUpdateWorktype.Controls.Add(this.labelUWorktype);
            this.tabUpdateWorktype.Controls.Add(this.labelUDescription);
            this.tabUpdateWorktype.Controls.Add(this.labelUWorktypeID);
            this.tabUpdateWorktype.Controls.Add(this.textBoxUWorktype);
            this.tabUpdateWorktype.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateWorktype.Name = "tabUpdateWorktype";
            this.tabUpdateWorktype.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateWorktype.Size = new System.Drawing.Size(403, 407);
            this.tabUpdateWorktype.TabIndex = 0;
            this.tabUpdateWorktype.Text = "Update Worktype";
            this.tabUpdateWorktype.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorktypeID
            // 
            this.comboBoxWorktypeID.FormattingEnabled = true;
            this.comboBoxWorktypeID.Location = new System.Drawing.Point(173, 34);
            this.comboBoxWorktypeID.Name = "comboBoxWorktypeID";
            this.comboBoxWorktypeID.Size = new System.Drawing.Size(207, 21);
            this.comboBoxWorktypeID.TabIndex = 20;
            this.comboBoxWorktypeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorktypeID_SelectedIndexChanged);
            // 
            // buttonUUpdateworktype
            // 
            this.buttonUUpdateworktype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonUUpdateworktype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUUpdateworktype.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonUUpdateworktype.Location = new System.Drawing.Point(57, 325);
            this.buttonUUpdateworktype.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUUpdateworktype.Name = "buttonUUpdateworktype";
            this.buttonUUpdateworktype.Size = new System.Drawing.Size(288, 35);
            this.buttonUUpdateworktype.TabIndex = 25;
            this.buttonUUpdateworktype.Text = "Update Worktype";
            this.buttonUUpdateworktype.UseVisualStyleBackColor = false;
            this.buttonUUpdateworktype.Click += new System.EventHandler(this.buttonUUpdateworktype_Click);
            // 
            // textBoxUDescription
            // 
            this.textBoxUDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUDescription.Location = new System.Drawing.Point(173, 118);
            this.textBoxUDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUDescription.Multiline = true;
            this.textBoxUDescription.Name = "textBoxUDescription";
            this.textBoxUDescription.Size = new System.Drawing.Size(207, 188);
            this.textBoxUDescription.TabIndex = 26;
            // 
            // labelUWorktype
            // 
            this.labelUWorktype.AutoSize = true;
            this.labelUWorktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUWorktype.Location = new System.Drawing.Point(40, 77);
            this.labelUWorktype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUWorktype.Name = "labelUWorktype";
            this.labelUWorktype.Size = new System.Drawing.Size(77, 17);
            this.labelUWorktype.TabIndex = 22;
            this.labelUWorktype.Text = "Work Type";
            // 
            // labelUDescription
            // 
            this.labelUDescription.AutoSize = true;
            this.labelUDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUDescription.Location = new System.Drawing.Point(40, 118);
            this.labelUDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUDescription.Name = "labelUDescription";
            this.labelUDescription.Size = new System.Drawing.Size(79, 17);
            this.labelUDescription.TabIndex = 24;
            this.labelUDescription.Text = "Description";
            // 
            // labelUWorktypeID
            // 
            this.labelUWorktypeID.AutoSize = true;
            this.labelUWorktypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUWorktypeID.Location = new System.Drawing.Point(40, 35);
            this.labelUWorktypeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUWorktypeID.Name = "labelUWorktypeID";
            this.labelUWorktypeID.Size = new System.Drawing.Size(85, 17);
            this.labelUWorktypeID.TabIndex = 21;
            this.labelUWorktypeID.Text = "Worktype ID";
            // 
            // textBoxUWorktype
            // 
            this.textBoxUWorktype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUWorktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUWorktype.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUWorktype.Location = new System.Drawing.Point(174, 76);
            this.textBoxUWorktype.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUWorktype.Name = "textBoxUWorktype";
            this.textBoxUWorktype.Size = new System.Drawing.Size(206, 23);
            this.textBoxUWorktype.TabIndex = 23;
            // 
            // tabAddWorktype
            // 
            this.tabAddWorktype.Controls.Add(this.buttonAAddWorktype);
            this.tabAddWorktype.Controls.Add(this.textBoxADescription);
            this.tabAddWorktype.Controls.Add(this.labelADescription);
            this.tabAddWorktype.Controls.Add(this.textBoxAWorktypeID);
            this.tabAddWorktype.Controls.Add(this.textBoxAWorktype);
            this.tabAddWorktype.Controls.Add(this.labelAWorktypeID);
            this.tabAddWorktype.Controls.Add(this.labelAWorktype);
            this.tabAddWorktype.Location = new System.Drawing.Point(4, 22);
            this.tabAddWorktype.Name = "tabAddWorktype";
            this.tabAddWorktype.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddWorktype.Size = new System.Drawing.Size(403, 407);
            this.tabAddWorktype.TabIndex = 1;
            this.tabAddWorktype.Text = "Add Worktype";
            this.tabAddWorktype.UseVisualStyleBackColor = true;
            // 
            // buttonAAddWorktype
            // 
            this.buttonAAddWorktype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonAAddWorktype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAAddWorktype.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAAddWorktype.Location = new System.Drawing.Point(49, 339);
            this.buttonAAddWorktype.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAAddWorktype.Name = "buttonAAddWorktype";
            this.buttonAAddWorktype.Size = new System.Drawing.Size(288, 35);
            this.buttonAAddWorktype.TabIndex = 17;
            this.buttonAAddWorktype.Text = "Add Worktype";
            this.buttonAAddWorktype.UseVisualStyleBackColor = false;
            this.buttonAAddWorktype.Click += new System.EventHandler(this.buttonAAddWorktype_Click);
            // 
            // textBoxADescription
            // 
            this.textBoxADescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxADescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxADescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxADescription.Location = new System.Drawing.Point(162, 112);
            this.textBoxADescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxADescription.Multiline = true;
            this.textBoxADescription.Name = "textBoxADescription";
            this.textBoxADescription.Size = new System.Drawing.Size(204, 198);
            this.textBoxADescription.TabIndex = 18;
            // 
            // labelADescription
            // 
            this.labelADescription.AutoSize = true;
            this.labelADescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelADescription.Location = new System.Drawing.Point(29, 112);
            this.labelADescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelADescription.Name = "labelADescription";
            this.labelADescription.Size = new System.Drawing.Size(79, 17);
            this.labelADescription.TabIndex = 5;
            this.labelADescription.Text = "Description";
            // 
            // textBoxAWorktypeID
            // 
            this.textBoxAWorktypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAWorktypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAWorktypeID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAWorktypeID.Location = new System.Drawing.Point(163, 28);
            this.textBoxAWorktypeID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAWorktypeID.Name = "textBoxAWorktypeID";
            this.textBoxAWorktypeID.Size = new System.Drawing.Size(203, 23);
            this.textBoxAWorktypeID.TabIndex = 1;
            this.textBoxAWorktypeID.Text = "LEAVE FOR AUTO NUM";
            // 
            // textBoxAWorktype
            // 
            this.textBoxAWorktype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAWorktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAWorktype.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAWorktype.Location = new System.Drawing.Point(163, 70);
            this.textBoxAWorktype.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAWorktype.Name = "textBoxAWorktype";
            this.textBoxAWorktype.Size = new System.Drawing.Size(203, 23);
            this.textBoxAWorktype.TabIndex = 4;
            // 
            // labelAWorktypeID
            // 
            this.labelAWorktypeID.AutoSize = true;
            this.labelAWorktypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAWorktypeID.Location = new System.Drawing.Point(29, 29);
            this.labelAWorktypeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAWorktypeID.Name = "labelAWorktypeID";
            this.labelAWorktypeID.Size = new System.Drawing.Size(85, 17);
            this.labelAWorktypeID.TabIndex = 2;
            this.labelAWorktypeID.Text = "Worktype ID";
            // 
            // labelAWorktype
            // 
            this.labelAWorktype.AutoSize = true;
            this.labelAWorktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAWorktype.Location = new System.Drawing.Point(29, 71);
            this.labelAWorktype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAWorktype.Name = "labelAWorktype";
            this.labelAWorktype.Size = new System.Drawing.Size(77, 17);
            this.labelAWorktype.TabIndex = 3;
            this.labelAWorktype.Text = "Work Type";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmWorktypeID,
            this.clmWorktype,
            this.clmDescription});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(11, 108);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 433);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // clmWorktypeID
            // 
            this.clmWorktypeID.Text = "Worktype ID";
            this.clmWorktypeID.Width = 101;
            // 
            // clmWorktype
            // 
            this.clmWorktype.Text = "Worktype";
            this.clmWorktype.Width = 105;
            // 
            // clmDescription
            // 
            this.clmDescription.Text = "Description";
            this.clmDescription.Width = 165;
            // 
            // frmAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(816, 578);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministration";
            this.Text = "ArchiteX";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabUpdateWorktype.ResumeLayout(false);
            this.tabUpdateWorktype.PerformLayout();
            this.tabAddWorktype.ResumeLayout(false);
            this.tabAddWorktype.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUpdateWorktype;
        private System.Windows.Forms.ComboBox comboBoxWorktypeID;
        private System.Windows.Forms.Button buttonUUpdateworktype;
        private System.Windows.Forms.TextBox textBoxUDescription;
        private System.Windows.Forms.Label labelUWorktype;
        private System.Windows.Forms.Label labelUDescription;
        private System.Windows.Forms.Label labelUWorktypeID;
        private System.Windows.Forms.TextBox textBoxUWorktype;
        private System.Windows.Forms.TabPage tabAddWorktype;
        private System.Windows.Forms.Button buttonAAddWorktype;
        private System.Windows.Forms.TextBox textBoxADescription;
        private System.Windows.Forms.Label labelADescription;
        private System.Windows.Forms.TextBox textBoxAWorktypeID;
        private System.Windows.Forms.TextBox textBoxAWorktype;
        private System.Windows.Forms.Label labelAWorktypeID;
        private System.Windows.Forms.Label labelAWorktype;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmWorktypeID;
        private System.Windows.Forms.ColumnHeader clmWorktype;
        private System.Windows.Forms.ColumnHeader clmDescription;
    }
}
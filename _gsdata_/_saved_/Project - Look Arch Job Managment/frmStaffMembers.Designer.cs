namespace Project___Look_Arch_Job_Managment
{
    partial class frmStaffMembers
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
            this.clmStaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBatchRemove = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStaffType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStaffID,
            this.clmName,
            this.clmStaffType,
            this.clmEmailAddress,
            this.clmPhoneNumber});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.listView1.Location = new System.Drawing.Point(11, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 518);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmStaffID
            // 
            this.clmStaffID.Text = "Staff ID";
            this.clmStaffID.Width = 74;
            // 
            // btnBatchRemove
            // 
            this.btnBatchRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBatchRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchRemove.ForeColor = System.Drawing.Color.White;
            this.btnBatchRemove.Location = new System.Drawing.Point(596, 488);
            this.btnBatchRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatchRemove.Name = "btnBatchRemove";
            this.btnBatchRemove.Size = new System.Drawing.Size(133, 41);
            this.btnBatchRemove.TabIndex = 7;
            this.btnBatchRemove.Text = "Batch Remove";
            this.btnBatchRemove.UseVisualStyleBackColor = false;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStaff.Location = new System.Drawing.Point(596, 65);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(133, 41);
            this.btnUpdateStaff.TabIndex = 6;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(596, 11);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(133, 41);
            this.btnAddStaff.TabIndex = 5;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 113;
            // 
            // clmEmailAddress
            // 
            this.clmEmailAddress.DisplayIndex = 2;
            this.clmEmailAddress.Text = "Email Address";
            this.clmEmailAddress.Width = 140;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.DisplayIndex = 3;
            this.clmPhoneNumber.Text = "Phone Number";
            this.clmPhoneNumber.Width = 122;
            // 
            // clmStaffType
            // 
            this.clmStaffType.DisplayIndex = 4;
            this.clmStaffType.Text = "Staff Type";
            this.clmStaffType.Width = 111;
            // 
            // frmStaffMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 540);
            this.Controls.Add(this.btnBatchRemove);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaffMembers";
            this.Text = "frmStaffMembers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmStaffID;
        private System.Windows.Forms.Button btnBatchRemove;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmStaffType;
        private System.Windows.Forms.ColumnHeader clmEmailAddress;
        private System.Windows.Forms.ColumnHeader clmPhoneNumber;
    }
}
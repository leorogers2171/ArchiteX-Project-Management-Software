namespace Project___Look_Arch_Job_Managment
{
    partial class frmExpenses
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
            this.btnBatchRemove = new System.Windows.Forms.Button();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmA4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmA3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmA1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPostage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMilage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBatchRemove
            // 
            this.btnBatchRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBatchRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchRemove.ForeColor = System.Drawing.Color.White;
            this.btnBatchRemove.Location = new System.Drawing.Point(596, 434);
            this.btnBatchRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatchRemove.Name = "btnBatchRemove";
            this.btnBatchRemove.Size = new System.Drawing.Size(133, 41);
            this.btnBatchRemove.TabIndex = 11;
            this.btnBatchRemove.Text = "Batch Remove";
            this.btnBatchRemove.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExpense.ForeColor = System.Drawing.Color.White;
            this.btnUpdateExpense.Location = new System.Drawing.Point(596, 65);
            this.btnUpdateExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(133, 41);
            this.btnUpdateExpense.TabIndex = 10;
            this.btnUpdateExpense.Text = "Update Expense";
            this.btnUpdateExpense.UseVisualStyleBackColor = false;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(596, 11);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(133, 41);
            this.btnAddExpense.TabIndex = 9;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDate,
            this.clmProject,
            this.clmA4,
            this.clmA3,
            this.clmA1,
            this.clmPostage,
            this.clmMilage});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.listView1.Location = new System.Drawing.Point(11, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 518);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            // 
            // clmProject
            // 
            this.clmProject.Text = "Project";
            this.clmProject.Width = 132;
            // 
            // clmA4
            // 
            this.clmA4.Text = "Paper A4";
            this.clmA4.Width = 81;
            // 
            // clmA3
            // 
            this.clmA3.Text = "Paper A3";
            this.clmA3.Width = 75;
            // 
            // clmA1
            // 
            this.clmA1.Text = "Paper A1";
            this.clmA1.Width = 74;
            // 
            // clmPostage
            // 
            this.clmPostage.Text = "P & P";
            this.clmPostage.Width = 63;
            // 
            // clmMilage
            // 
            this.clmMilage.Text = "Milage";
            this.clmMilage.Width = 75;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(596, 488);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 41);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 540);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBatchRemove);
            this.Controls.Add(this.btnUpdateExpense);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpenses";
            this.Text = "frmExpenses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBatchRemove;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmProject;
        private System.Windows.Forms.ColumnHeader clmA4;
        private System.Windows.Forms.ColumnHeader clmA3;
        private System.Windows.Forms.ColumnHeader clmA1;
        private System.Windows.Forms.ColumnHeader clmPostage;
        private System.Windows.Forms.ColumnHeader clmMilage;
    }
}
namespace BookBiz.GUI
{
    partial class Employees
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_employee = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.maskedtextboxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(128, 121);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(103, 38);
            this.ButtonExit.TabIndex = 21;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 217;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 163;
            // 
            // listView_employee
            // 
            this.listView_employee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_employee.GridLines = true;
            this.listView_employee.HideSelection = false;
            this.listView_employee.Location = new System.Drawing.Point(24, 247);
            this.listView_employee.Name = "listView_employee";
            this.listView_employee.Size = new System.Drawing.Size(754, 143);
            this.listView_employee.TabIndex = 20;
            this.listView_employee.UseCompatibleStateImageBehavior = false;
            this.listView_employee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone Number";
            this.columnHeader3.Width = 191;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(230, 77);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(91, 38);
            this.buttonList.TabIndex = 18;
            this.buttonList.Text = "&List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(39, 77);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(109, 38);
            this.buttonadd.TabIndex = 17;
            this.buttonadd.Text = "&Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // maskedtextboxPhoneNumber
            // 
            this.maskedtextboxPhoneNumber.Location = new System.Drawing.Point(349, 44);
            this.maskedtextboxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedtextboxPhoneNumber.Name = "maskedtextboxPhoneNumber";
            this.maskedtextboxPhoneNumber.Size = new System.Drawing.Size(136, 22);
            this.maskedtextboxPhoneNumber.TabIndex = 16;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(185, 44);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(136, 22);
            this.textboxName.TabIndex = 15;
            // 
            // textboxEmployeeId
            // 
            this.textboxEmployeeId.Location = new System.Drawing.Point(24, 44);
            this.textboxEmployeeId.Name = "textboxEmployeeId";
            this.textboxEmployeeId.Size = new System.Drawing.Size(136, 22);
            this.textboxEmployeeId.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee ID";
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(404, 146);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(136, 22);
            this.textboxSearch.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(574, 130);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 38);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Employee ID";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.listView_employee);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.maskedtextboxPhoneNumber);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxEmployeeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView_employee;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.MaskedTextBox maskedtextboxPhoneNumber;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
    }
}
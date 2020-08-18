namespace BookBiz.GUI
{
    partial class User
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_user = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonList = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.textboxEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxPost = new System.Windows.Forms.TextBox();
            this.textboxUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(119, 125);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 25);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Designation";
            this.columnHeader2.Width = 233;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 217;
            // 
            // listView_user
            // 
            this.listView_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_user.GridLines = true;
            this.listView_user.HideSelection = false;
            this.listView_user.Location = new System.Drawing.Point(38, 199);
            this.listView_user.Name = "listView_user";
            this.listView_user.Size = new System.Drawing.Size(667, 123);
            this.listView_user.TabIndex = 20;
            this.listView_user.UseCompatibleStateImageBehavior = false;
            this.listView_user.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee ID";
            this.columnHeader3.Width = 203;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(694, 110);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(83, 40);
            this.ButtonSearch.TabIndex = 9;
            this.ButtonSearch.Text = "S&earch";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(546, 128);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(128, 22);
            this.textboxSearch.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter User ID";
            // 
            // ButtonList
            // 
            this.ButtonList.Location = new System.Drawing.Point(192, 84);
            this.ButtonList.Name = "ButtonList";
            this.ButtonList.Size = new System.Drawing.Size(75, 35);
            this.ButtonList.TabIndex = 18;
            this.ButtonList.Text = "&List";
            this.ButtonList.UseVisualStyleBackColor = true;
            this.ButtonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(38, 84);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(78, 35);
            this.ButtonAdd.TabIndex = 17;
            this.ButtonAdd.Text = "&Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textboxEmpID
            // 
            this.textboxEmpID.Location = new System.Drawing.Point(282, 40);
            this.textboxEmpID.Name = "textboxEmpID";
            this.textboxEmpID.Size = new System.Drawing.Size(128, 22);
            this.textboxEmpID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Employee ID";
            // 
            // textboxPost
            // 
            this.textboxPost.Location = new System.Drawing.Point(123, 40);
            this.textboxPost.Name = "textboxPost";
            this.textboxPost.Size = new System.Drawing.Size(128, 22);
            this.textboxPost.TabIndex = 14;
            // 
            // textboxUserID
            // 
            this.textboxUserID.Location = new System.Drawing.Point(12, 40);
            this.textboxUserID.Name = "textboxUserID";
            this.textboxUserID.Size = new System.Drawing.Size(92, 22);
            this.textboxUserID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Post";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listView_user);
            this.Controls.Add(this.ButtonList);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textboxEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxPost);
            this.Controls.Add(this.textboxUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView_user;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonList;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox textboxEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxPost;
        private System.Windows.Forms.TextBox textboxUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace BookBiz.GUI
{
    partial class Books
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
            this.listviewBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.ButtonAddToList = new System.Windows.Forms.Button();
            this.textboxQuantityOnHand = new System.Windows.Forms.TextBox();
            this.textboxYearPublished = new System.Windows.Forms.TextBox();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.textboxUnitPrice = new System.Windows.Forms.TextBox();
            this.textboxisbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(338, 370);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 38);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listviewBook
            // 
            this.listviewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listviewBook.GridLines = true;
            this.listviewBook.HideSelection = false;
            this.listviewBook.Location = new System.Drawing.Point(56, 221);
            this.listviewBook.Name = "listviewBook";
            this.listviewBook.Size = new System.Drawing.Size(685, 128);
            this.listviewBook.TabIndex = 28;
            this.listviewBook.UseCompatibleStateImageBehavior = false;
            this.listviewBook.View = System.Windows.Forms.View.Details;
            this.listviewBook.SelectedIndexChanged += new System.EventHandler(this.listviewBook_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year Published";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity on Hand";
            this.columnHeader5.Width = 118;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(418, 158);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 28);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "S&earch";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(243, 164);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(116, 22);
            this.textboxSearch.TabIndex = 13;
            this.textboxSearch.TextChanged += new System.EventHandler(this.textboxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter ISBN to search";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(592, 34);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(107, 25);
            this.buttonList.TabIndex = 26;
            this.buttonList.Text = "&List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // ButtonAddToList
            // 
            this.ButtonAddToList.Location = new System.Drawing.Point(430, 34);
            this.ButtonAddToList.Name = "ButtonAddToList";
            this.ButtonAddToList.Size = new System.Drawing.Size(107, 28);
            this.ButtonAddToList.TabIndex = 25;
            this.ButtonAddToList.Text = "Add to List";
            this.ButtonAddToList.UseVisualStyleBackColor = true;
            this.ButtonAddToList.Click += new System.EventHandler(this.ButtonAddToList_Click);
            // 
            // textboxQuantityOnHand
            // 
            this.textboxQuantityOnHand.Location = new System.Drawing.Point(87, 164);
            this.textboxQuantityOnHand.Name = "textboxQuantityOnHand";
            this.textboxQuantityOnHand.Size = new System.Drawing.Size(116, 22);
            this.textboxQuantityOnHand.TabIndex = 24;
            this.textboxQuantityOnHand.TextChanged += new System.EventHandler(this.textboxQuantityOnHand_TextChanged);
            // 
            // textboxYearPublished
            // 
            this.textboxYearPublished.Location = new System.Drawing.Point(243, 103);
            this.textboxYearPublished.Name = "textboxYearPublished";
            this.textboxYearPublished.Size = new System.Drawing.Size(116, 22);
            this.textboxYearPublished.TabIndex = 23;
            this.textboxYearPublished.TextChanged += new System.EventHandler(this.textboxYearPublished_TextChanged);
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(244, 40);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(116, 22);
            this.textboxTitle.TabIndex = 22;
            this.textboxTitle.TextChanged += new System.EventHandler(this.textboxTitle_TextChanged);
            // 
            // textboxUnitPrice
            // 
            this.textboxUnitPrice.Location = new System.Drawing.Point(87, 103);
            this.textboxUnitPrice.Name = "textboxUnitPrice";
            this.textboxUnitPrice.Size = new System.Drawing.Size(116, 22);
            this.textboxUnitPrice.TabIndex = 21;
            this.textboxUnitPrice.TextChanged += new System.EventHandler(this.textboxUnitPrice_TextChanged);
            // 
            // textboxisbn
            // 
            this.textboxisbn.Location = new System.Drawing.Point(87, 40);
            this.textboxisbn.Name = "textboxisbn";
            this.textboxisbn.Size = new System.Drawing.Size(116, 22);
            this.textboxisbn.TabIndex = 20;
            this.textboxisbn.TextChanged += new System.EventHandler(this.textboxisbn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quantity on Hand";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year Published";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unit Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listviewBook);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.ButtonAddToList);
            this.Controls.Add(this.textboxQuantityOnHand);
            this.Controls.Add(this.textboxYearPublished);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.textboxUnitPrice);
            this.Controls.Add(this.textboxisbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listviewBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button ButtonAddToList;
        private System.Windows.Forms.TextBox textboxQuantityOnHand;
        private System.Windows.Forms.TextBox textboxYearPublished;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.TextBox textboxUnitPrice;
        private System.Windows.Forms.TextBox textboxisbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
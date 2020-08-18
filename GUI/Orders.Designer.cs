namespace BookBiz.GUI
{
    partial class Orders
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
            this.buttonList = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewOrders = new System.Windows.Forms.ListView();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.textboxbQuantity = new System.Windows.Forms.TextBox();
            this.textboxBookId = new System.Windows.Forms.TextBox();
            this.textboxClientId = new System.Windows.Forms.TextBox();
            this.textboxOrderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(641, 22);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(79, 35);
            this.buttonList.TabIndex = 28;
            this.buttonList.Text = "&List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 188;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Book ID";
            this.columnHeader3.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client ID";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 187;
            // 
            // listviewOrders
            // 
            this.listviewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listviewOrders.GridLines = true;
            this.listviewOrders.HideSelection = false;
            this.listviewOrders.Location = new System.Drawing.Point(13, 199);
            this.listviewOrders.Name = "listviewOrders";
            this.listviewOrders.Size = new System.Drawing.Size(775, 188);
            this.listviewOrders.TabIndex = 26;
            this.listviewOrders.UseCompatibleStateImageBehavior = false;
            this.listviewOrders.View = System.Windows.Forms.View.Details;
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(303, 35);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(121, 22);
            this.textboxSearch.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Order ID";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(384, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(276, 67);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(93, 28);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "S&earch";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(545, 113);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 48);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(512, 22);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(110, 35);
            this.buttonAddToList.TabIndex = 24;
            this.buttonAddToList.Text = "Add To List";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // textboxbQuantity
            // 
            this.textboxbQuantity.Location = new System.Drawing.Point(157, 100);
            this.textboxbQuantity.Name = "textboxbQuantity";
            this.textboxbQuantity.Size = new System.Drawing.Size(111, 22);
            this.textboxbQuantity.TabIndex = 23;
            // 
            // textboxBookId
            // 
            this.textboxBookId.Location = new System.Drawing.Point(13, 100);
            this.textboxBookId.Name = "textboxBookId";
            this.textboxBookId.Size = new System.Drawing.Size(111, 22);
            this.textboxBookId.TabIndex = 22;
            // 
            // textboxClientId
            // 
            this.textboxClientId.Location = new System.Drawing.Point(157, 35);
            this.textboxClientId.Name = "textboxClientId";
            this.textboxClientId.Size = new System.Drawing.Size(111, 22);
            this.textboxClientId.TabIndex = 21;
            // 
            // textboxOrderId
            // 
            this.textboxOrderId.Location = new System.Drawing.Point(13, 35);
            this.textboxOrderId.Name = "textboxOrderId";
            this.textboxOrderId.Size = new System.Drawing.Size(111, 22);
            this.textboxOrderId.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Book ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client ID";
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Location = new System.Drawing.Point(29, 15);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(62, 17);
            this.labelOrderId.TabIndex = 16;
            this.labelOrderId.Text = "Order ID";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.listviewOrders);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.textboxbQuantity);
            this.Controls.Add(this.textboxBookId);
            this.Controls.Add(this.textboxClientId);
            this.Controls.Add(this.textboxOrderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrderId);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listviewOrders;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.TextBox textboxbQuantity;
        private System.Windows.Forms.TextBox textboxBookId;
        private System.Windows.Forms.TextBox textboxClientId;
        private System.Windows.Forms.TextBox textboxOrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrderId;
    }
}
namespace BookBiz.GUI
{
    partial class Clients
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
            this.label_search = new System.Windows.Forms.Label();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textboxPostalCode = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textboxFaxNumber = new System.Windows.Forms.TextBox();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.maskedtextboxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textboxCreditLimit = new System.Windows.Forms.TextBox();
            this.texbBoxClientName = new System.Windows.Forms.TextBox();
            this.textboxCity = new System.Windows.Forms.TextBox();
            this.textboxStreet = new System.Windows.Forms.TextBox();
            this.textboxClientId = new System.Windows.Forms.TextBox();
            this.label_credit_limit = new System.Windows.Forms.Label();
            this.label_fax = new System.Windows.Forms.Label();
            this.label_phone_no = new System.Windows.Forms.Label();
            this.label_client_id = new System.Windows.Forms.Label();
            this.label_postal_code = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_street = new System.Windows.Forms.Label();
            this.label_client_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(417, 22);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(161, 17);
            this.label_search.TabIndex = 25;
            this.label_search.Text = "Enter Client ID to search";
            // 
            // textboxSearch
            // 
            this.textboxSearch.Location = new System.Drawing.Point(420, 53);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(158, 22);
            this.textboxSearch.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(420, 87);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 37);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "S&earch";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textboxPostalCode
            // 
            this.textboxPostalCode.Location = new System.Drawing.Point(231, 133);
            this.textboxPostalCode.Name = "textboxPostalCode";
            this.textboxPostalCode.Size = new System.Drawing.Size(130, 22);
            this.textboxPostalCode.TabIndex = 49;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(575, 143);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(212, 58);
            this.buttonExit.TabIndex = 48;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Credit Limit";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fax Number";
            this.columnHeader7.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phone Number";
            this.columnHeader6.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Postal Code";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "City";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Street";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client Name";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client ID";
            this.columnHeader1.Width = 90;
            // 
            // textboxFaxNumber
            // 
            this.textboxFaxNumber.Location = new System.Drawing.Point(54, 195);
            this.textboxFaxNumber.Name = "textboxFaxNumber";
            this.textboxFaxNumber.Size = new System.Drawing.Size(130, 22);
            this.textboxFaxNumber.TabIndex = 50;
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewClient.GridLines = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(2, 250);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(866, 154);
            this.listViewClient.TabIndex = 47;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(764, 40);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(104, 30);
            this.buttonList.TabIndex = 46;
            this.buttonList.Text = "&List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(642, 39);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(104, 31);
            this.buttonAddToList.TabIndex = 45;
            this.buttonAddToList.Text = "&Add to List";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // maskedtextboxPhoneNumber
            // 
            this.maskedtextboxPhoneNumber.Location = new System.Drawing.Point(54, 133);
            this.maskedtextboxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedtextboxPhoneNumber.Name = "maskedtextboxPhoneNumber";
            this.maskedtextboxPhoneNumber.Size = new System.Drawing.Size(130, 22);
            this.maskedtextboxPhoneNumber.TabIndex = 44;
            // 
            // textboxCreditLimit
            // 
            this.textboxCreditLimit.Location = new System.Drawing.Point(231, 195);
            this.textboxCreditLimit.Name = "textboxCreditLimit";
            this.textboxCreditLimit.Size = new System.Drawing.Size(130, 22);
            this.textboxCreditLimit.TabIndex = 43;
            // 
            // texbBoxClientName
            // 
            this.texbBoxClientName.Location = new System.Drawing.Point(54, 78);
            this.texbBoxClientName.Name = "texbBoxClientName";
            this.texbBoxClientName.Size = new System.Drawing.Size(130, 22);
            this.texbBoxClientName.TabIndex = 42;
            // 
            // textboxCity
            // 
            this.textboxCity.Location = new System.Drawing.Point(231, 78);
            this.textboxCity.Name = "textboxCity";
            this.textboxCity.Size = new System.Drawing.Size(130, 22);
            this.textboxCity.TabIndex = 41;
            // 
            // textboxStreet
            // 
            this.textboxStreet.Location = new System.Drawing.Point(231, 22);
            this.textboxStreet.Name = "textboxStreet";
            this.textboxStreet.Size = new System.Drawing.Size(130, 22);
            this.textboxStreet.TabIndex = 40;
            // 
            // textboxClientId
            // 
            this.textboxClientId.Location = new System.Drawing.Point(54, 19);
            this.textboxClientId.Name = "textboxClientId";
            this.textboxClientId.Size = new System.Drawing.Size(130, 22);
            this.textboxClientId.TabIndex = 39;
            // 
            // label_credit_limit
            // 
            this.label_credit_limit.AutoSize = true;
            this.label_credit_limit.Location = new System.Drawing.Point(242, 175);
            this.label_credit_limit.Name = "label_credit_limit";
            this.label_credit_limit.Size = new System.Drawing.Size(78, 17);
            this.label_credit_limit.TabIndex = 38;
            this.label_credit_limit.Text = "Credit Limit";
            // 
            // label_fax
            // 
            this.label_fax.AutoSize = true;
            this.label_fax.Location = new System.Drawing.Point(57, 175);
            this.label_fax.Name = "label_fax";
            this.label_fax.Size = new System.Drawing.Size(84, 17);
            this.label_fax.TabIndex = 37;
            this.label_fax.Text = "Fax Number";
            // 
            // label_phone_no
            // 
            this.label_phone_no.AutoSize = true;
            this.label_phone_no.Location = new System.Drawing.Point(57, 113);
            this.label_phone_no.Name = "label_phone_no";
            this.label_phone_no.Size = new System.Drawing.Size(103, 17);
            this.label_phone_no.TabIndex = 36;
            this.label_phone_no.Text = "Phone Number";
            // 
            // label_client_id
            // 
            this.label_client_id.AutoSize = true;
            this.label_client_id.Location = new System.Drawing.Point(51, -2);
            this.label_client_id.Name = "label_client_id";
            this.label_client_id.Size = new System.Drawing.Size(60, 17);
            this.label_client_id.TabIndex = 35;
            this.label_client_id.Text = "Client ID";
            // 
            // label_postal_code
            // 
            this.label_postal_code.AutoSize = true;
            this.label_postal_code.Location = new System.Drawing.Point(242, 113);
            this.label_postal_code.Name = "label_postal_code";
            this.label_postal_code.Size = new System.Drawing.Size(84, 17);
            this.label_postal_code.TabIndex = 34;
            this.label_postal_code.Text = "Postal Code";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(242, 58);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(31, 17);
            this.label_city.TabIndex = 33;
            this.label_city.Text = "City";
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(242, -2);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(46, 17);
            this.label_street.TabIndex = 32;
            this.label_street.Text = "Street";
            // 
            // label_client_name
            // 
            this.label_client_name.AutoSize = true;
            this.label_client_name.Location = new System.Drawing.Point(57, 58);
            this.label_client_name.Name = "label_client_name";
            this.label_client_name.Size = new System.Drawing.Size(84, 17);
            this.label_client_name.TabIndex = 30;
            this.label_client_name.Text = "Client Name";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 491);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.textboxPostalCode);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textboxFaxNumber);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.maskedtextboxPhoneNumber);
            this.Controls.Add(this.textboxCreditLimit);
            this.Controls.Add(this.texbBoxClientName);
            this.Controls.Add(this.textboxCity);
            this.Controls.Add(this.textboxStreet);
            this.Controls.Add(this.textboxClientId);
            this.Controls.Add(this.label_credit_limit);
            this.Controls.Add(this.label_fax);
            this.Controls.Add(this.label_phone_no);
            this.Controls.Add(this.label_client_id);
            this.Controls.Add(this.label_postal_code);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_street);
            this.Controls.Add(this.label_client_name);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textboxPostalCode;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textboxFaxNumber;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.MaskedTextBox maskedtextboxPhoneNumber;
        private System.Windows.Forms.TextBox textboxCreditLimit;
        private System.Windows.Forms.TextBox texbBoxClientName;
        private System.Windows.Forms.TextBox textboxCity;
        private System.Windows.Forms.TextBox textboxStreet;
        private System.Windows.Forms.TextBox textboxClientId;
        private System.Windows.Forms.Label label_credit_limit;
        private System.Windows.Forms.Label label_fax;
        private System.Windows.Forms.Label label_phone_no;
        private System.Windows.Forms.Label label_client_id;
        private System.Windows.Forms.Label label_postal_code;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.Label label_client_name;
    }
}
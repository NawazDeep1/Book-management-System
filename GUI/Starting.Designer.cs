namespace BookBiz.GUI
{
    partial class Starting
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonSalesManager = new System.Windows.Forms.Button();
            this.buttonInventoryController = new System.Windows.Forms.Button();
            this.buttonOrderClerks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(27, 35);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(148, 38);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonSalesManager
            // 
            this.buttonSalesManager.Location = new System.Drawing.Point(447, 117);
            this.buttonSalesManager.Name = "buttonSalesManager";
            this.buttonSalesManager.Size = new System.Drawing.Size(148, 38);
            this.buttonSalesManager.TabIndex = 0;
            this.buttonSalesManager.Text = "Sales Manager";
            this.buttonSalesManager.UseVisualStyleBackColor = true;
            this.buttonSalesManager.Click += new System.EventHandler(this.buttonSalesManager_Click);
            // 
            // buttonInventoryController
            // 
            this.buttonInventoryController.Location = new System.Drawing.Point(444, 67);
            this.buttonInventoryController.Name = "buttonInventoryController";
            this.buttonInventoryController.Size = new System.Drawing.Size(151, 38);
            this.buttonInventoryController.TabIndex = 0;
            this.buttonInventoryController.Text = "Inventory Controller";
            this.buttonInventoryController.UseVisualStyleBackColor = true;
            this.buttonInventoryController.Click += new System.EventHandler(this.buttonInventoryController_Click);
            // 
            // buttonOrderClerks
            // 
            this.buttonOrderClerks.Location = new System.Drawing.Point(444, 174);
            this.buttonOrderClerks.Name = "buttonOrderClerks";
            this.buttonOrderClerks.Size = new System.Drawing.Size(151, 38);
            this.buttonOrderClerks.TabIndex = 0;
            this.buttonOrderClerks.Text = "Order Clerks";
            this.buttonOrderClerks.UseVisualStyleBackColor = true;
            this.buttonOrderClerks.Click += new System.EventHandler(this.buttonOrderClerks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Any";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(368, 240);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEmployee);
            this.groupBox1.Controls.Add(this.buttonUsers);
            this.groupBox1.Location = new System.Drawing.Point(150, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MIS Manager";
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Location = new System.Drawing.Point(27, 79);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(148, 38);
            this.buttonEmployee.TabIndex = 0;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrderClerks);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInventoryController);
            this.Controls.Add(this.buttonSalesManager);
            this.Name = "Start";
            this.ShowIcon = false;
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonSalesManager;
        private System.Windows.Forms.Button buttonInventoryController;
        private System.Windows.Forms.Button buttonOrderClerks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEmployee;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.BLL;
using BookBiz.DAL;
using BookBiz.Validation;

namespace BookBiz.GUI
{
    public partial class User : Form
    {
        private void ClearAll()
        {
            textboxPost.Clear();
            textboxEmpID.Clear();
            textboxUserID.Clear();
        }
        public User()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxSearch.Text))
            {
                MessageBox.Show("Please enter Employee ID", "Search not Possible");
            }
            else
            {
                Users user = UserDA.Search(Convert.ToInt32(textboxSearch.Text));

                if (user != null)
                {
                    textboxUserID.Text = user.UserID.ToString();
                    textboxPost.Text = user.Post;
                    textboxEmpID.Text = user.EmployeeID.ToString();
                    textboxSearch.Clear();
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Search Failed");
                    textboxSearch.Clear();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Starting start= new Starting();
                start.ShowDialog();
                this.Close();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (UsersValidation.isValidID(textboxUserID) && UsersValidation.isValidName(textboxPost) && UsersValidation.isValidEmployee(textboxEmpID))
            {
                user.UserID = Convert.ToInt32(textboxUserID.Text);
                user.Post = textboxPost.Text;
                user.EmployeeID = Convert.ToInt32(textboxEmpID.Text);
                UserDA.Add(user);
                ClearAll();
            }
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            listView_user.Items.Clear();
            UserDA.ListUsers(listView_user);
        }
    }
}

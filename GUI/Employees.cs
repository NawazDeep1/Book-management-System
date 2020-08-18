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
using BookBiz.Validation;
using BookBiz.DAL;

namespace BookBiz.GUI
{
    public partial class Employees : Form
    {
        private void ClearAll()
        {
            textboxEmployeeId.Clear();
            textboxName.Clear();
            maskedtextboxPhoneNumber.Clear();
        }
        public Employees()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (EmployeeValidation.isValidID(textboxEmployeeId) && EmployeeValidation.isValidName(textboxName))
            {
                emp.EmployeeID = Convert.ToInt32(textboxEmployeeId.Text);
                emp.Name = textboxName.Text;
                emp.PhoneNumber = maskedtextboxPhoneNumber.Text;
                EmployeeDA.Add(emp);
                ClearAll();
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (EmployeeValidation.isValidID(textboxEmployeeId) && EmployeeValidation.isValidName(textboxName))
            {
                emp.EmployeeID = Convert.ToInt32(textboxEmployeeId.Text);
                emp.Name = textboxName.Text;
                emp.PhoneNumber = maskedtextboxPhoneNumber.Text;
                EmployeeDA.Add(emp);
                ClearAll();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxSearch.Text))
            {
                MessageBox.Show("Enter Employee ID", "Search not Possible");
            }
            else
            {
                Employee emp = EmployeeDA.Search(Convert.ToInt32(textboxSearch.Text));

                if (emp != null)
                {
                    textboxEmployeeId.Text = emp.EmployeeID.ToString();
                    textboxName.Text = emp.Name;
                    maskedtextboxPhoneNumber.Text = emp.PhoneNumber;
                    textboxSearch.Clear();
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Error");
                    textboxSearch.Clear();
                }
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to Exit?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Starting start= new Starting();
                start.ShowDialog();
                this.Close();
            }
        }
    }
}

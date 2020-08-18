using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBiz.BLL;
using System.Windows.Forms;
using System.IO;

namespace BookBiz.Validation
{
    public class UsersValidation
    {
        private static string filePathEmployee = Application.StartupPath + @"\Employees.dat";

        public static bool isValidID(TextBox text)
        {
            int tempID;
            if (text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid User ID, it must be 5 digit number", "Invalid ID");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool isValidName(TextBox name)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Designation is Mandatory", "Invalid Designation");
                name.Clear();
                name.Focus();
                isValid = false;
            }
            else
            {
                for (int i = 0; i < name.TextLength; i++)
                {
                    if (char.IsDigit(name.Text, i))
                    {
                        MessageBox.Show("Please enter correct Designation", "Invalid Designation");
                        name.Clear();
                        name.Focus();
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        public static bool isValidEmployee(TextBox text)
        {
            var flag = 0;
            var isValid = true;
            StreamReader sReader = new StreamReader(filePathEmployee);
            string line = sReader.ReadLine();

            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Please Enter Employee ID");
                isValid = false;
                text.Clear();
                text.Focus();
            }
            else
            {
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(text.Text) == Convert.ToInt32(fields[0]))
                    {
                        isValid = true;
                        flag = 1;
                    }
                    else
                    {
                        isValid = false;
                    }

                    line = sReader.ReadLine();

                }
                sReader.Close();
                if (flag != 1)
                {
                    MessageBox.Show("Employee ID not found, Please try again");
                    text.Clear();
                    text.Focus();
                }
            }

            return isValid;
        }
    }   
}

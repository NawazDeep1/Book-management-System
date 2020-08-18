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
 public    class EmployeeValidation
    {
        public static bool isValidID(TextBox text)
        {
            int tempID;
            if (text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid Employee ID, it must be 5 digit number", "Invalid ID");
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
                MessageBox.Show("Name is Mandatory", "Invalid Name");
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
                        MessageBox.Show("Please enter correct Name", "Invalid Name");
                        name.Clear();
                        name.Focus();
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

    }
}

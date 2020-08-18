using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.BLL;

namespace BookBiz.Validation
{
   public class ClientValidation
    {
        public static bool isValidID(TextBox text)
        {
            int tempID;
            if (text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid Client ID, 5 digit number only", "Invalid ID");
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
                MessageBox.Show("Name is Mandatory", "Invalid");
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
                        MessageBox.Show("Enter correct Name", "Invalid Name");
                        name.Clear();
                        name.Focus();
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        public static bool isValidValues(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Enter valid Data", "Invalid Data");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }
    }
}

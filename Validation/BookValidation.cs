using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBiz.BLL;
using System.Windows.Forms;

namespace BookBiz.Validation
{
   public class BookValidation
    {
        public static bool isValidisbn(TextBox text)
        {
            long tempId;
                if (text.TextLength !=13 || !(Int64.TryParse(text.Text, out tempId)))
            {
                MessageBox.Show("Please Enter ISBN again must be 10 digit", "Innvalid ISBN");
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
                MessageBox.Show("Must Enter a Title", "Title Missing");
                name.Clear();
                name.Focus();
                isValid = false;

            }
            else
            {
                for (int i = 0; i<name.TextLength; i++)
                {
                    if (char.IsDigit(name.Text, i ))
                    {
                        MessageBox.Show("Enter Correctly", "Invalid");
                        name.Clear();
                        name.Focus();
                        isValid = false;
                    }
                }
            }
            return isValid;
         }
        public static bool isValidYear(TextBox year)
        {
            if (year.TextLength != 4)
            {
                MessageBox.Show("Enter a valid year");
                year.Clear();
                year.Focus();
                return false;
            }
            else
            {
                for (int i = 0; i < year.TextLength; i++)
                {
                    if (!char.IsDigit(year.Text, i))
                    {
                        MessageBox.Show("Enter year correctly");
                        year.Clear();
                        year.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool isValidValues(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Please Enter again", "Invalid Data ");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

    }
}

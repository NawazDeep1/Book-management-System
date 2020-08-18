using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.BLL;
using System.IO;

namespace BookBiz.Validation
{
   public class OrderValidation
    {
        private static string filePathClients = Application.StartupPath + @"\Client.dat";
        private static string filePathBooks = Application.StartupPath + @"\Books.dat";

        public static bool isValidID(TextBox text)
        {
            int tempID;
            if (text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid Order ID, 5 digit number only ", "Invalid ID");
                text.Clear();
                text.Focus();
                return false;
            }
            return true;
        }

        public static bool isValidClient(TextBox text)
        {
            var flag = 0;
            var isValid = true;
            StreamReader sReader = new StreamReader(filePathClients);
            string line = sReader.ReadLine();

            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show(" Enter Client ID");
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
                    MessageBox.Show("Client ID not found,  try again");
                    text.Clear();
                    text.Focus();
                }
            }

            return isValid;
        }

        public static bool isValidBooks(TextBox text)
        {
            var flag = 0;
            var isValid = true;
            StreamReader sReader = new StreamReader(filePathBooks);
            string line = sReader.ReadLine();

            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show("Enter ISBN");
                isValid = false;
                text.Clear();
                text.Focus();
            }
            else
            {
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (text.Text == fields[0])
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
                    MessageBox.Show("Book ID not found try again");
                    text.Clear();
                    text.Focus();
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

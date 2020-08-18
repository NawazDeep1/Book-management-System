using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBiz.BLL;
using System.Windows.Forms;
using System.IO;
namespace BookBiz.DAL
{
   public class UserDA
    {
        private static string filePath = Application.StartupPath + @"\Users.dat";

        public static void Add(Users user)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(user.UserID + "," + user.Post + "," + user.EmployeeID);
            sWriter.Close();
            MessageBox.Show("User has been added to the list", "Confirmation");
        }

        public static void ListUsers(ListView listViewUsers)
        {
            StreamReader sRead = new StreamReader(filePath);
            listViewUsers.Items.Clear();

            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                listViewUsers.Items.Add(item);
                line = sRead.ReadLine();
            }
            sRead.Close();
        }

        public static Users Search(int userID)
        {
            Users user = new Users();

            StreamReader sRead = new StreamReader(filePath);
            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (userID == Convert.ToInt32(fields[0]))
                {
                    user.UserID = Convert.ToInt32(fields[0]);
                    user.Post = fields[1];
                    user.EmployeeID = Convert.ToInt32(fields[2]);
                    sRead.Close();
                    return user;
                }
                line = sRead.ReadLine();
            }
            sRead.Close();
            return null;
        }
    }
}

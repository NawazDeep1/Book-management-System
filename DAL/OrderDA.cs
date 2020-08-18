using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BookBiz.BLL;



namespace BookBiz.DAL
{
    public  class OrderDA
    {
        private static string filePath = Application.StartupPath + @"\Orders.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp-Orders.dat";

        public static void Add(Order order)
        {
            StreamWriter swrite = new StreamWriter(filePath, true);
            swrite.WriteLine(order.OrderID + "," + order.ClientID + "," + order.BookID + "," + order.Quantity);
            swrite.Close();
            MessageBox.Show("Order is on the list");
        }

        public static void ListOrders(ListView listViewOrders)
        {
            StreamReader sRead = new StreamReader(filePath);
            listViewOrders.Items.Clear();

            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                listViewOrders.Items.Add(item);
                line = sRead.ReadLine();
            }
            sRead.Close();
        }

        internal static void Add(GUI.Orders order)
        {
            throw new NotImplementedException();
        }

        public static Order Search(int orderID)
        {
            Order order = new Order();

            StreamReader sRead = new StreamReader(filePath);
            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (orderID == Convert.ToInt32(fields[0]))
                {
                    order.OrderID = Convert.ToInt32(fields[0]);
                    order.ClientID = Convert.ToInt32(fields[1]);
                    order.BookID = Convert.ToInt64(fields[2]);
                    order.Quantity = Convert.ToInt32(fields[3]);
                    sRead.Close();
                    return order;
                }
                line = sRead.ReadLine();
            }
            sRead.Close();
            return null;
        }

        public static bool Cancel(int orderID)
        {
            StreamReader sRead = new StreamReader(filePath);
            string line = sRead.ReadLine();
            int flag = 0;

            StreamWriter swrite = new StreamWriter(fileTemp, true);

            while (line != null)
            {
                string[] fields = line.Split(',');

                if ((orderID) != Convert.ToInt32(fields[0]))
                {
                    swrite.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);
                }
                else
                {
                    flag = 1;
                }
                line = sRead.ReadLine();
            }
            sRead.Close();
            swrite.Close();

            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            if (flag == 0)
            {
                MessageBox.Show("Data not found", "Error");
                return false;
            }
            else
            {
                MessageBox.Show("Data Cancelled ");
                return true;
            }

        }
    }
}

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
 public class ClientDA
    {
        private static string filePath = Application.StartupPath + @"\Clients.dat";

        public static void Add(Client client)
        {
            StreamWriter sWrite = new StreamWriter(filePath, true);
            sWrite.WriteLine(client.ClientID + "," + client.Name + "," + client.Street + "," + client.City + "," + client.PostalCode + "," + client.PhoneNumber + "," + client.FaxNumber + "," + client.CreditLimit);
            sWrite.Close();
            MessageBox.Show("Client is on the list");
        }

        public static void ListClients(ListView listViewClient)
        {
            StreamReader sRead = new StreamReader(filePath);
            listViewClient.Items.Clear();

            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                item.SubItems.Add(fields[5]);
                item.SubItems.Add(fields[6]);
                item.SubItems.Add(fields[7]);
                listViewClient.Items.Add(item);
                line = sRead.ReadLine();
            }
            sRead.Close();
        }

        public static Client Search(int clientID)
        {
            Client client = new Client();

            StreamReader sRead = new StreamReader(filePath);
            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (clientID == Convert.ToInt32(fields[0]))
                {
                    client.ClientID = Convert.ToInt32(fields[0]);
                    client.Name = fields[1];
                    client.Street = fields[2];
                    client.City = fields[3];
                    client.PostalCode = fields[4];
                    client.PhoneNumber = fields[5];
                    client.FaxNumber = fields[6];
                    client.CreditLimit = Convert.ToInt32(fields[7]);
                    sRead.Close();
                    return client;
                }
                line = sRead.ReadLine();
            }
            sRead.Close();
            return null;
        }

    }
}

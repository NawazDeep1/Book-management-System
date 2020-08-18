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
    public class BookDA
    {
        private static string filePath = Application.StartupPath + @"\Books.dat";

        public static void Add(Book book)
        {
            StreamWriter sWrite = new StreamWriter(filePath, true);
            sWrite.WriteLine(book.isbn + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QOH);
            sWrite.Close();
            MessageBox.Show("Book is in the list");

        }

        public static void ListBook(ListView listViewBook)
        {
            StreamReader sRead = new StreamReader(filePath);
            listViewBook.Items.Clear();

            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                listViewBook.Items.Add(item);
                line = sRead.ReadLine();
            }
            sRead.Close();
        }

        public static Book Search(long isbn)
        {
            Book book = new Book();

            StreamReader sRead = new StreamReader(filePath);
            string line = sRead.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (isbn == Convert.ToInt64(fields[0]))
                {
                    book.isbn = Convert.ToInt64(fields[0]);
                    book.Title = fields[1];
                    book.UnitPrice = Convert.ToInt32(fields[2]);
                    book.YearPublished = Convert.ToInt32(fields[3]);
                    book.QOH = Convert.ToInt32(fields[4]);
                    sRead.Close();
                    return book;
                }
                line = sRead.ReadLine();
            }
            sRead.Close();
            return null;
        }

    }
}

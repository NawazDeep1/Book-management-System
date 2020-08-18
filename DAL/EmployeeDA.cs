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
  public  class EmployeeDA
    {
        private static string filePath = Application.StartupPath + @"\Employees.dat";

        public static void Add(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(emp.EmployeeID + "," + emp.Name + "," + emp.PhoneNumber);
            sWriter.Close();
            MessageBox.Show("Employee has been added to the list", "Confirmation");
        }

        public static void ListEmployee(ListView listViewEmployee)
        {
            StreamReader sReader = new StreamReader(filePath);
            listViewEmployee.Items.Clear();

            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                listViewEmployee.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }

        public static Employee Search(int empID)
        {
            Employee emp = new Employee();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (empID == Convert.ToInt32(fields[0]))
                {
                    emp.EmployeeID = Convert.ToInt32(fields[0]);
                    emp.Name = fields[1];
                    emp.PhoneNumber = fields[2];
                    sReader.Close();
                    return emp;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
    }
}

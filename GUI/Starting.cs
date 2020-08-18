using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.BLL;
using BookBiz.DAL;
using BookBiz.Validation;

namespace BookBiz.GUI
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to Exit?", " Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
             Users user = new Users();
            user.ShowDialog();
            this.Close();

        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees empform = new Employees();
            empform.ShowDialog();
            this.Close();
        }

        private void buttonInventoryController_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books book = new Books();
            book.ShowDialog();
            this.Close();
        }

        private void buttonSalesManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients client = new Clients();
            client.ShowDialog();
            this.Close();
        }

        private void buttonOrderClerks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders order = new Orders();
            order.ShowDialog();
            this.Close();
        }
    }
}

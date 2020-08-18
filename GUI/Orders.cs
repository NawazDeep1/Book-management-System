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
    public partial class Orders : Form
    {
        List<Orders> listC = new List<Orders>();
        private void ClearAll()
        {
            textboxBookId.Clear();
            textboxClientId.Clear();
            textboxOrderId.Clear();
            textboxbQuantity.Clear();
        }

        public Orders()
        {
            InitializeComponent();
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            if (OrderValidation.isValidID(textboxOrderId)  && OrderValidation.isValidClient(textboxClientId) && OrderValidation.isValidBooks(textboxBookId) && OrderValidation.isValidValues(textboxbQuantity))
            {
                order.OrderID = Convert.ToInt32(textboxOrderId.Text);
                order.ClientID = Convert.ToInt32(textboxClientId.Text);
                order.BookID = Convert.ToInt64(textboxBookId.Text);
                order.Quantity = Convert.ToInt32(textboxbQuantity.Text);
                OrderDA.Add(order);
                ClearAll();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxSearch.Text))
            {
                MessageBox.Show("Enter Order ID", "Search not Possible");
            }
            else
            {
                Order order = OrderDA.Search(Convert.ToInt32(textboxSearch.Text));

                if (order != null)
                {
                    textboxOrderId.Text = order.OrderID.ToString();
                    textboxClientId.Text = order.ClientID.ToString();
                    textboxBookId.Text = order.BookID.ToString();
                    textboxbQuantity.Text = order.Quantity.ToString();
                    textboxSearch.Clear();
                }
                else
                {
                    MessageBox.Show("Order Not Found", "Search Failed");
                    textboxSearch.Clear();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Starting start = new Starting();
                start.ShowDialog();
                this.Close();
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listviewOrders.Items.Clear();
            OrderDA.ListOrders(listviewOrders);
        }
    }
}

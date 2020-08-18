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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        private void clearall()
        {
            textboxisbn.Clear();
            textboxQuantityOnHand.Clear();
            textboxUnitPrice.Clear();
            textboxTitle.Clear();
            textboxYearPublished.Clear();
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            if ((BookValidation.isValidisbn(textboxisbn)) && (BookValidation.isValidName(textboxTitle)) && (BookValidation.isValidValues(textboxUnitPrice)) && (BookValidation.isValidYear(textboxYearPublished)) && (BookValidation.isValidValues(textboxQuantityOnHand)))
            {
              
                book.isbn = Convert.ToInt32(textboxisbn.Text);
                book.Title = textboxTitle.Text;
                book.UnitPrice = Convert.ToInt32(textboxUnitPrice.Text);
                book.YearPublished = Convert.ToInt32(textboxYearPublished.Text);
                book.QOH = Convert.ToInt32(textboxQuantityOnHand.Text);
                BookDA.Add(book);
                clearall();
            }
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to Exit?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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


            listviewBook.Items.Clear();
            BookDA.ListBook(listviewBook);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxSearch.Text))
            {
                MessageBox.Show("Enter ISBN" );
            }
            else
            {
                Book book = BookDA.Search(Convert.ToInt32(textboxSearch.Text));

                if (book != null)
                {
                    textboxisbn.Text = book.isbn.ToString();
                    textboxTitle.Text = book.Title;
                    textboxUnitPrice.Text = book.UnitPrice.ToString();
                    textboxYearPublished.Text = book.YearPublished.ToString();
                    textboxYearPublished.Text = book.QOH.ToString();
                    textboxSearch.Clear();
                }
                else
                {
                    MessageBox.Show("Book Not Found", "Search Failed");
                    textboxSearch.Clear();
                   
                }
            }
        }

        private void listviewBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textboxQuantityOnHand_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxYearPublished_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxisbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using BookBiz.Validation;
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

namespace BookBiz.GUI
{
    public partial class Clients : Form
    {
        private void ClearAll()
        {
            textboxClientId.Clear();
            texbBoxClientName.Clear();
            textboxStreet.Clear();
            textboxCity.Clear();
            textboxPostalCode.Clear();
            maskedtextboxPhoneNumber.Clear();
            textboxFaxNumber.Clear();
            textboxCreditLimit.Clear();
        }
        public Clients()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxSearch.Text))
            {
                MessageBox.Show("Please enter Client ID", "Search not Possible");
            }
            else
            {
                Client client = ClientDA.Search(Convert.ToInt32(textboxSearch.Text));

                if (client != null)
                {
                    textboxClientId.Text = client.ClientID.ToString();
                    texbBoxClientName.Text = client.Name;
                    textboxStreet.Text = client.Street;
                    textboxCity.Text = client.City;
                    textboxPostalCode.Text = client.PostalCode;
                    maskedtextboxPhoneNumber.Text = client.PhoneNumber;
                    textboxFaxNumber.Text = client.FaxNumber;
                    textboxCreditLimit.Text = client.CreditLimit.ToString();
                    textboxSearch.Clear();
                }
                else
                {
                    MessageBox.Show("Client Not Found", "Failed");
                    textboxSearch.Clear();
                }
            }
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (ClientValidation.isValidID(textboxClientId) && ClientValidation.isValidName(texbBoxClientName) && ClientValidation.isValidValues(textboxStreet) && ClientValidation.isValidValues(textboxCity) && ClientValidation.isValidValues(textboxPostalCode) && ClientValidation.isValidValues(textboxFaxNumber) && ClientValidation.isValidValues(textboxCreditLimit))
            {
                client.ClientID = Convert.ToInt32(textboxClientId.Text);
                client.Name = texbBoxClientName.Text;
                client.Street = textboxStreet.Text;
                client.City = textboxCity.Text;
                client.PostalCode = textboxPostalCode.Text;
                client.PhoneNumber = maskedtextboxPhoneNumber.Text;
                client.FaxNumber = textboxFaxNumber.Text;
                client.CreditLimit = Convert.ToInt32(textboxCreditLimit.Text);
                ClientDA.Add(client);
                ClearAll();
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            ClientDA.ListClients(listViewClient);
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
    }
}

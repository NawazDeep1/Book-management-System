using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
  public class Client
    {
        public int ClientID { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string FaxNumber { get; set; }

        public int CreditLimit { get; set; }
    }
}

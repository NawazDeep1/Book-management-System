using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Book
    {
        public long isbn { get; set; }

        public string Title { get; set; }

        public decimal? UnitPrice { get; set; }

        public int YearPublished { get; set; }

        public int? QOH { get; set; }
    }
}

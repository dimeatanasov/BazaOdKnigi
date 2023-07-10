using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaOdKnigi
{
    public class RentedBook
    {
        public string userEMBG { get; set; }
        public string bookTitle { get; set; }
        public string userUsername { get; set; }

        public RentedBook()
        {
            userEMBG = string.Empty;
            bookTitle = string.Empty;
            userUsername = string.Empty;
        }
    }
}

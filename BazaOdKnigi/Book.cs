using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaOdKnigi
{
    public class Book
    {
        public string title { get; set; }
        public int numberOfBooks { get; set; }

        public Book() 
        {
            title = string.Empty;
            numberOfBooks = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaOdKnigi
{
    public class User
    {
        public string username {  get; set; }
        public string EMBG { get; set; }

        public User ()
        {
            username = string.Empty;
            EMBG = string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemka
{
    public class Kontakt
    {
        public string jmeno { get; private set; }
        public string email { get; private set; }

        public Kontakt(string jmeno, string email)
        {
            this.jmeno = jmeno;
            this.email = email;
        }

    }
}
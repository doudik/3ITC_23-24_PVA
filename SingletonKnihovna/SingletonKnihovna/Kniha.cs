using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKnihovna
{
    internal class Kniha
    {
        string nazevKnihy { get; set; }
        string autorKnihy { get; set; }

        public Kniha(string nK, string nA) { 
            nazevKnihy = nK;
            autorKnihy = nA;
        }
    }
}

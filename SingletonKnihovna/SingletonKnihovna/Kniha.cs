using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKnihovna
{
    internal class Kniha
    {
        public string nazevKnihy { get; private set; }
        public string autorKnihy { get; private set; }

        public Kniha(string nK, string nA) { 
            nazevKnihy = nK;
            autorKnihy = nA;
        }
    }
}

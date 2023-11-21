using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKnihovna
{
    internal class Knihovna
    {
        public List<Kniha> seznamKnih { get; set; }
        public string nazevKnihovny { get; set; }

        public Knihovna(string nK)
        {
            nazevKnihovny = nK;
            seznamKnih = new List<Kniha>();
        }

        public IReadOnlyList<Kniha> vratSeznamKnih() {
            return seznamKnih;
        }
    }
}

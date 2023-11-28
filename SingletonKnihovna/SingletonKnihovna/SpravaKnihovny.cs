using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonKnihovna
{
    internal class SpravaKnihovny
    {
        private static SpravaKnihovny spravce = new SpravaKnihovny("Josef");
        string name;
        public string Name { get { return name; } }
        public List<Knihovna> spravovaneKnihovny { get; private set; } = new List<Knihovna>();

        private SpravaKnihovny(string name)
        {
            this.name = name;
        }
        public static SpravaKnihovny vratSpravce() {
            return spravce;
        }

        public void PridejKnihu(Kniha kniha, Knihovna knihovna) {
            if (spravovaneKnihovny.Contains(knihovna))
            {
                knihovna.PridejKnihu(kniha);
            }
            else { 
                Console.WriteLine("Knihovna není spravována");
            }
        }
        public void OdeberKnihu(Kniha kniha, Knihovna knihovna)
        {
            if (spravovaneKnihovny.Contains(knihovna))
            {
                knihovna.OdeberKnihu(kniha);
            }
            else
            {
                Console.WriteLine("Knihovna není spravována");
            }
        }

    }
}

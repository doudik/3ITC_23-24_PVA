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
        static string name { get { return name; } set { name = value; } }
        List<Knihovna> spravovaneKnihovny = new List<Knihovna>();

        private SpravaKnihovny(string name)
        {
            SpravaKnihovny.name = name;
        }
        public static SpravaKnihovny vratSpravce() {
            return spravce;
        }
        void SpravujNovouKnihovnu()
        public void PridejKnihu(Kniha kniha) { 
            
        }

    }
}

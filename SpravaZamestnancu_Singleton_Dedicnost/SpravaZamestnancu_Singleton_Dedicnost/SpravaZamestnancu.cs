using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal sealed class SpravaZamestnancu
    {
        static SpravaZamestnancu instance = new SpravaZamestnancu();
        public static SpravaZamestnancu spravaZamestnancu {
            get { return instance; }
        }
        public List<Zamestnanec> seznamZamestnancu { get; private set; } = new List<Zamestnanec>();

        private SpravaZamestnancu() { }

        public void PridatZamestnance(Zamestnanec zamestnanec)
        {
            seznamZamestnancu.Add(zamestnanec);
        }   
        public void OdeberZamestnance(Zamestnanec zamestnanec)
        {
            seznamZamestnancu.Remove(zamestnanec);
        }
        public void VypisZamestnancu() {
            Console.WriteLine("Výpis zaměstnanců:\n");
            foreach (var item in seznamZamestnancu)
            {
                Console.WriteLine($"Jméno {item.jmeno} příjmení {item.prijmeni} uid {item.uid}");
            }
        }
    }
}

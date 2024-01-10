using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Osoba
    {
        public string jmeno { get; protected set; }
        public string prijmeni { get; protected set; }
        public int vek { get; protected set; }

        public Osoba(string jmeno, string prijmeni, int vek) { 
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
        }

        public virtual void VypisInformace() {
            Console.WriteLine($"Jméno {jmeno} příjmení {prijmeni} věk {vek}");
        }
    }
}

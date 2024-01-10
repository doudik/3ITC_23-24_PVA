using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Zamestnanec : Osoba
    {
        public string uid { get; private set; } = "zam_";
        Random rnd = new Random();

        public Zamestnanec(string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
        {
            GeneratorUID();
        }
        void GeneratorUID()
        {
            for (int i = 0; i < 10; i++)
            {
                uid += rnd.Next(0, 9).ToString();
            }
        }
        public override void VypisInformace()
        {
            Console.WriteLine($"Jméno {jmeno} příjmení {prijmeni} věk {vek} uid {uid}");
        }
    }
}

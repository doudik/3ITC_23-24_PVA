using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Manazer : Osoba
    {
        public string uid { get; private set; } = "man_";
        Random rnd = new Random();
        List<Zamestnanec> podrizeni;

        public Manazer(string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
        {
            podrizeni = new List<Zamestnanec>();
            GeneratorUID();
        }
        void GeneratorUID() {
            for (int i = 0; i < 10; i++)
            {
                uid += rnd.Next(0, 9).ToString();
            }
        }
        public override void VypisInformace()
        {
            base.VypisInformace();
            Console.Write($" s uid: {uid}\n");
            Console.WriteLine("Podřízení:");
            foreach (var item in podrizeni)
            {
                Console.WriteLine($"Podřízený {item.jmeno} {item.prijmeni} s uid {item.uid}");
            }
        }
        public void PridatPodrizeny(Zamestnanec zamestnanec)
        {
            podrizeni.Add(zamestnanec);
        }
    }
}

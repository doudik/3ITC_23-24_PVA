using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatGenerator
{
    internal class Umelec : IUmelec
    {
        public string jmeno { get; private set; }
        public Zanr zanr { get; private set; }
        public BarvaKuze barvaKuze { get; private set; }
        public float tvrdost;

        Random rnd = new Random();

        public Umelec(string jmeno)
        {
            this.jmeno = jmeno;
            barvaKuze = vratBarvuKuze();
            zanr = vratZanr();
            tvrdost = getTvrdost();
        }
        float getTvrdost() { 
            switch(barvaKuze)
            {
                case BarvaKuze.BILA:
                    return 0.4f;
                case BarvaKuze.CERNA:
                    return 0.8f;
                case BarvaKuze.INDIAN:
                    return 0.3f;
                case BarvaKuze.ZLUTA:
                    return 0.1f;
                case BarvaKuze.MODRA:
                    return 0.5f;
                default:
                    return 0.0f;
            }
        }

        public BarvaKuze vratBarvuKuze()
        {
            return Enum.GetValues(typeof(BarvaKuze)).Cast<BarvaKuze>().ElementAt(rnd.Next(0, Enum.GetValues(typeof(BarvaKuze)).Length));
        }
        public Zanr vratZanr()
        {
            return Enum.GetValues(typeof(Zanr)).Cast<Zanr>().ElementAt(rnd.Next(0, Enum.GetValues(typeof(Zanr)).Length));
        }
        public void Info() {
            Console.WriteLine($"Clovek {jmeno} pleti {barvaKuze} a žánrem {zanr}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_Reflexe
{
    internal class Tvar
    {
        public int sirka { get; protected set; }
        public int vyska { get; protected set; }
        public int x { get; protected set; }
        public int y { get; protected set; }
        public Color barvicka { get; protected set; }

        public Tvar(int sirka, int vyska, int x, int y, Color barvicka)
        {
            this.sirka = sirka;
            this.vyska = vyska;
            this.x = x;
            this.y = y;
            this.barvicka = barvicka;
        }
        
    }
}

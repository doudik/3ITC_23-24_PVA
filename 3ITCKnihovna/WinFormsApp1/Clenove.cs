using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Clenove
    {
        public string Jmeno { get; set; }
        public int ClenskyKod { get; set; }

        public Clenove(string jmeno, int clenskyKod)
        {
            Jmeno = jmeno;
            ClenskyKod = clenskyKod;
        }

        public void PridatClena()
        {
            // TODO přidání člena
        }
        public void OdstranitClena()
        {
            // TODO odstranění člena
        }

    }
}

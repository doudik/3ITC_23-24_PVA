using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Knihy
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int PocetKopii { get; set; }

        public Knihy(string nazev, string autor, string isbn, int pocetKopii)
        {
            Nazev = nazev;
            Autor = autor;
            ISBN = isbn;
            PocetKopii = pocetKopii;
        }

        public void PridatKnihu()
        {
            // TODO přidání knihy
        }

        public void OdstranitKnihu()
        {
            // TODO odstranění knihy
        }
        public void VypujcitKnihu()
        {
            if (PocetKopii > 0)
            {
                PocetKopii--;
                // TODO vypůjčení knihy
            }
            else
            {
                Console.WriteLine("Všechny kopie knihy jsou vypůjčeny");
            }
        }
        public void VratitKnihu()
        {
            PocetKopii++;
            // TODO vrácení knihy
        }
    }
}

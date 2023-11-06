using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Vypujcky
    {
        public Clenove ClenKnihovny { get; set; }
        public Knihy Kniha { get; set; }
        public DateTime DatumVypucky { get; set; }
        public DateTime DatumVraceni { get; set; }

        public Vypujcky(Clenove clen, Knihy kniha, DateTime datumVypujcky, DateTime datumVraceni)
        {
            ClenKnihovny = clen;
            Kniha = kniha;
            DatumVypucky = datumVypujcky;
            DatumVraceni = datumVraceni;
        }

        public void VytvoritVypujcku()
        {
            Kniha.VypujcitKnihu();
            // TODO vytvoření výpůjčky
        }

        public void UkoncitVypujcku()
        {
            Kniha.VratitKnihu();
            // TODO ukončení výpůjčky
        }
    }
}

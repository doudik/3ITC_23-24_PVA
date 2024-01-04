using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatGenerator
{
    internal class Slovo
    {
        public string slovo { get; private set; }
        public int vaha { get; private set; }
        Random rnd = new Random();

        public Slovo(string slovo)
        {
            this.slovo = slovo;
            vaha = rnd.Next();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka_Reflexe
{
    internal class Kalkulacka
    {
        public int Secti(int a, int b)
        {
            return a + b;
        }

        public int Odecitani(int a, int b)
        {
            return a - b;
        }

        public int Nasobeni(int a, int b)
        {
            return a * b;
        }

        public int Deleni(int a, int b)
        {
            return a / b;
        }

        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }
    }
}

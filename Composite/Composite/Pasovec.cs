using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Pasovec : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("žer hlínu");
        }
    }
}

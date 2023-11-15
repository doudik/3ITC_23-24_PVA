using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class AnimalGang : IAnimal
    {
        public List<IAnimal> animals = new List<IAnimal>();

        public void MakeSound()
        {
            foreach (var item in animals)
            {
                item.MakeSound();
            }
        }
    }
}

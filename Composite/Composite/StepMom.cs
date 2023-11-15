using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class StepMom : IAnimal
    {
        public float vek { get; private set; } = 30.0f;

        public StepMom(float vek)
        {
            this.vek = vek;
        }   
        public void MakeSound()
        {
            Console.WriteLine("I am S T U C K, help me stepson..");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_v2._0
{
    internal class Device : IObserver
    {
        public int Temp { get; private set; }

        public Device() { }

        public void Update(int temp)
        {
            Temp = temp;
            Console.WriteLine($"Device: {Temp}°C");
        }
    }
}

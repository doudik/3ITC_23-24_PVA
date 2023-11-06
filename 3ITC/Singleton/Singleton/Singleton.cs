using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class Singleton
    {
        static Singleton singleton = new Singleton();

        private Singleton() { }

        public static Singleton returnSingleton() {
            if (singleton != null)
            {
                return singleton;
            }
            else {
                singleton = new Singleton();
                return singleton;
            }
        }

    }
}

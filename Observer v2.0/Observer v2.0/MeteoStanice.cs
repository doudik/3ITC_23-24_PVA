using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_v2._0
{
    sealed class MeteoStanice
    {
        List<IObserver> observers = new List<IObserver>();
        public int Temp { get; private set; }

        private MeteoStanice() { }
        public void Registruj(IObserver observer) {
            observers.Add(observer);
        }
        public void Odregistruj(IObserver observer) { 
            observers.Remove(observer);
        }
        public void Notifikuj(int temp) {
            Temp = temp;

            foreach (var item in observers)
            {
                item.Update(Temp);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_v2._0
{
    internal interface IObserver
    {
        void Update(int temp);
    }
}

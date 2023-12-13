using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp___Composite
{
    internal interface IAccessable
    {
        void Add(IAccessable accessable);
        void Remove(IAccessable accesable);
        void ExtractAllInformationToConsole();
    }
}

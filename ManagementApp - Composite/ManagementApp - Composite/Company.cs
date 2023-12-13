using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp___Composite
{
    internal class Company : IAccessable
    {
        public string companyName { get; private set; }
        public List<IAccessable> departments = new List<IAccessable>();

        public Company(string name) {
            companyName = name;
        }

        public void Add(IAccessable accessable)
        {
            departments.Add(accessable);
        }

        public void Remove(IAccessable accesable)
        {
            departments.Remove(accesable);
        }

        public void ExtractAllInformationToConsole()
        {
            Console.WriteLine($"Company {this.companyName} has departments:");
            foreach (Departments item in departments)
            {
                item.ExtractAllInformationToConsole();
            }
            Console.WriteLine();
        }
    }
}

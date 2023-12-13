using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp___Composite
{
    internal class Departments : IAccessable
    {
        public string departmentName { get; private set; }
        public List<IAccessable> employees = new List<IAccessable>();

        public Departments(string name)
        {
            departmentName = name;
        }

        public void Add(IAccessable accessable)
        {
            employees.Add(accessable);
        }

        public void ExtractAllInformationToConsole()
        {
            Console.WriteLine($"Department {this.departmentName} obtains employees:");
            foreach (Employee item in employees)
            {
                item.ExtractAllInformationToConsole();
            }
            Console.WriteLine();
        }

        public void Remove(IAccessable accesable)
        {
            employees.Remove(accesable);
        }
    }
}

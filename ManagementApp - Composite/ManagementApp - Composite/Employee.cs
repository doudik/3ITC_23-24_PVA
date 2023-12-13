using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp___Composite
{
    internal class Employee : IAccessable{ 
        

        public string name { get; private set; }
        public string surname { get; private set; }
        public Departments department { get; private set; }
        public float salary { get; private set; }
        Random rnd = new Random();

        public Employee(string name, string surname, Departments department)
        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            this.salary = rnd.Next(0, 2000000);
        }

        public void Add(IAccessable accessable)
        {
            throw new NotImplementedException();
        }

        public void Remove(IAccessable accesable)
        {
            throw new NotImplementedException();
        }

        public void ExtractAllInformationToConsole()
        {
            Console.WriteLine($"{this.name} {this.surname} in department {this.department.departmentName} working for {this.salary}$");
        }
    }
}

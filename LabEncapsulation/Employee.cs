using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEncapsulation
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Salary:{Salary}");
        }
    }
}

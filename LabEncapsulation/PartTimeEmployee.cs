using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEncapsulation
{
    internal class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public PartTimeEmployee(int id, string name, int salary, int hoursWorked) : base(id, name, salary)
        {
            HoursWorked = hoursWorked;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Salary:{Salary} Hours Worked:{HoursWorked}");
        }
    }
}

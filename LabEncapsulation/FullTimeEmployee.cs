using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEncapsulation
{
    internal class FullTimeEmployee : Employee
    {
        public int VacationDays { get; set; }
        public FullTimeEmployee(int id, string name, int salary, int vacationDays) : base(id, name, salary)
        {
            VacationDays = vacationDays;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Salary:{Salary} Vacation days:{VacationDays}");
        }
    }
}

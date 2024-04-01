namespace LabEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new(1, "Punhan", 1000, 2);
            PartTimeEmployee partTimeEmployee = new(2, "Aygun", 500, 6);
            Employee[] Employees = new Employee[] { fullTimeEmployee, partTimeEmployee };
            foreach (Employee employee in Employees)
            {
                employee.DisplayInfo();
            }

        }
    }
}
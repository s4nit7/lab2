using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Employee
{
    class Program2
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Mar", "James");
            employee.CalculateSalaryAndTax(Position.designer, 8);
            employee.PrintSalaryWithTax();
            Console.Write(employee);
        }
    }
}

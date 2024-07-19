using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    internal class Program
    {

        public const double BASIC_SALARY = 15000;
        public const double HRMS = 0.4;
        public const double ALLOWANCES = 0.5;

        static void Main(string[] args)
        {
            double basicSalary = BASIC_SALARY;

            SalaryCalculation();
            
        }

        public static void SalaryCalculation()
        {
            double salary = BASIC_SALARY + (BASIC_SALARY * HRMS) + (BASIC_SALARY * ALLOWANCES);

            Console.WriteLine("Total Salary is: " + salary);
        }

    }
}

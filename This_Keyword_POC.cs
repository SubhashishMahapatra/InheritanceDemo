using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywordPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Subhashish");
            Employee employee1 = new Employee(2, "Basudev", 20);

            employee.PrintDetails();
            employee1.PrintDetails();

        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }

        public string EmployeeCompany {  get; set; }

        public int EmployeeConst;



        public Employee(int employeeId, string employeeName) 
        {

            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }

        public Employee(int employeeId, string employeeName, int employeeAge) : this(employeeId, employeeName) 
        {
            EmployeeAge = employeeAge;
          
        }

        public void PrintDetails()
        {
            Console.WriteLine("Employee Id: " + EmployeeId);
            Console.WriteLine("Employee Name: "+ EmployeeName);
            Console.WriteLine("Emplyee Age: "+ EmployeeAge);
            Console.WriteLine();
        }

    }
}

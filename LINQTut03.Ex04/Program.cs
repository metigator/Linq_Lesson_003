using LINQTut03.Shared;
using System;
using System.Linq;

namespace LINQTut03.Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var empMale = employees.Where(x => x.Gender == "male");

            var empsSalaryOver300K = employees.Where(x => x.Salary >= 300_000);

            empMale.Print("Male Employees");
            
            empsSalaryOver300K.Print("Employees with Salary >= 300K");

            var empMaleInHRDepartment = 
                empMale.Where(x => x.Department.ToLowerInvariant() == "hr");
            empMaleInHRDepartment.Print("Male Employees In HR");

            Console.ReadKey();
        }
    }
}

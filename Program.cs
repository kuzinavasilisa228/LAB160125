using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB160125
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FullName = "Иванов";
            employee.Salary = 63500;
            PrintEmployeeInfo(employee);
            double annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine("Годовая зарплата: " + annualSalary);
            Console.ReadKey();
        }
        static void PrintEmployeeInfo(Employee emp)
        {
            Console.WriteLine("Информация о сотруднике:");
            emp.Show();
        }
    }
}
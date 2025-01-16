using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB160125
{
    class Employee
    {
        public string FullName { get; set; }
        public double Salary { get; set; }
        public void Show()
        {
            Console.WriteLine("ФИО: " + FullName);
            Console.WriteLine("Зарплата: " + Salary);
        }
        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}

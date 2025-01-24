using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    internal class emp_sal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hourly rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter deductions: ");
            double deductions = Convert.ToDouble(Console.ReadLine());

            double salary = (hoursWorked * hourlyRate) - deductions;
            Console.WriteLine("Monthly Salary: " + salary);
            Console.WriteLine("Srivaths Iyer");
        }
    }
}

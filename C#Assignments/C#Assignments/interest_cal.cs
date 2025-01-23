using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    internal class interest_cal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter target balance: ");
            double target = Convert.ToDouble(Console.ReadLine());

            while (principal < target)
            {
                principal += principal * rate / 100;
            }

            Console.WriteLine("Final Balance: " + principal);
            Console.WriteLine("Srivaths Iyer");
        }
    }
}

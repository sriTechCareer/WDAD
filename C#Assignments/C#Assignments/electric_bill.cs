using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    internal class electric_bill
    {
        static void Main(string[] args)
        {
            Console.Write("Enter consumption in units: ");
            int units = Convert.ToInt32(Console.ReadLine());
            double bill;

            if (units <= 100)
            {
                bill = units * 1.5;
            }
            else if (units <= 200)
            {
                bill = 100 * 1.5 + (units - 100) * 2;
            }
            else
            {
                bill = 100 * 1.5 + 100 * 2 + (units - 200) * 3;
            }

            Console.WriteLine("Electricity Bill: " + bill);
            Console.WriteLine("Srivaths Iyer");
        }
    }
}

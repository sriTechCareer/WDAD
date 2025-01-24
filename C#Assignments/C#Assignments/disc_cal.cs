using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    internal class disc_cal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the original price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the discount percentage: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            double finalPrice = price - (price * discount / 100);
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine("Srivaths Iyer");
        }
    }
}

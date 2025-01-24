using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practical2
{
    internal class calci
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                int num1, num2;
                Console.WriteLine("Enter two numbers");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Console.WriteLine("Addition is: "+(num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction is: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication is: " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division is: " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                }
            }
            while (choice!=5);
        }
    }
}

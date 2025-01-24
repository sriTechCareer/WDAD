using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practical2
{
    internal class for_while
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i+" ");
            }
            int j = 1;
            Console.WriteLine();
            while (j<=100)
            {
                Console.Write(j + " ");
                j++;
            }
        }
    }
}

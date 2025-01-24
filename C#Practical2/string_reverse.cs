using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practical2
{
    internal class string_reverse
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            StringBuilder sb = new StringBuilder(val);  
            for (int i = 0; i < val.Length / 2; i++)
            {
                char temp = sb[i];
                sb[i] = sb[val.Length - i - 1];
                sb[val.Length - i - 1] = temp;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

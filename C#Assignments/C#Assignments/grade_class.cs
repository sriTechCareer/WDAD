using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    internal class grade_class
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade = marks >= 90 ? "A" : marks >= 75 ? "B" : marks >= 50 ? "C" : "D";
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Srivaths Iyer");
        }
    }
}

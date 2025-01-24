using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    class Student
    {
        public string Name;
        public int Marks;
        public string Grade;
    }
    internal class stud_management
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                Console.Write("Enter name: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Enter marks: ");
                students[i].Marks = Convert.ToInt32(Console.ReadLine());
                students[i].Grade = students[i].Marks >= 90 ? "A" : students[i].Marks >= 75 ? "B" : students[i].Marks >= 50 ? "C" : "D";
            }

            foreach (var student in students)
                Console.WriteLine(student.Name + " - " + student.Marks + " - " + student.Grade);

            Console.WriteLine("Srivaths Iyer");
        }
    }
}

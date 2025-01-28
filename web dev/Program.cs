using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    class Library
    {
        private string[] books = { "Book1", "Book2", "Book3" };
        private bool[] isIssued = { false, false, false };

        public void BorrowBook()
        {
            Console.WriteLine("Available Books:");
            for (int i = 0; i < books.Length; i++)
            {
                if (!isIssued[i])
                    Console.WriteLine((i + 1) + ". " + books[i]);
            }

            Console.Write("Enter the book number to borrow: ");
            int bookNumber = Convert.ToInt32(Console.ReadLine());
            if (bookNumber > 0 && bookNumber <= books.Length && !isIssued[bookNumber - 1])
            {
                isIssued[bookNumber - 1] = true;
                Console.WriteLine($"You borrowed {books[bookNumber - 1]}.");
            }
            else
            {
                Console.WriteLine("Invalid selection or book already issued.");
            }
        }

        public void ReturnBook()
        {
            Console.WriteLine("Issued Books:");
            for (int i = 0; i < books.Length; i++)
            {
                if (isIssued[i])
                    Console.WriteLine((i + 1) + ". " + books[i]);
            }

            Console.Write("Enter the book number to return: ");
            int bookNumber = Convert.ToInt32(Console.ReadLine());
            if (bookNumber > 0 && bookNumber <= books.Length && isIssued[bookNumber - 1])
            {
                isIssued[bookNumber - 1] = false;
                Console.WriteLine($"You returned {books[bookNumber - 1]}.");
            }
            else
            {
                Console.WriteLine("Invalid selection or book was not issued.");
            }
        }
    }
    internal class lib
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.Write("Enter 1 to borrow or 2 to return: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                library.BorrowBook();
            else if (choice == 2)
                library.ReturnBook();
            else
                Console.WriteLine("Invalid choice.");

            Console.WriteLine("Abhishek Sengar");
        }
    }
}


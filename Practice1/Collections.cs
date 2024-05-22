using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Collections
    {
        public static void Main(string[] args)
        {
            //Part 1
            List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original List");
            foreach (int integer in integers)
            {
                Console.Write(integer + " ");
            }

            integers.RemoveAt(0);
            integers.RemoveAt(8);

            Console.WriteLine("\n\nModified List");
            foreach (int integer in integers)
            {
                Console.Write(integer + " ");
            }
            Console.WriteLine();

            //Part 2
            Dictionary<string, int> students = new Dictionary<string, int> { };
            students.Add("Alice", 50);
            students.Add("Charlie", 60);
            students.Add("David", 70);
            students.Add("Jhon", 80);
            students.Add("Milton", 90);

            Console.WriteLine("\nOriginal Dictionary");
            foreach (var student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }

            students["Milton"] = 100;
            students.Remove("Alice");

            Console.WriteLine("\nModified Dictionary");
            foreach (var student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }

            //Part 3
            Queue<string> customers = new Queue<string> { };
            customers.Enqueue("Pedro");
            customers.Enqueue("Juan");
            customers.Enqueue("Luis");
            customers.Enqueue("Sancho");
            customers.Enqueue("Mateo");

            Console.WriteLine("\nOriginal Queue");
            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            customers.Dequeue();
            customers.Dequeue();

            Console.WriteLine("\nModified Queue");
            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            //Part 4
            Stack<string> books = new Stack<string> { };
            books.Push("Book 1");
            books.Push("Book 2");
            books.Push("Book 3");
            books.Push("Book 4");
            books.Push("Book 5");

            Console.WriteLine("\nOriginal Stack");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            books.Pop();
            books.Pop();

            Console.WriteLine("\nModified Stack");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}

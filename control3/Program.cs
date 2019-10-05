using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control3
{
    class Book
    {
        public string Name;
        public int Year;
        public string Author;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book(){ Name = "LINQ",Year = 1456,Author = "Petr"},
                new Book(){ Name = "Prosto LINQ",Year = 4567,Author = "Petr"},
                new Book(){ Name = "Ne Prosto LINQ",Year = 8546,Author = "Petr"},
                new Book(){ Name = "Alesso",Year = 1234,Author = "Valera"},
                new Book(){ Name = "Petr",Year = 1996,Author = "Valera"},
                new Book(){ Name = "LINQ",Year = 2019,Author = "Jack"},
                new Book(){ Name = "Init",Year = 4765,Author = "Jack"},
            };

            int[] array = { 34, 37, 21, 29, 78, 76 };

            // 1)
            Console.WriteLine(string.Join(" ", books.Where(w=> w.Name.Contains("LINQ") && DateTime.IsLeapYear(w.Year)).Select(s=>s.Name)));

            //2)
            Console.WriteLine(string.Join(" ",books.Select(s=>s.Name).SelectMany(ss=>ss).Where(w=> w != ' ').Distinct()));

            //3)
            Console.WriteLine(string.Join(" ", array.OrderBy(o=>o / 10).ThenByDescending(o=>o % 10)));

            //4)
            Console.WriteLine(string.Join(" ", books.GroupBy(g => g.Author).Select(s=>$"\n{s.Key} :   {s.Count()} books")));
           Console.ReadKey();
        }
    }
}

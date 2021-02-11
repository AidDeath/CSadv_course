using System;
using System.Configuration;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            BookContext bookContext = new BookContext();
            bookContext.Books.AddRange(BookRepository.GetBooks());

            Console.WriteLine($"{bookContext.SaveChanges()} entities written to db");
        }
    }
}

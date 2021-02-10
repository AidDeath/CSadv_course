using System;
using System.Configuration;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var a = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            BookContext bookContext = new BookContext();
            foreach (var book in BookRepository.GetBooks())
            {
                bookContext.Books.Add(book);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Models;

namespace EntityFramework
{
    static class BookRepository
    {
        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book(){ Author_primary = "Стивен Клири", Name = "Конкурентность в C#", Publisher = "O'REILLY" , DateOut = new DateTime(2020,04,1)});
            books.Add(new Book(){ Author_primary = "Адам Фримен", Name = "ASP.NET Core MVC 2", Publisher = "apress" , DateOut = new DateTime(2017,10,24)});
            books.Add(new Book(){ Author_primary = "Сергей Тепляков", Name = "Паттерны проектирования на платформе .NET", Publisher = "ПИТЕР" , DateOut = new DateTime(2015,08,01)});
            books.Add(new Book(){ Author_primary = "Benjamin Smith", Name = "Advanced guide to learn C#", Publisher = "" , DateOut = new DateTime(2020,01,01)});
            return books; 
        }
    }
}

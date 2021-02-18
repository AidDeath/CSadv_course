using Microsoft.EntityFrameworkCore;
using System;

namespace EF_Indicies_FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new CharactersDbContext();
            var characters = dbContext.Characters.Include(x => x.Story).Include(s => s.Story.Author);

            foreach (var c in characters)
                Console.WriteLine($"FirstName: {c.FirstName}  \tLastName: {c.LastName}  " +
                                  $"\tStory: {c.Story.Name}  \tBy: {c.Story.Author.AuthorName} {c.Story.Author.AuthorSurname}");

            Console.Read();
        }
    }
}

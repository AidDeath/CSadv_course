using EF_Indicies_FluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EF_Indicies_FluentAPI
{
    public class CharactersDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CharactersConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 1, Name = "Foundation", Description = "",AuthorId = 1},
                new Story { Id = 2, Name = "LOTR", Description = "", AuthorId = 2},
                new Story { Id = 3, Name = "Hyperion", Description = "", AuthorId = 3});

            // Homework 9 task 2
            modelBuilder.Entity<Character>().Property(character => character.FirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Character>().Property(character => character.LastName).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Character>().HasData(
                new Character() { Id = 1, FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35, StoryId = 1 },
                new Character() { Id = 2, FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700, StoryId = 2},
                new Character() { Id = 3, FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14, StoryId = 3});

            modelBuilder.Entity<Author>().HasData(
                new Author{AuthorId = 1, AuthorName = "Isaak", AuthorSurname = "Azimov"},
                new Author{AuthorId = 2, AuthorName = "Johr Ronald Ruel",AuthorSurname = "Talkien"},
                new Author{AuthorId = 3, AuthorName = "Dan",AuthorSurname = "Simmons"});
        }
    }
}
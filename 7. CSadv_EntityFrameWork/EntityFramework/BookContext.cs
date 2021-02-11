using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            // При работе программы тут строка, при выполнении Add-Migration - null

            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
            //optionsBuilder.UseSqlServer("Server=localhost\\sql;Database=Books;Integrated Security=True");
        }
    }
}

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
            // optionsBuilder.UseSqlServer("Data Source=localhost\\sql;Initial Catalog=Characters;Integrated Security=True");
            // optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["connStr"]);

        }
    }
}

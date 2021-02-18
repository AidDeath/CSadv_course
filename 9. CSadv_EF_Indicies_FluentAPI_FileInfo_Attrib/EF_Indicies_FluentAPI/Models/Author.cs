using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Indicies_FluentAPI.Models
{
    // Homework 9 task 1
    [Index(nameof(AuthorName), nameof(AuthorSurname), IsUnique = true)]
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string  AuthorSurname{ get; set; }
        public List<Story> Stories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace EntityFramework.Models
{
    class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author_primary { get; set; }
        public string Authors_other { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOut { get; set; }
    }
}


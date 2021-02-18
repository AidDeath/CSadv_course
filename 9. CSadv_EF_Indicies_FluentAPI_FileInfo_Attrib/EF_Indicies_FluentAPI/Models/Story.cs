﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Indicies_FluentAPI.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Character> Characters { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
using System;
using CSadv_collections.Interfaces;

namespace CSadv_collections.Classes
{
    class RealPerson : IPerson
    {
        public RealPerson(string name, string surname, int age)
        {
            Name = name;
            Surname = surname; 
            Age = age;
        }
  
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public override string ToString()
        {
           return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}

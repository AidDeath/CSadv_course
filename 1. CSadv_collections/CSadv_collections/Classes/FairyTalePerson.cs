using System;
using System.Collections.Generic;
using System.Text;
using CSadv_collections.Interfaces;

namespace CSadv_collections.Classes
{
    class FairyTalePerson :IPerson
    {
        public FairyTalePerson(string name, string fairyTale, int age)
        {
            Name = name;
            FairyTale = fairyTale;
            Age = age;
        }
        public string Name { get; }

        public string FairyTale { get; }
        public int Age { get; }

        public override string ToString()
        {
            return $"Name: {Name}, FairyTale: {FairyTale}, Age: {Age}";
        }
    }
}

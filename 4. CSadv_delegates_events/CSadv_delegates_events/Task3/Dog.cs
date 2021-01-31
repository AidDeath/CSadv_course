using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Dog
    {
        public Dog()
        {
            Cat.GetInstance().CatSaysMeow += () => Console.WriteLine("Dog says: Woof - woof!");
        }
    }
}

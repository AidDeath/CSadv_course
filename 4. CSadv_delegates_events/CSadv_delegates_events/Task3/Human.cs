using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Human
    {
        public Human()
        {
            Cat.GetInstance().CatSaysMeow += () => Console.WriteLine("Human comes closer to pet the kitty.");
        }
    }
}

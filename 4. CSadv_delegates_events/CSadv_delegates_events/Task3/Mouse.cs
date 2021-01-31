using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Mouse
    {
        public Mouse()
        {
            Cat.GetInstance().CatSaysMeow += () => Console.WriteLine("Mouse run away from the sound.");
        }
    }
}

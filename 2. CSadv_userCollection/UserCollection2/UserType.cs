using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection2
{
    class UserType
    {
        public int Var { get;}
        private readonly Random rand = new Random();
        public UserType()
        {
            Var = rand.Next(1000);
        }
    }
}

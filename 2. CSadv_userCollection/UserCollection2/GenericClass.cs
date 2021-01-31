using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection2
{
    class GenericClass<T, TR> where T : struct where TR : UserType, new()
    {
        public T Variable { get; set; }

        public TR GenericClassMethod()
        { 
            return new TR();
        }
    }
}

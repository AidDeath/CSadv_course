using System;
using System.Collections.Generic;
using System.Text;

namespace SCadv_callback
{
    class First
    {
        public void FirstMethod(Func<bool> SecondMethod)
        {
            Console.WriteLine((SecondMethod.Invoke()) ? "Mission Complete" : "Mission Failed!"); 
        }
    }
}

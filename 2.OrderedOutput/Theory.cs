using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.OrderedOutput
{
    public static class Theory
    {
       private static Thread threadOne = new Thread(Speak.SayOne);
       private static Thread threadTwo = new Thread(Speak.SayTwo);
       private static Thread threadThree = new Thread(Speak.SayThree);
        
        public static void One()
        {
            Task Task = Task.Run(Speak.SayOne);
        }
      }
}

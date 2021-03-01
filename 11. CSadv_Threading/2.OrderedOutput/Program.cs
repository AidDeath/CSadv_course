using System;
using System.Threading;
using System.Threading.Tasks;

namespace _2.OrderedOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(Theory.One);
            Task.Run(Theory.Three);
            Task.Run(Theory.Two);
            
            //Текст, выводящийся в консоль - One Two Three

        }
    }
}

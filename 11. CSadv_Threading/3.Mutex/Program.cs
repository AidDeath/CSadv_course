using System;
using System.Net.Mime;

namespace _3.Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            new System.Threading.Mutex(true,"MyMutex", out var firstExemplar);
            if (!firstExemplar)
            {
                Console.WriteLine("Another copy is working");
                Console.ReadKey();
                return;
            }
                
            Console.WriteLine("Started...");
            Console.ReadKey();
        }
    }
}

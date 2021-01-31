using System;

namespace UserCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new GenericClass<double, UserType>();
            Console.WriteLine(example.Variable = example.GenericClassMethod().Var);
        }
    }
}

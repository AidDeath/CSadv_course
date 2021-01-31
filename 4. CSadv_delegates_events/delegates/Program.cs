using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate deleg = sum;
            deleg += multiply;
            ForDelegate nonStatic = new ForDelegate();
            deleg += nonStatic.Divide;

            //deleg.Invoke(12,20);
            deleg(11, 12);

        }       

        delegate void MyDelegate(int a, int b);

        static void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }

    class ForDelegate
    {
        private int a = 100;
        private int b = 50;

        public void Divide(int a, int b)
        {
            Console.WriteLine(this.a / this.b);
        }
    }
}

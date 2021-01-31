using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {

            Publisher publisher = new Publisher();

            publisher.MyEvent += PublisherOnMyEvent;

            publisher.PublisherMethod();

            // publisher.MyEvent += () => Console.WriteLine("fdsf");
        }

        private static void PublisherOnMyEvent()
        {
            Console.WriteLine("Hello!");
        }
    }


    delegate void MyDelegate();
    class Publisher
    {
        public event MyDelegate MyEvent;

        public void PublisherMethod()
        {
            MyEvent?.Invoke();
        }
    }
}

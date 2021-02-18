using System;
using System.Linq;
using System.Reflection;


namespace Attribute_hw9
{ 
    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        [MyOwn("This is private method", LegalAge = 18)]
        [Obsolete("Этот метод не несет в себе никакой полезной логики. Использовал его для экспериментов")]
        private bool ShowMethodsPrivate()
        {
            foreach (var meth in this.GetType().GetMethods().Where(m => m.CustomAttributes.Any()))
            {
                Console.WriteLine(meth);
            };
            return true;
        }

        [MyOwn("This is public method")]
        [Obsolete("Этот метод не несет в себе никакой полезной логики. Использовал его для экспериментов")]
        public void ShowMethodsPublic()
        { // Эти методы не вызываются, использовал для экспериментов
            foreach (var meth in this.GetType().GetMethods().Where(m => m.CustomAttributes.Any()))
                Console.WriteLine(meth);

            Console.WriteLine("~~~~~~~~~~~~~~");
            ShowMethodsPrivate();
        }

    }
}

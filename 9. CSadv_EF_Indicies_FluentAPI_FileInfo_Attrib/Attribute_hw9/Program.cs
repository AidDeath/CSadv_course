using System;
using System.Linq;
using System.Reflection;

namespace Attribute_hw9
{
    //Создайте свой атрибут с одним позиционным и одним именованым параметром.
    //Сделайте так, чтоб этот атрибут можно было бы навешивать только на методы.
    //Создайте класс в нем создайте два метода, один приватный, второй публичный.
    //Навесьте на эти методы свои атрибуты. 
    //С помощью рефлексии выберите только созданные вами методы, выведите аттрибуты навешенные на эти методы.
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person {Age = 70, FirstName = "Bill", LastName = "Murray"};
            var methodsFromObj = person.GetType().GetMethods().Where(m => m.CustomAttributes.Any());

             var methodsFromType =  typeof(Person).GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                 .Where(m => m.CustomAttributes
                     .Where(a => a.AttributeType == typeof(MyOwnAttribute))
                     .Any());

         
            foreach (var meth in methodsFromType)
                Console.WriteLine(meth);  //Перечень методов с аттрибутами

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var meth in methodsFromType)
                foreach (var attr in meth.CustomAttributes)
                    Console.WriteLine(attr);    //Перечень аттрибутов в методах

        }
    }
}

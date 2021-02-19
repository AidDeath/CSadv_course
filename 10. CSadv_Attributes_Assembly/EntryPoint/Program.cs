using System;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using AttributesDll;
using Microsoft.VisualBasic.CompilerServices;
using SerializationDll;

namespace EntryPoint
{
    //Создайте пользовательский атрибут.Сделайте так, чтоб его можно было применять к 
    //классам и свойствам.Добавьте возможность использовать атрибут несколько раз на одном элементе.
    //Создайте класс в котором будет использован ваш атрибут.

    //С помощью рефлекции достаньте: Только обьявленные вами приватные методы из класса объявленного 
    //вами в прошлом задании. Только объявленные ваши члены класса (Members).

    //Сериализуйте объект вашего класса в JSON фомат и сохрание в файл.В другом методе создайте с
    //помощью десериализации объект на основе данных сохраненных в файле.

    //C помощью статического класса Assembly достаньте информацию по определенной сборке.
    //Выберите один из типов данной сборки и создайте объект этого типа.

    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Private methods:");
            ClassWithAttrib.PrintPrivateMethods();

            //Task 2
            Console.WriteLine("\nAll Declared members:");
            ClassWithAttrib.PrintDeclaredMembers();

            //Task 3
            Console.WriteLine("\n" +
                Serializer.SerializeToFile<ClassWithAttrib>(
                    new ClassWithAttrib() { publicIntProp = 666 },
                    "Jsonfile.json")
                );

            Console.WriteLine($"Deserialized object is:\n{Deserializer.DeserializeFromFileFile<ClassWithAttrib>("Jsonfile.json")}");

            //Task 4
            var assembly = Assembly.GetAssembly(typeof(InformationAttribute));
            var a = (ClassWithAttrib)assembly.CreateInstance(assembly.GetTypes().Where(t=>t.Name == "ClassWithAttrib").ToString());
            Console.WriteLine(a.GetType());
            
        }
    }
}

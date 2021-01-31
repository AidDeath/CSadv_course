using System;

namespace Task2
{
    class Program
    {
        //Объявление обобщенного делегата
        delegate T GenericDelegate<T,R>(R r);

        static void Main(string[] args)
        {
            //При создании определяем типы, с которыми будут работать экземпляры делегата и задаём им методы лямбдой
            GenericDelegate<int, string> genericDelegate_int = s => s.Length;
            GenericDelegate<string, char[]> genericDelegate_string = chararray => new string(chararray);


            //Передаём строку, возвращает значение типа int, с количеством символов в переданной строке
            Console.WriteLine($"Length of phrase is: {genericDelegate_int("Hello World!")}");
            
            //Передаём массив символов, возвращает строку из этих символов.
            Console.WriteLine($"String from a char array: {genericDelegate_string(new char[] { 'H', 'E', 'L', 'L', 'O', '!' })}");
        }
    }
}

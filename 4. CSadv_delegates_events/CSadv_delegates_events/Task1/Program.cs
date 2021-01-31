using System;

namespace Task1
{
    //Главный делегат, с возвратом типа Кот
    delegate Cat MainDelegate();
     class Program
    {
        
        static void Main(string[] args)
        {
            //Создаем объект делегата и инициализируем методом, возвращающим нового кота
            MainDelegate mainDelegate = () => new Cat();

            //Через mainDelegate создается экземпляр кота, и из этого экземпляра вызывается делегат meowDelegate, ссылающийся на метод мяукания
            mainDelegate().meowDelegate();
        }
    }
}

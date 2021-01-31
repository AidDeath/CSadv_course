using System;
using UserCollection.UserCollection;

namespace UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var integers = new MyCollection<int>(1, 21, 32, 43, 5);

            //test.Add(65f);
            //Добавление невозможно, коллекция уже типизирована типом int

            //Добавление элемента
            integers.Add(51);

            integers.Remove(51);    //будет удалён
            integers.Remove(1323);  //нет такого элемента
            integers.Remove(1);     //не будет удалён, т.к. в коллекции не больше 5 элементов.

            foreach (var i in integers)
                Console.WriteLine(i);
            


            var entities = new MyCollection<EntityForCollection>();
            for (int i = 0; i < 3; i++) entities.Add(new EntityForCollection());

            //entities.Add(651); 
            //Добавление невозможно, коллекция уже типизирована типом int

            var entity = new EntityForCollection();
            entities.Add(entity);

            entities.Remove(entity);
            //Не будет удален, т.к. в коллекции не больше 5 элементов

            foreach (var item in entities)
                Console.WriteLine(item.ToString());
        }

    }
}

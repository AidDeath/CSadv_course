using System;

namespace UserCollection
{
    class EntityForCollection
    {//Класс-пустышка для заполнения коллекции
       private Random rand = new Random();
       int echo;

       public EntityForCollection()
       {
           echo = rand.Next(1000);
       }
        public override string ToString()
        {
            return $"Hello! I'm saying {echo}!";
        }
    }
}

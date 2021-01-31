using System;

namespace Task3
{
    delegate void CatMeowsDelegate();
    class Program
    {
        
        static void Main(string[] args)
        {
            //Создаём котёнка
            //В общем то можно и не создавать, т.к. используется Singleton. При создании собаки, человека или мыши, кот появится сам, из воздуха =)
            Cat littleKitty = Cat.GetInstance();

            //Создаём остальную братию
            //При их создании, они сразу же подписываются на кота 
            Dog dog = new Dog();
            Human human = new Human();
            Mouse mouse = new Mouse();
            Mouse oneMoreMouse = new Mouse();

            //Кот мяукает
            littleKitty.Meow();


        }
    }
}

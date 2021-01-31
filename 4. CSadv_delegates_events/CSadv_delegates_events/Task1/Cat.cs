using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    //Делегат для метода класса
    public delegate void CatSaysMeow();

    internal class Cat
    {
        public Cat()
        {
            //Инициализируем делегат-поле класса методом этого же класса
            this.meowDelegate = SayMeow;
        }
        
        private void SayMeow() => Console.WriteLine("Meow - Meow!");

        //Делегат - поле класса
        public CatSaysMeow meowDelegate;

    }
}

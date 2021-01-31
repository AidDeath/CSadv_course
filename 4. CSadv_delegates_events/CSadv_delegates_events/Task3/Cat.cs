using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Cat
    {
        //Поле для ссылки на объект кота
        private static Cat CatInstance;
        //Блокируем 
        private Cat()
        { }
        public static Cat GetInstance()
        {
            return CatInstance ?? (CatInstance = new Cat());
        }

        public event CatMeowsDelegate CatSaysMeow;

        public void Meow()
        {
            Console.WriteLine("Cat said \"Meow!\"");
            CatSaysMeow?.Invoke();
        }
    }
}

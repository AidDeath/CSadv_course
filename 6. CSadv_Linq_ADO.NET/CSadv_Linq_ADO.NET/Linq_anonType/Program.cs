using System;
using System.Linq;

namespace Linq_anonType
{
    //Используя коллекцию персонажей из проекта LINQ, создайте LINQ запрос, в котором
    //выберите анонимный тип который будет содержать в себе 
    //свойство PersonDescription - это должна быть строка, в которой прописаны значения всех свойств персонажа.
    class Program
    {
        static void Main(string[] args)
        {
            var result = CharactersRepository.GetCharacters().Select(character => new
            {
                PersonDescription = $"Name: {character.FirstName}, LastName:{character.LastName}, Age: {character.Age}, Gender: {character.Gender}"
            });

            foreach (var item in result)
            {
                Console.WriteLine(item.PersonDescription);
            }
        }
    }
}

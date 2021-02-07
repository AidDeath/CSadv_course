
using System;
using System.Linq;
using Linq_anonType;

namespace JoinToOwnStruct
{
    //С помощью LINQ сделайте left join колекций персонажей и историй.
    //Создайте структуру данных, которая будет содежать нужные после объединения поля.
    //Т.е.запрос должен быть выполнен без использования анонимного объекта.

    class Program
    {
        static void Main(string[] args)
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();


            var joinedResult = characters.Join(stories, character => character.StoryId, story => story.Id,
                (character, story) => new PersonDescription()
                {
                    FirstName = character.FirstName,
                    LastName = character.LastName,
                    StoryName = story.Name
                });

            foreach (var personDescription in joinedResult)
            {
                Console.WriteLine(personDescription.ToString());
            }

        }
    }

}

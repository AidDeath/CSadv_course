using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Threading;
using System.Xml;
using CSadv_collections.Classes;
using CSadv_collections.Interfaces;
using Microsoft.VisualBasic.CompilerServices;

namespace CSadv_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson []humans =
            {
                new RealPerson("Dzmitry", "Ioksha", 29),
                new RealPerson("Kavin", "Stasey", 46),
                new RealPerson("Dolf", "Lundgren", 56),
                new RealPerson("Mila", "Yovovich", 43),
                new RealPerson("Alice", "Seleznyova", 15),
                
                new FairyTalePerson("Ivan Tsarevich", "Tale about Ivan the fool ", 182), 
                new FairyTalePerson("Alesha Popovich", "Three bogatyrs", 100),
                new FairyTalePerson("Dobrynya Nikitich", "Three bogatyrs", 200),
                new FairyTalePerson("Ilya Muromets", "Three bogatyrs", 300),
                new FairyTalePerson("Zmey Gorynych", "Three bogatyrs", 1000)
            };
            Random rand = new Random();
            IPhoneNumber[] phones = new IPhoneNumber[10];
            for (int i = 0; i < 5; i++)
            {
                phones[i] = new RealPhoneNumber("+" + rand.Next(1, 999), rand.Next(10,99), rand.Next(1000000, 9999999));
            }

            for (int i = 5; i < 10; i++)
            {
                phones[i] = new FakePhoneNumber("Try beating the bell or... ");
            }

            #region Non-Generic Collections
            
            ArrayList humansArrayList = new ArrayList(humans);

            Hashtable humansHashtable = new Hashtable();
            for (var i = 0; i < 10; i++)
            {
                humansHashtable.Add(i, humans[i]);
            }

            Queue humansQueue = new Queue(humans);

            Stack humansStack = new Stack(humans);
            #endregion

            #region Generic Collections

            Dictionary<IPhoneNumber, IPerson> humansDictionary = new Dictionary<IPhoneNumber, IPerson>();
            for (int i = 0; i < 10; i++)
            {
                humansDictionary.Add(phones[i], humans[i]);
            }

            Queue<IPerson> humansGenericQueue = new Queue<IPerson>(humans);
            

            Stack<IPerson> humansGenericStack = new Stack<IPerson>(humans);

            HashSet<IPerson> humansHashSet = new HashSet<IPerson>(humans);

            LinkedList<IPerson> humansLinkedList = new LinkedList<IPerson>(humans);

            List<IPerson> humansList = new List<IPerson>(humans);

            #endregion

            Console.WriteLine("All collections initiated, filled and engaged. Your move...");
            int choise = -1;
            while (choise != 0)
            {
                Console.WriteLine("\n#############################\nYour chiose:\n1 - ArrayList\n2 - Hashtable\n" +
                                  "3 - Queue\n4 - Stack\n5 - Dictionary\n6 - Queue<IPerson>\n7 - Stack<IPerson>\n" +
                                  "8 - Hashset<IPerson>\n9 - LinkedList<IPerson>\n10 - List<IPerson>\n0 - Exit");
                if ( Int32.TryParse(Console.ReadLine(), out choise) == false) choise = -1;

                switch (choise)
                {
                    case 0: continue;
                    case 1: OutputSimple(humansArrayList);
                        break;
                    case 2: OutputSimple(humansHashtable);
                        break;
                    case 3: OutputSimple(humansQueue);
                        break;
                    case 4:OutputSimple(humansStack);
                        break;
                    case 5:OutputSimple(humansDictionary);
                        break;
                    case 6: OutputSimple(humansGenericQueue);
                        break;
                    case 7: OutputSimple(humansGenericStack);
                        break;
                    case 8: OutputSimple(humansHashSet);
                        break;
                    case 9: OutputSimple(humansLinkedList);
                        break;
                    case 10: OutputSimple(humansList);
                        break;
                    default: Console.WriteLine("Numbers 0 - 10 allowed only.");
                        break;
                }
            }



            Console.WriteLine("Now we removing item in the middle of LinkedList\n\t BEFORE");
            OutputSimple(humansLinkedList);
            var linkedListElement = humansLinkedList.First;
            //humansLinkedList.Count
            for (int i = 0; i < humansLinkedList.Count / 2; i++)
                    linkedListElement = linkedListElement.Next;
            humansLinkedList.Remove(linkedListElement);
            Console.Write("\n\tAFTER removing");
            OutputSimple(humansLinkedList);


        }


        static void OutputSimple(IEnumerable collection)
        {
            Console.WriteLine($"\n\t{collection.GetType()}");
            
            Console.WriteLine("FOREACH output:");
            foreach (IPerson human in collection)
            {
                Console.WriteLine(human.ToString());
            }
        }

        static void OutputSimple(Dictionary<IPhoneNumber, IPerson > collection)
        {
            Console.WriteLine($"\n\t{collection.GetType()}");
            foreach (var human in collection)
            {
                Console.Write(human.Key.ToString() + " : ");
                Console.WriteLine(human.Value.ToString());
            }
        }

        static void OutputSimple(Hashtable collection)
        {
            Console.WriteLine($"\n\t{collection.GetType()}");
            foreach (DictionaryEntry human in collection)
            {
                Console.Write(human.Key + " : ");
                Console.WriteLine(human.Value.ToString());
            }
        }
    }
}

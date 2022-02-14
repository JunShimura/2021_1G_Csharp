using System;

namespace VirtualOverRide
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("にゃあ",new DateTime(20, 1, 1), new DateTime(2020,1,1), "にゃんこ");
            Dog dog = new Dog("わん",new DateTime(20, 1, 1), new DateTime(2019, 5, 1), "わんこ");
            Animal[] animals = { cat, dog };
            SpeakAnilal(animals);
            //Console.WriteLine($"{dog.name}が{dog.Speak()}");

        }
        static void SpeakAnilal(Animal[] animals)
        {
            for(var i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{animals[i].name}が{animals[i].Speak()}");
            }
        }

    }
}

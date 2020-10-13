using System;

namespace KawaiiKoneko
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Chunchunmaro", HungryLvl.Satisfied, 50, MoodType.Grumpy);
            Cat cat2 = new Cat("Puck", HungryLvl.Hungry, 40, MoodType.Full);
            Cat cat3 = cat1;

            Console.WriteLine($"Cat 1 = {cat1.Energy}");
            Console.WriteLine($"Cat 2 = {cat2.Energy}");
            Console.WriteLine($"Cat 3 = {cat3.Energy}");
        }
    }
}

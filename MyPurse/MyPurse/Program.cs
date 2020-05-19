using System;

namespace MyPurse
{
    class Program
    {
        static void Main(string[] args)
        {
            BuisnesCard bCard = new BuisnesCard("101");
            Console.WriteLine(bCard.info());
        }
    }
}

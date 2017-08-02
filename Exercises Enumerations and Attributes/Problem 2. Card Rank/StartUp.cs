using System;

namespace Problem_2.Card_Rank
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var comand = Console.ReadLine();

            comArgs(comand);
        }

        private static void comArgs(string comand)
        {
            Console.WriteLine($"{comand}:");
            var cardRanks = Enum.GetValues(typeof(CardRank));
            foreach (var cardRank in cardRanks)
            {
                Console.WriteLine($"Ordinal value: {(int)cardRank}; Name value: {cardRank}");
            }
        }
    }
}

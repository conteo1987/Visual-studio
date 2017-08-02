using System;

namespace Problem_1.Card_Suit
{
    public class Program
    {
        public static void Main()
        {
            var comand = Console.ReadLine();
            comandProces(comand);
        }

        private static void comandProces(string comand)
        {
            Console.WriteLine($"{comand}:");
            var status = Enum.GetValues(typeof(CardSuits));
            foreach (var statu in status)
            {
                Console.WriteLine($"Ordinal value: {(int) statu}; Name value: {statu}");
            }
        }
    }
}

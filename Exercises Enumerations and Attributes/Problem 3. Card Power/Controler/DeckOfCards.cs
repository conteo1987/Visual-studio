using System;
using System.Linq;
using Problem_3.Card_Power.Enums;

namespace Problem_3.Card_Power.Controler
{
    public class DeckOfCards
    {
        public void Run()
        {
            Console.ReadLine();

            var ranks = Enum.GetNames(typeof(Rank));

            this.PrintCardsBySuit(ranks, Suit.Clubs);
            this.PrintCardsBySuit(ranks, Suit.Hearts);
            this.PrintCardsBySuit(ranks, Suit.Diamonds);
            this.PrintCardsBySuit(ranks, Suit.Spades);
        }

        private void PrintCardsBySuit(string[] ranks, Suit suit)
        {
            Console.WriteLine($"{Rank.Ace} of {suit}");
            Console.WriteLine(string.Join(Environment.NewLine, ranks
                .Take(ranks.Length - 1)
                .Select(r => $"{r} of {suit}")));
        }
    }
}

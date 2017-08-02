using System;

namespace Problem_3.Card_Power.Controler
{
    public class CardCompareTo
    {
        public void Run()
        {
            var firstCard = CardPower.GetCardFromConsole();
            var secondCard = CardPower.GetCardFromConsole();

            Console.WriteLine((firstCard.CompareTo(secondCard) > 0)
                ? firstCard
                : secondCard);
        }
    }
}

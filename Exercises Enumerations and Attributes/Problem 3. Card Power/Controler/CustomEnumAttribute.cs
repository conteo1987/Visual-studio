using System;
using Problem_3.Card_Power.Enums;

namespace Problem_3.Card_Power.Controler
{
    public class CustomEnumAttribute
    {
        public void Run()
        {
            var targetEnum = Console.ReadLine();

            var enumType = targetEnum == "Rank"
                ? typeof(Rank)
                : typeof(Suit);

            var attributes = enumType.GetCustomAttributes(false);
            Console.WriteLine(string.Join(Environment.NewLine, attributes));
        }
    }
}

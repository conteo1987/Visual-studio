using System;
using System.Linq;

namespace Froggy
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            var stoneVal = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var stone = new Stones<int>(stoneVal);
            Console.WriteLine(string.Join(", ",stone));
        }
    }
}

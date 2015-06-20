using System;
using System.Linq;

namespace hrMarkAndToys
{
    class Program
    {
        static void Main()
        {
            var nAndK = Console.ReadLine().Split(' ');
            var numToys = Int32.Parse(nAndK[0]);
            var money = Int32.Parse(nAndK[1]);
            var prices = Console.ReadLine()
                .Split(' ')
                .Select(Int32.Parse)
                .OrderBy(x => x)
                .ToArray();
            var totalSpent = 0;
            var toysBought = 0;
            for (int i = 0; i < prices.Length; ++i)
            {
                if (totalSpent + prices[i] <= money)
                {
                    totalSpent += prices[i];
                    ++toysBought;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(toysBought);
        }
    }
}

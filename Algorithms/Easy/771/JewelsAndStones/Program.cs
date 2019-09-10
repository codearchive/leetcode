using System;

namespace JewelsAndStones
{
    public class Program
    {
        static void Main()
        {
            string jewels = Console.ReadLine();
            string stones = Console.ReadLine();

            var jewelsCounter = Solution.JewelsCounter(jewels, stones);

            Console.WriteLine(jewelsCounter);
        }
    }
}

using System;

namespace UniqueMorseCodeWords
{
    public class Program
    {
        public static void Main()
        {
            string[] inputStrings = { "vtpke", "vngc", "vnqr", "gbzx", "qvdx" };

            int uniq = Solution.UniqueMorseRepresentations(inputStrings);

            Console.WriteLine(uniq);
        }
    }
}

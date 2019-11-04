using System;

namespace OutermostParentheses_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution sln = new Solution();

            Console.Write("Input string: ");
            string str = Console.ReadLine();
            Console.WriteLine($"Result: {sln.RemoveOuterParentheses(str)}");
        }
    }
}

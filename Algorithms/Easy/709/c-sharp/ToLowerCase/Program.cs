using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            inputString = Solution.ToLowerCase_WithoutInbuildFunction(inputString);
            Console.WriteLine(inputString);
        }
    }
}

using System;

namespace Defanging_IP_Address
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Console.WriteLine(Solution.DefangIPaddr(inputLine));
        }
    }
}

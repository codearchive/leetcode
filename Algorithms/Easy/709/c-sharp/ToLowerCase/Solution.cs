using System.Text;

namespace ToLowerCase
{
    public static class Solution
    {
        public static string ToLowerCase_WithInbuildFunction(string str)
        {
            return str.ToLower();
        }

        public static string ToLowerCase_WithoutInbuildFunction(string str)
        {
            StringBuilder stringBuilder = new StringBuilder(str.Length);

            foreach (var c in str)
            {
                var temp = c;
                if (temp >= 'A' && temp <= 'Z')
                {
                    temp = (char)(temp + 32);
                }
                stringBuilder.Append(temp);
            }

            return stringBuilder.ToString();
        }
    }
}

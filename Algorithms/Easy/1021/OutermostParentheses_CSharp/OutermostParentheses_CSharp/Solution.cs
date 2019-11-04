using System.Text;

namespace OutermostParentheses_CSharp
{
    public class Solution
    {
        public string RemoveOuterParentheses(string InputString)
        {
            StringBuilder stringBuilder = new StringBuilder(InputString.Length);
            int level = 0;

            for (int i = 1; i < InputString.Length; i++)
            {
                if (InputString[i - 1] == InputString[i])
                {
                    if (InputString[i] == '(')
                    {
                        level++;
                    }
                    else
                    {
                        level--;
                    }
                }
                if (level == 0) continue;
                stringBuilder.Append(InputString[i]);
            }
            return stringBuilder.ToString();
        }
    }
}

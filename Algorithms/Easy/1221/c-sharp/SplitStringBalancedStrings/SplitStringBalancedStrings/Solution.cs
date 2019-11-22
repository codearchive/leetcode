namespace SplitStringBalancedStrings
{
    public class Solution
    {
        public int BalancedStringSplit(string s)
        {
            int balanceCounter = 1;
            int pairCounter = 0;
            char balancedSubstringBegin = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (balancedSubstringBegin == s[i])
                {
                    balanceCounter++;
                }
                else
                {
                    balanceCounter--;
                }

                if (balanceCounter == 0)
                {
                    pairCounter++;
                    balanceCounter = 1;
                    i++;
                    if (i < s.Length)
                    {
                        balancedSubstringBegin = s[i];
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }

            return pairCounter;
        }
    }
}

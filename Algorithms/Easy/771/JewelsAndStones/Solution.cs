using  System.Linq;

namespace JewelsAndStones
{
    public class Solution
    {
        public static int JewelsCounter(string jewels, string stones)
        {
            return stones.Count(c => jewels.Contains(c));
        }
    }
}

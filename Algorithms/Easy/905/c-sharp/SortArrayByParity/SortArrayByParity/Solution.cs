namespace SortArrayByParity
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] array)
        {
            int leftBorder = 0;
            int rightBorder = array.Length - 1;
            int temp = 0;

            while (leftBorder < rightBorder)
            {
                if (array[leftBorder] % 2 == 0)
                {
                    leftBorder++;
                }
                else
                {
                    break;
                }
            }

            while (leftBorder < rightBorder)
            {
                if (array[rightBorder] % 2 == 1)
                {
                    rightBorder--;
                }
                else
                {
                    break;
                }
            }

            while (leftBorder < rightBorder)
            {
                if (array[leftBorder] % 2 == 1 && array[rightBorder] % 2 == 0)
                {
                    temp = array[leftBorder];
                    array[leftBorder] = array[rightBorder];
                    array[rightBorder] = temp;
                    continue;
                }
                if (array[leftBorder] % 2 == 0) leftBorder++;
                if (array[rightBorder] % 2 == 1) rightBorder--;
            }

            return array;
        }
    }
}

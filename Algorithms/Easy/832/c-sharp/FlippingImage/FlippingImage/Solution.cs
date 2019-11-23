namespace FlippingImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length / 2; j++)
                {
                    if (array[i][j] == array[i][array[0].Length - 1 - j])
                    {
                        array[i][array[0].Length - 1 - j] = 1 - array[i][array[0].Length - 1 - j];
                        array[i][j] = 1 - array[i][j];
                    }
                }
                if (array[0].Length % 2 == 1)
                {
                    array[i][array[0].Length / 2] = 1 - array[i][array[0].Length / 2];
                }
            }

            return array;
        }
    }
}

namespace WebApplication2
{
    public class Sorter
    {

        public static double[] SortDouble(double[] notSortedArrayDouble)
        {
            for (int i = 0; i < notSortedArrayDouble.Length - 1; i++)
            {
                for (int j = 0; j < notSortedArrayDouble.Length - (1 + i); j++)
                {
                    if (notSortedArrayDouble[j] > notSortedArrayDouble[j + 1])
                    {
                        double tempDouble = notSortedArrayDouble[j + 1];
                        notSortedArrayDouble[j + 1] = notSortedArrayDouble[j];
                        notSortedArrayDouble[j] = tempDouble;
                    }
                }
            }

            return notSortedArrayDouble;
        }

        public static int[] Sort(int[] notSortedArray)
        {
            for (int i = 0; i < notSortedArray.Length - 1; i++)
            {
                for (int j = 0; j < notSortedArray.Length - (1 + i); j++)
                {
                    if (notSortedArray[j] > notSortedArray[j + 1])
                    {
                        int temp = notSortedArray[j + 1];
                        notSortedArray[j + 1] = notSortedArray[j];
                        notSortedArray[j] = temp;
                    }
                }
            }

            return notSortedArray;
        }



        public static char[] SortChar(char[] notSortedChar)
        {
            for (int i = 0; i < notSortedChar.Length - 1; i++)
            {
                for (int j = 0; j < notSortedChar.Length - (1 + i); j++)
                {
                    if (notSortedChar[j] > notSortedChar[j + 1])
                    {
                        char tempChar = notSortedChar[j + 1];
                        notSortedChar[j + 1] = notSortedChar[j];
                        notSortedChar[j] = tempChar;
                    }
                }
            }

            return notSortedChar;
        }

        public static string SortString(string notSortedString)
        {
            var charArray = notSortedString.ToCharArray();
            SortChar(charArray);

            return new string(charArray);
        }
    }
}
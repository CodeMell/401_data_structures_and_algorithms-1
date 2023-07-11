namespace CodeChallenges
{
    public class CodeChallenge3
    {
        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                {
                    while (mid > 0 && array[mid - 1] == key)
                    {
                        mid--;
                    }
                    return mid;
                }

                if (array[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}

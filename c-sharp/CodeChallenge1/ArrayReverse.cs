using System.Collections;
namespace CodeChallenges
{
    public class CodeChallenge1
    {
        public static int[] ReverseArray(int[] array)
        {

          int[] result = new int[array.Length];
            int rLength = result.Length;

            for (int i = array.Length; i > 0; i--)
            {
              result[rLength - i] = array[i - 1];
              //Console.WriteLine(array[i]);
            }

            return result;
        }
    }
}

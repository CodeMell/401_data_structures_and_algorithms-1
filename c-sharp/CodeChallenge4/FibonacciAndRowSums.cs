namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
<<<<<<< HEAD
      if (nthNumberInSequence <= 0)
        
=======
        public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
        {
            int result = 0;

            return result;
        }
>>>>>>> f95aece7280d55767644e45f3d97e202f4703c2f

      if (nthNumberInSequence == 1 || nthNumberInSequence == 2)
        return 1;

      int pre = 1;
      int current = 1;

      for (int i = 3; i <= nthNumberInSequence; i++)
      {
        int next = pre + current;
        pre = current;
        current = next;
      }

      return current;
    }

    public static int[] RowSums(int[][] matrix)
    {
      if (matrix.Length == 0)
        return new int[0];

      int rows = matrix.Length;
      int cols = matrix[0].Length;
      int[] rowSums = new int[rows];

      for (int i = 0; i < rows; i++)
      {
        int sum = 0;
        for (int j = 0; j < cols; j++)
        {
          sum += matrix[i][j];
        }
        rowSums[i] = sum;
      }

      return rowSums;
    }
  }
}

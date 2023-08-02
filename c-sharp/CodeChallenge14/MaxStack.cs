using System;
using System.Collections.Generic;

namespace CodeChallenges
{
  public class CodeChallenge14
  {
    public class MaxStack
    {
      private Stack<int> stack;
      private Stack<int> maxStack;

      public MaxStack()
      {
        stack = new Stack<int>();
        maxStack = new Stack<int>();
      }

      public void Push(int value)
      {
        stack.Push(value);

        if (maxStack.Count == 0 || value >= maxStack.Peek())
        {
          maxStack.Push(value);
        }
      }

      public int Pop()
      {
        if (stack.Count == 0)
        {
          throw new InvalidOperationException("Stack is empty.");
        }

        int poppedValue = stack.Pop();
        if (poppedValue == maxStack.Peek())
        {
          maxStack.Pop();
        }

        return poppedValue;
      }

      public int GetMax()
      {
        if (maxStack.Count == 0)
        {
          throw new InvalidOperationException("Stack is empty.");
        }

        return maxStack.Peek();
      }
    }

    public string DuckDuckGoose(string[] stringArray, int k)
    {
      if (stringArray == null || stringArray.Length == 0)
      {
        throw new ArgumentException("The input array is empty or null.");
      }

      Queue<string> queue = new Queue<string>(stringArray);

      while (queue.Count > 1)
      {
        for (int i = 1; i <= k; i++)
        {
          string currentPerson = queue.Dequeue();
          if (i < k)
          {
            queue.Enqueue(currentPerson);
          }
        }
      }

      return queue.Dequeue();
    }
  }
}

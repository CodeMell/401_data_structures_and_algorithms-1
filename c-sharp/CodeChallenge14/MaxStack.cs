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
      return "";
    }
  }
}

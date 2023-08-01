using System;
using System.Collections.Generic;

namespace CodeChallenges
{
  public class CodeChallenge13
  {
    public static bool ValidateBrackets(string syntax)
    {
      // Initialize a stack to store the opening brackets
      Stack<char> stack = new Stack<char>();

      // Define a dictionary to store the matching pairs of brackets
      Dictionary<char, char> bracketPairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

      // Loop through each character in the input string
      foreach (char ch in syntax)
      {
        // If the character is an opening bracket, push it onto the stack
        if (bracketPairs.ContainsKey(ch))
        {
          stack.Push(ch);
        }
        // If the character is a closing bracket
        else if (bracketPairs.ContainsValue(ch))
        {
          // Check if the stack is empty or the top of the stack doesn't match the current closing bracket
          if (stack.Count == 0 || bracketPairs[stack.Peek()] != ch)
          {
            return false; // Unbalanced brackets
          }
          stack.Pop(); // Remove the corresponding opening bracket from the stack
        }
      }

      // If the stack is empty, all brackets are balanced
      return stack.Count == 0;
    }
  }
}

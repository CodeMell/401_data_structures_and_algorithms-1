using System.Collections.Generic;
namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedListKth ZipLists(LinkedListKth list1, LinkedListKth list2)
    {
      LinkedListKth result = new LinkedListKth();
      Node current1 = list1.Head;
      Node current2 = list2.Head;

      while (current1 != null || current2 != null)
      {
        if (current1 != null)
        {
          result.Insert(current1.Value);
          current1 = current1.Next;
        }

        if (current2 != null)
        {
          result.Insert(current2.Value);
          current2 = current2.Next;
        }
      }

      return result;
    }

  }
}

using System.Collections.Generic;
namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedListKth ZipLists(LinkedListKth list1, LinkedListKth list2)
    {
      if (list1 == null || list1.Head == null)
        return list2;

      if (list2 == null || list2.Head == null)
        return list1;

      Node current1 = list1.Head;
      Node current2 = list2.Head;

      while (current1 != null && current2 != null)
      {
        Node next1 = current1.Next;
        Node next2 = current2.Next;

        current2.Next = next1;
        current1.Next = current2;

        current1 = next1;
        current2 = next2;
      }

      if (current2 != null)
      {
        list1.Head = list2.Head;
      }

      return list1;
    }
  }
}

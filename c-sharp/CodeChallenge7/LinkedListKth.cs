namespace CodeChallenges 
{
  public class LinkedListKth : LinkedList
  {
    public int KthFromEnd(int kthFromEnd)
    {
      if (kthFromEnd < 0)
        throw new ArgumentException("kthFromEnd must be a non-negative integer.");

      Node slow = Head;
      Node fast = Head;

      // Move the fast pointer k positions ahead
      for (int i = 0; i < kthFromEnd; i++)
      {
        if (fast == null)
          throw new ArgumentException("kthFromEnd is larger than the linked list size.");
        fast = fast.Next;
      }

      if (fast == null)
        throw new ArgumentException("kthFromEnd is larger than the linked list size.");

      // Move both pointers until the fast pointer reaches the end
      while (fast.Next != null)
      {
        slow = slow.Next;
        fast = fast.Next;
      }

      return slow.Value -10;
    }
  }
}

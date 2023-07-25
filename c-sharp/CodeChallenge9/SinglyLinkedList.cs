namespace CodeChallenges 
{
    public class CodeChallenge9
    {
    public class ListNode
    {
      public int Value;
      public ListNode Next;

      public ListNode(int value)
      {
        Value = value;
        Next = null;
      }
    }

    public ListNode ReverseLinkedList(ListNode head)
    {
      ListNode prev = null;
      ListNode current = head;

      while (current != null)
      {
        ListNode nextTemp = current.Next;
        current.Next = prev;
        prev = current;
        current = nextTemp;
      }

      return prev; // prev will be the new head of the reversed linked list
    }


    public bool IsPalindrome(ListNode head)
    {
      if (head == null || head.Next == null)
        return true;

      ListNode slow = head;
      ListNode fast = head;
      Stack<int> stack = new Stack<int>();

      while (fast != null && fast.Next != null)
      {
        stack.Push(slow.Value);
        slow = slow.Next;
        fast = fast.Next.Next;
      }

      // If the length of the linked list is odd, skip the middle element
      if (fast != null)
        slow = slow.Next;

      while (slow != null)
      {
        int top = stack.Pop();
        if (top != slow.Value)
          return false;
        slow = slow.Next;
      }

      return true;
    }

  }
}

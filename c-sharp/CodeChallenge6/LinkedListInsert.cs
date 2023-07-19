namespace CodeChallenges 
{
  public class InsertableLinkedList : LinkedList
  {
    // Adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value);
      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        Node current = Head;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = newNode;
      }
    }

    // Adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);
      if (Head == null)
      {
        Head = newNode;
        return;
      }

      if (Head.Value == value)
      {
        newNode.Next = Head;
        Head = newNode;
        return;
      }

      Node current = Head;
      while (current.Next != null)
      {
        if (current.Next.Value == value)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
          return;
        }
        current = current.Next;
      }
    }

    // Adds a new node with the given new value immediately after the first node that has the value specified
    public void InsertAfter(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);
      Node current = Head;

      while (current != null)
      {
        if (current.Value == value)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
          return;
        }
        current = current.Next;
      }
    }
  }

}

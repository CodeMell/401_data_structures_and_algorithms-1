namespace CodeChallenges
{
  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }

  public class Stack
  {
    private Node Top { get; set; }

    public Stack()
    {
      Top = null;
    }

    public void Push(int value)
    {
      Node newNode = new Node(value) { Next = Top };
      Top = newNode;
    }

    public int Pop()
    {
      if (Top == null)
      {
        throw new InvalidOperationException("The stack is empty.");
      }

      int value = Top.Value;
      Top = Top.Next;
      return value;
    }

    public int Peek()
    {
      if (Top == null)
      {
        throw new InvalidOperationException("The stack is empty.");
      }

      return Top.Value;
    }

    public bool IsEmpty()
    {
      return Top == null;
    }
  }

  public class Queue
  {
    private Node Front { get; set; }
    private Node Rear { get; set; }

    public Queue()
    {
      Front = null;
      Rear = null;
    }

    public void Enqueue(int value)
    {
      Node newNode = new Node(value);

      if (Rear == null)
      {
        Front = newNode;
        Rear = newNode;
      }
      else
      {
        Rear.Next = newNode;
        Rear = newNode;
      }
    }

    public int Dequeue()
    {
      if (Front == null)
      {
        throw new InvalidOperationException("The queue is empty.");
      }

      int value = Front.Value;
      Front = Front.Next;

      if (Front == null)
      {
        Rear = null;
      }

      return value;
    }

    public int Peek()
    {
      if (Front == null)
      {
        throw new InvalidOperationException("The queue is empty.");
      }

      return Front.Value;
    }

    public bool IsEmpty()
    {
      return Front == null;
    }
  }
}

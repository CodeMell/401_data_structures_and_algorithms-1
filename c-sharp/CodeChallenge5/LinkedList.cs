using System.Text;

namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head;

    public void AddNewNode(Node node)
    {
      node.Next = Head;
      Head = node;
    }

    public bool Contains(int value)
    {
      Node current = Head;
      while (current != null)
      {
        if (current.Value == value)
          return true;
        current = current.Next;
      }
      return false;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      Node current = Head;
      while (current != null)
      {
        sb.Append($"{current.Value} -> ");
        current = current.Next;
      }
      sb.Append("NULL");
      return sb.ToString();
    }
  }

  public class Node
  {
    public Node Next;
    public int Value;

    public Node(int value)
    {
      Value = value;
    }
  }
}

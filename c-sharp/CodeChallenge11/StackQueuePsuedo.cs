using Xunit;
namespace CodeChallenges
{
  public class StackQueuePsuedo
  {
    private MyStack enqueueStack;
    private MyStack dequeueStack;

    public StackQueuePsuedo()
    {
      enqueueStack = new MyStack();
      dequeueStack = new MyStack();
    }

    public void Enqueue(int value)
    {
      // Move all elements from dequeueStack to enqueueStack to maintain order.
      while (!dequeueStack.IsEmpty())
      {
        enqueueStack.Push(dequeueStack.Pop());
      }

      enqueueStack.Push(value);
    }

    public int Dequeue()
    {
      // Move all elements from enqueueStack to dequeueStack to maintain order.
      while (!enqueueStack.IsEmpty())
      {
        dequeueStack.Push(enqueueStack.Pop());
      }

      if (dequeueStack.IsEmpty())
      {
        throw new InvalidOperationException("The PseudoQueue is empty.");
      }

      return dequeueStack.Pop();
    }
  }

  // Custom Stack implementation with push, pop, and peek methods.
  public class MyStack
  {
    private class Node
    {
      public int Value;
      public Node Next;
    }

    private Node top;

    public void Push(int value)
    {
      Node newNode = new Node
      {
        Value = value,
        Next = top
      };
      top = newNode;
    }

    public int Pop()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("The stack is empty.");
      }

      int value = top.Value;
      top = top.Next;
      return value;
    }

    public int Peek()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("The stack is empty.");
      }

      return top.Value;
    }

    public bool IsEmpty()
    {
      return top == null;
    }
  }
}

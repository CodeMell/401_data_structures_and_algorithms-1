using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge5Test
  {
    [Fact]
    public void LinkedList_Can_Add_Single_Node()
    {
      LinkedList list = new LinkedList();
      Node node = new Node(5);

      list.AddNewNode(node);
      Assert.Equal(list.Head, node);

    }

    [Fact]
    public void LinkedList_Can_Add_Two_Nodes()
    {
      LinkedList list = new LinkedList();
      Node node1 = new Node(5);
      Node node2 = new Node(6);

      LinkedList expectedList = new LinkedList();
      node2.Next = node1;
      expectedList.Head = node2;
      list.AddNewNode(node1);
      list.AddNewNode(node2);
      Assert.Equal(expectedList.Head, list.Head);
      Assert.Equal(expectedList.Head.Next, list.Head.Next);
      
    }

    [Fact]
    public void Includes_Returns_True_When_Value_Is_Present()
    {
      LinkedList list = new LinkedList();
      Node node1 = new Node(5);
      Node node2 = new Node(6);
      Node node3 = new Node(-1);
      Node node4 = new Node(-2);
      Node node5 = new Node(0);
      list.AddNewNode(node1);
      list.AddNewNode(node2);
      list.AddNewNode(node3);
      list.AddNewNode(node4);
      list.AddNewNode(node5);

      bool result = list.Includes(5);
      bool result1 = list.Includes(0);
      bool result2 = list.Includes(-2);
      bool result3 = list.Includes(-1);

      Assert.True(result);
      Assert.True(result1);
      Assert.True(result2);
      Assert.True(result3);
    }

    [Fact]
    public void Includes_Returns_False_When_Value_IsNot_Present()
    {
      LinkedList list = new LinkedList();
      Node node1 = new Node(5);
      Node node2 = new Node(6);
      Node node3 = new Node(-1);
      Node node4 = new Node(-2);
      Node node5 = new Node(0);
      list.AddNewNode(node1);
      list.AddNewNode(node2);
      list.AddNewNode(node3);
      list.AddNewNode(node4);
      list.AddNewNode(node5);

      bool result = list.Includes(1111);
      bool result1 = list.Includes(2222);
      bool result2 = list.Includes(12313);
      bool result3 = list.Includes(121001);

      Assert.False(result);
      Assert.False(result1);
      Assert.False(result2);
      Assert.False(result3);
    }
  }
}
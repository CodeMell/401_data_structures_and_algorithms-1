using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge8Test
  {
    [Fact]
    public void LinkedList_ZipLists_Both_Lists_Same_Length()
    {
        LinkedListKth list1 = new LinkedListKth();
        list1.Insert(3);
        list1.Insert(2);
        list1.Insert(1);


        LinkedListKth list2 = new LinkedListKth();
        list2.Insert(30);
        list2.Insert(20);
        list2.Insert(10);

        LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Equal(1, result.KthFromEnd(6)); // First node from the end
        Assert.Equal(10, result.KthFromEnd(5)); // Second node from the end
        Assert.Equal(2, result.KthFromEnd(4)); // Third node from the end
        Assert.Equal(20, result.KthFromEnd(3)); // Fourth node from the end
        Assert.Equal(3, result.KthFromEnd(2)); // Fifth node from the end
        Assert.Equal(30, result.KthFromEnd(1)); // Sixth node from the end
    }

    [Fact]
    public void LinkedList_ZipLists_First_List_Longer()
    {
        LinkedListKth list1 = new LinkedListKth();
        list1.Insert(4);
        list1.Insert(3);
        list1.Insert(2);
        list1.Insert(1);

        LinkedListKth list2 = new LinkedListKth();
        list2.Insert(20);
        list2.Insert(10);

        LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Equal(1, result.KthFromEnd(6));
        Assert.Equal(10, result.KthFromEnd(5));
        Assert.Equal(2, result.KthFromEnd(4));
        Assert.Equal(20, result.KthFromEnd(3));
        Assert.Equal(3, result.KthFromEnd(2));
        Assert.Equal(4, result.KthFromEnd(1));
    }

    [Fact]
    public void LinkedList_ZipLists_Second_List_Longer()
    {
        LinkedListKth list1 = new LinkedListKth();
        list1.Insert(2);
        list1.Insert(1);

        LinkedListKth list2 = new LinkedListKth();
        list2.Insert(40);
        list2.Insert(30);
        list2.Insert(20);
        list2.Insert(10);

        LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Equal(1, result.KthFromEnd(6));
        Assert.Equal(10, result.KthFromEnd(5));
        Assert.Equal(2, result.KthFromEnd(4));
        Assert.Equal(20, result.KthFromEnd(3));
        Assert.Equal(30, result.KthFromEnd(2));
        Assert.Equal(40, result.KthFromEnd(1));
    }

    [Fact]
    public void LinkedList_ZipLists_One_List_Empty()
    {
        LinkedListKth list1 = new LinkedListKth();
        list1.Insert(2);
        list1.Insert(1);

        LinkedListKth list2 = new LinkedListKth();

        LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Equal(1, result.KthFromEnd(2));
        Assert.Equal(2, result.KthFromEnd(1));
    }

    [Fact]
    public void LinkedList_ZipLists_Both_Lists_Empty()
    {
        LinkedListKth list1 = new LinkedListKth();
        LinkedListKth list2 = new LinkedListKth();

        LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Null(result.Head);
    }
}
}
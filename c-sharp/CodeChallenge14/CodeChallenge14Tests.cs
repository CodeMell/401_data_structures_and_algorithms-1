using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge14Tests
  {

    private object InvokePrivateMethod(object instance, string methodName, params object[] parameters)
    {
      Type type = instance.GetType();
      MethodInfo methodInfo = type.GetMethod(methodName);
      return methodInfo.Invoke(instance, parameters);
    }

    [Fact]
    public void TestMaxStack()
    {
      CodeChallenge14.MaxStack maxStack = new CodeChallenge14.MaxStack();

      // Use InvokePrivateMethod to call private methods (Push, Pop, Peek, GetMax)
      InvokePrivateMethod(maxStack, "Push", 5);
      InvokePrivateMethod(maxStack, "Push", 3);
      InvokePrivateMethod(maxStack, "Push", 7);
      InvokePrivateMethod(maxStack, "Push", 2);
      InvokePrivateMethod(maxStack, "Push", 9);

      // Use GetPrivateField to get the values of private fields (stack, maxStack, and top)
      Assert.Equal(9, (int)InvokePrivateMethod(maxStack, "GetMax"));

      InvokePrivateMethod(maxStack, "Pop");
      Assert.Equal(7, (int)InvokePrivateMethod(maxStack, "GetMax"));

      InvokePrivateMethod(maxStack, "Pop");
      Assert.Equal(7, (int)InvokePrivateMethod(maxStack, "GetMax"));

      InvokePrivateMethod(maxStack, "Push", 10);
      Assert.Equal(10, (int)InvokePrivateMethod(maxStack, "GetMax"));
    }
    [Fact]
    public void DuckDuckGoose_OnePerson_ShouldReturnTheOnlyPerson()
    {
      // Arrange
      string[] stringArray = new string[] { "John" };
      int k = 2;

      // Act
      string result = CodeChallenge14.DuckDuckGoose(stringArray, k);

      // Assert
      Assert.Equal("John", result);
    }

    [Fact]
    public void DuckDuckGoose_MultiplePeople_ShouldReturnLastPerson()
    {
      // Arrange
      string[] stringArray = new string[] { "Alice", "Bob", "Charlie", "David", "Eve" };
      int k = 3;

      // Act
      string result = CodeChallenge14.DuckDuckGoose(stringArray, k);

      // Assert
      Assert.Equal("David", result);
    }

    [Fact]
    public void DuckDuckGoose_EmptyArray_ShouldThrowArgumentException()
    {
      // Arrange
      string[] stringArray = new string[] { };
      int k = 3;

      // Act & Assert
      Assert.Throws<ArgumentException>(() => CodeChallenge14.DuckDuckGoose(stringArray, k));
    }

    [Fact]
    public void DuckDuckGoose_NegativeKValue_ShouldThrowArgumentException()
    {
      // Arrange
      string[] stringArray = new string[] { "Alice", "Bob", "Charlie", "David", "Eve" };
      int k = -2;

      // Act & Assert
      Assert.Throws<ArgumentException>(() => CodeChallenge14.DuckDuckGoose(stringArray, k));
    }

    [Fact]
    public void DuckDuckGoose_KGreaterThanArrayLength_ShouldWrapAround()
    {
      // Arrange
      string[] stringArray = new string[] {  "Charlie" };
      int k = 10; // k is greater than the array length

      // Act
      string result = CodeChallenge14.DuckDuckGoose(stringArray, k);

      // Assert
      Assert.Equal("Charlie", result);
    }
  }
}

using DSA.DataStructures.StackNS;

namespace DSA.Tests.DataStructuresTests.StackTestsNS
{
  public class StackTests
  {
    private readonly IStack<int> stack;

    public StackTests()
    {
      this.stack = new DSA.DataStructures.StackNS.Stack<int>();
    }

    [Fact]
    public void Push_ShouldIncreaseLength()
    {
      stack.Push(1);
      stack.Push(2);
      Assert.Equal(2, stack.Length());
    }

    [Fact]
    public void Push_ShouldLeaveTheStackInProperOrder()
    {
      int[] compareArray = new int[] { 3, 2, 1 };
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.True(Enumerable.SequenceEqual(compareArray, stack));
    }

    [Fact]
    public void Peek_ShouldReturnTheLastElementWithoutChangingTheStack()
    {
      int[] compareArray = new int[] { 3, 2, 1 };
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Peek();

      Assert.True(Enumerable.SequenceEqual(compareArray, stack));
    }

    [Fact]
    public void Peek_ShouldReturnTheLastElement()
    {
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Peek());
    }

    [Fact]
    public void Peek_ShouldThrowExceptionIfStackIsEmpty()
    {
      Assert.Throws<Exception>(() => stack.Peek());
    }

    [Fact]
    public void Pop_ShouldThrowExceptionIfStackIsEmpty()
    {
      Assert.Throws<Exception>(() => stack.Pop());
    }

    [Fact]
    public void Pop_ShouldLeaveTheStackInLogicalOrder()
    {
      int[] compareArray = new int[] { 2, 1 };
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Pop();

      Assert.True(Enumerable.SequenceEqual(compareArray, stack));
    }

    [Fact]
    public void Pop_ShouldReturnTheLastElementEntered()
    {
      int[] compareArray = new int[] { 1, 2 };
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Pop());
    }
  }
}
using DSA.DataStructures.DynamicArrayNS;

namespace DataStructuresTests.DynamicArraysTestsNS
{
  public class DynamicArrayTests
  {
    private readonly IDynamicArray<int> dynamicArray;

    public DynamicArrayTests()
    {
      dynamicArray = new DynamicArray<int>();
    }

    [Fact]
    public void AddingItemToArrayThenCallingLengthShouldReturnValidLength()
    {
      dynamicArray.AddStart(10);

      Assert.Equal(1, dynamicArray.Length());
    }

    [Fact]
    public void AddingItemsToStartOfTheArrayShouldBehaveAsExpected_0()
    {
      int[] compareArray = new int[] { 1, 2, 3, 4, 5 };
      dynamicArray.AddStart(5);
      dynamicArray.AddStart(4);
      dynamicArray.AddStart(3);
      dynamicArray.AddStart(2);
      dynamicArray.AddStart(1);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void AddingItemsToStartOfTheArrayShouldBehaveAsExpected_1()
    {
      int[] compareArray = new int[] { 5 };
      dynamicArray.AddStart(5);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void AddingItemsToEndOfTheArraySouldBehaveAsExpected_0()
    {
      int[] compareArray = new int[] { 1, 2, 3, 4, 5 };
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);
      dynamicArray.AddEnd(4);
      dynamicArray.AddEnd(5);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void AddingItemsToEndOfTheArraySouldBehaveAsExpected_1()
    {
      int[] compareArray = new int[] { 1 };
      dynamicArray.AddEnd(1);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void AddingItemsToEndAndStartSimultaneouslyShouldWorkAsExpected()
    {
      int[] compareArray = new int[] { 500, 500, 20, 10, 1, 2 };

      dynamicArray.AddEnd(10);
      dynamicArray.AddStart(20);
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddStart(500);
      dynamicArray.AddStart(500);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void CallingDoesExistOnEmptyArrayShouldReturnFalse()
    {
      Assert.False(dynamicArray.DoesExist(20));
    }

    [Fact]
    public void CallingDoesExistOnElementThatDoesntExistShouldReturnFalse()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.False(dynamicArray.DoesExist(20));
    }

    [Fact]
    public void CallingDoesExistOnElementThatExistsShouldReturnTrue()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.True(dynamicArray.DoesExist(3));
    }

    [Fact]
    public void CallingIndexOfOnElemetThatExistShouldReturnIndexOfElement()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Equal(2, dynamicArray.IndexOf(3));
    }

    [Fact]
    public void CallingIndexOfOnEmptyArrayShouldReturnNegativeOne()
    {
      Assert.Equal(-1, dynamicArray.IndexOf(3));
    }

    [Fact]
    public void CallingIndexOfOnElementThatDoesntExistShouldReturnNegativeOne()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Equal(-1, dynamicArray.IndexOf(5));
    }

    [Fact]
    public void CallingRemoveEndtOnEmptyArrayShouldReturnDefaultValueOfT()
    {
      Assert.Equal(default(int), dynamicArray.RemoveEnd());
    }

    [Fact]
    public void CallingRemoveEndShouldDecreaseArrayLength()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveEnd();

      Assert.Equal(2, dynamicArray.Length());
    }

    [Fact]
    public void CallingRemoveEndShouldDecreaseReturnLastElement()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Equal(3, dynamicArray.RemoveEnd());
    }

    [Fact]
    public void CallingRemoveEndNNumberOfTimesShouldEmptyArray()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveEnd();
      dynamicArray.RemoveEnd();
      dynamicArray.RemoveEnd();
      dynamicArray.RemoveEnd();
      Assert.Equal(0, dynamicArray.Length());
    }

    [Fact]
    public void CallingRemoveStarttOnEmptyArrayShouldReturnDefaultValueOfT()
    {
      Assert.Equal(default(int), dynamicArray.RemoveStart());
    }

    [Fact]
    public void CallingRemoveStartShouldDecreaseArrayLength()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveStart();

      Assert.Equal(2, dynamicArray.Length());
    }

    [Fact]
    public void CallingRemoveStartShouldDecreaseReturnFirstElement()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Equal(1, dynamicArray.RemoveStart());
    }

    [Fact]
    public void CallingRemoveStartNNumberOfTimesShouldEmptyArray()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveStart();
      dynamicArray.RemoveStart();
      dynamicArray.RemoveStart();
      dynamicArray.RemoveStart();
      Assert.Equal(0, dynamicArray.Length());
    }

    [Fact]
    public void CallingIndexerOnEmptyArrayShouldThrowException()
    {
      Assert.Throws<IndexOutOfRangeException>(() => dynamicArray[0]);
    }

    [Fact]
    public void CallingIndexersOnNonEmptyArrayShouldReturnItemInIndex()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Equal(2, dynamicArray[1]);
    }

    [Fact]
    public void CallingRemoveOnEmptyArrayShouldThrowException()
    {
      Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.RemoveAt(1));
    }

    [Fact]
    public void CallingRemoveOnEmptyArrayWithOutOfBoundIndexShouldThrowException()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.RemoveAt(3));
    }

    [Fact]
    public void CallingRemoveAtShouldDecreaseLength()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveAt(1);

      Assert.Equal(2, dynamicArray.Length());
    }

    [Fact]
    public void CallingRemoveAtShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 2, 3 };

      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveAt(0);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void CallingRemoveAtShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { 1, 3 };

      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveAt(1);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void CallingRemoveAtShouldWorkAsExpected_2()
    {
      int[] compareArray = new int[] { 1, 2 };

      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      dynamicArray.RemoveAt(2);

      Assert.True(Enumerable.SequenceEqual(compareArray, dynamicArray.GetArray()));
    }

    [Fact]
    public void CallingRemoveAtShouldReturnRemovedItem()
    {
      dynamicArray.AddEnd(1);
      dynamicArray.AddEnd(2);
      dynamicArray.AddEnd(3);

      Assert.Equal(3, dynamicArray.RemoveAt(2));
    }
  }
}
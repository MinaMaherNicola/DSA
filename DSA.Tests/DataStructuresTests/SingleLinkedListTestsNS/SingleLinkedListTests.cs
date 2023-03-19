using DSA.DataStructures.LinkedLists.SingleLinkedListNS;

namespace DSA.Tests.DataStructuresTests.SingleLinkedListTestsNS
{
  public class SingleLinkedListTests
  {
    private readonly ISingleLinkedList<int> singleLinkedList;

    public SingleLinkedListTests()
    {
      singleLinkedList = new SingleLinkedList<int>();
    }

    [Fact]
    public void AddStartShouldIncreaseTheSizeOfTheLinkedList_0()
    {
      singleLinkedList.AddStart(1);

      Assert.Equal(1, singleLinkedList.Length());
    }

    [Fact]
    public void AddStartShouldIncreaseTheSizeOfTheLinkedList_1()
    {
      singleLinkedList.AddStart(1);
      singleLinkedList.AddStart(1);
      singleLinkedList.AddStart(1);
      singleLinkedList.AddStart(1);

      Assert.Equal(4, singleLinkedList.Length());
    }

    [Fact]
    public void AddStartShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 1, 2, 3 };
      singleLinkedList.AddStart(3);
      singleLinkedList.AddStart(2);
      singleLinkedList.AddStart(1);

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void AddStartShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { 1, 3, 2 };
      singleLinkedList.AddStart(3);
      singleLinkedList.AddStart(2);
      singleLinkedList.AddStart(1);

      Assert.False(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void AddEndShouldIncreaseTheSizeOfTheLinkedList_0()
    {
      singleLinkedList.AddEnd(1);

      Assert.Equal(1, singleLinkedList.Length());
    }

    [Fact]
    public void AddEndShouldIncreaseTheSizeOfTheLinkedList_1()
    {
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(1);

      Assert.Equal(4, singleLinkedList.Length());
    }

    [Fact]
    public void AddEndShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 1, 2, 3 };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void AddEndShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { 1, 3, 2 };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);

      Assert.False(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void IsEmptyShouldReturnTrueIfListIsEmpty()
    {
      Assert.True(singleLinkedList.IsEmpty());
    }

    [Fact]
    public void IsEmptyShouldReturnFalseIfListIsNotEmpty()
    {
      singleLinkedList.AddEnd(1);
      Assert.False(singleLinkedList.IsEmpty());
    }

    [Fact]
    public void DoesExistShouldReturnFalseIfListIsEmpty()
    {
      Assert.False(singleLinkedList.DoesExist(10));
    }

    [Fact]
    public void DoesExistShouldReturnFalseIfItemDoesntExist()
    {
      singleLinkedList.AddStart(20);
      singleLinkedList.AddStart(30);
      Assert.False(singleLinkedList.DoesExist(10));
    }

    [Fact]
    public void DoesExistShouldReturnTrueIfItemExists()
    {
      singleLinkedList.AddStart(20);
      singleLinkedList.AddStart(30);
      Assert.True(singleLinkedList.DoesExist(30));
    }

    [Fact]
    public void DeleteStartShouldThrowExceptionIfListIsEmpty()
    {
      Assert.Throws<Exception>(() => singleLinkedList.DeleteStart());
    }

    [Fact]
    public void DeleteStartShouldDecrementLength()
    {
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteStart();
      Assert.Equal(3, singleLinkedList.Length());
    }

    [Fact]
    public void DeleteStartShouldClearListIfItDeletedLastItem()
    {
      singleLinkedList.AddEnd(1);
      singleLinkedList.DeleteStart();
      Assert.True(singleLinkedList.IsEmpty());
    }

    [Fact]
    public void DeleteStartShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 2, 3, 4 };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteStart();

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void DeleteStartShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteStart();
      singleLinkedList.DeleteStart();
      singleLinkedList.DeleteStart();
      singleLinkedList.DeleteStart();

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void DeleteStartShouldWorkAsExpected_2()
    {
      int[] compareArray = new int[] { 4 };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteStart();
      singleLinkedList.DeleteStart();
      singleLinkedList.DeleteStart();

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void DeleteStartShouldWorkAsExpected_3()
    {
      singleLinkedList.AddEnd(1);

      Assert.Equal(1, singleLinkedList.DeleteStart());
    }

    [Fact]
    public void DeleteEndShouldThrowExceptionIfListIsEmpty()
    {
      Assert.Throws<Exception>(() => singleLinkedList.DeleteEnd());
    }

    [Fact]
    public void DeleteEndShouldDecrementLength()
    {
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteEnd();
      Assert.Equal(3, singleLinkedList.Length());
    }

    [Fact]
    public void DeleteEndShouldClearListIfItDeletedLastItem()
    {
      singleLinkedList.AddEnd(1);
      singleLinkedList.DeleteEnd();
      Assert.True(singleLinkedList.IsEmpty());
    }

    [Fact]
    public void DeleteEndShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 1, 2, 3 };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteEnd();

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void DeleteEndShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteEnd();
      singleLinkedList.DeleteEnd();
      singleLinkedList.DeleteEnd();
      singleLinkedList.DeleteEnd();

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void DeleteEndShouldWorkAsExpected_2()
    {
      int[] compareArray = new int[] { 1 };
      singleLinkedList.AddEnd(1);
      singleLinkedList.AddEnd(2);
      singleLinkedList.AddEnd(3);
      singleLinkedList.AddEnd(4);
      singleLinkedList.DeleteEnd();
      singleLinkedList.DeleteEnd();
      singleLinkedList.DeleteEnd();

      Assert.True(Enumerable.SequenceEqual(compareArray, singleLinkedList));
    }

    [Fact]
    public void DeleteEndShouldWorkAsExpected_3()
    {
      singleLinkedList.AddEnd(1);

      Assert.Equal(1, singleLinkedList.DeleteEnd());
    }
  }
}
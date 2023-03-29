using DSA.DataStructures.LinkedLists.DoubleLinkedListNS;

namespace DSA.Tests.DataStructuresTests.DoubleLinkedListTestsNS
{
  public class DoubleLinkedListTests
  {
    private readonly IDoubleLinkedList<int> linkedList;

    public DoubleLinkedListTests()
    {
      this.linkedList = new DoubleLinkedList<int>();
    }

    [Fact]
    public void GettingLengthOfEmptyListShouldReturnZero()
    {
      Assert.Equal(0, linkedList.Length());
    }

    [Fact]
    public void AddStartShouldModifyLength()
    {
      linkedList.AddStart(1);
      linkedList.AddStart(2);
      linkedList.AddStart(3);
      Assert.Equal(3, linkedList.Length());
    }

    [Fact]
    public void AddStartShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 3, 2, 1 };
      linkedList.AddStart(1);
      linkedList.AddStart(2);
      linkedList.AddStart(3);

      Assert.True(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void AddStartShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { 3, 1, 1 };
      linkedList.AddStart(1);
      linkedList.AddStart(2);
      linkedList.AddStart(3);

      Assert.False(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void AddEndShouldModifyLength()
    {
      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddEnd(3);

      Assert.Equal(3, linkedList.Length());
    }

    [Fact]
    public void AddEndShouldWorkAsExpected_0()
    {
      int[] compareArray = new int[] { 1, 2, 3 };
      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddEnd(3);

      Assert.True(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void AddEndShouldWorkAsExpected_1()
    {
      int[] compareArray = new int[] { 1, 1, 3 };
      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddEnd(3);

      Assert.False(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void AddEndAndAddStartShouldPlayTogether_0()
    {
      int[] compareArray = new int[] { 20, 10, 1, 2, 3 };

      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddStart(10);
      linkedList.AddEnd(3);
      linkedList.AddStart(20);

      Assert.True(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void AddEndAndAddStartShouldPlayTogether_1()
    {
      int[] compareArray = new int[] { 20, 10, 1, 2, 6 };

      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddStart(10);
      linkedList.AddEnd(3);
      linkedList.AddStart(20);

      Assert.False(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void AddEndAndAddStartShouldModifyLength()
    {
      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddStart(10);
      linkedList.AddEnd(3);
      linkedList.AddStart(20);

      Assert.Equal(5, linkedList.Length());
    }

    [Fact]
    public void IsEmptyShouldReturnTrueIfListIsEmpty()
    {
      Assert.True(linkedList.IsEmpty());
    }

    [Fact]
    public void IsEmptyShouldReturnFalseIfListIsNotEmpty()
    {
      linkedList.AddEnd(10);
      Assert.False(linkedList.IsEmpty());
    }

    [Fact]
    public void DeleteStartShouldThrowExceptionIfListIsEmpty()
    {
      Assert.Throws<Exception>(() => linkedList.DeleteStart());
    }

    [Fact]
    public void DeleteStartShouldReturnTheDeletedItem()
    {
      linkedList.AddStart(10);
      linkedList.AddStart(1);

      Assert.Equal(1, linkedList.DeleteStart());
    }

    [Fact]
    public void DeleteStartShouldDecrementLength()
    {
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(1);
      linkedList.DeleteStart();
      Assert.Equal(3, linkedList.Length());
    }

    [Fact]
    public void DeleteStartShouldHaveTheAbilityToClearList()
    {
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(1);
      linkedList.DeleteStart();
      linkedList.DeleteStart();
      linkedList.DeleteStart();
      linkedList.DeleteStart();
      Assert.True(linkedList.IsEmpty());
    }

    [Fact]
    public void DeleteStartShouldLeaveTheListInALogicalOrder()
    {
      int[] compareArray = new int[] { 2, 3 };
      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddEnd(3);
      linkedList.DeleteStart();
      Assert.True(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void DeleteEndShouldThrowExceptionIfListIsEmpty()
    {
      Assert.Throws<Exception>(() => linkedList.DeleteEnd());
    }

    [Fact]
    public void DeleteEndShouldReturnTheDeletedItem()
    {
      linkedList.AddStart(10);
      linkedList.AddStart(1);

      Assert.Equal(10, linkedList.DeleteEnd());
    }

    [Fact]
    public void DeleteEndShouldDecrementLength()
    {
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(1);
      linkedList.DeleteEnd();
      Assert.Equal(3, linkedList.Length());
    }

    [Fact]
    public void DeleteEndShouldHaveTheAbilityToClearList()
    {
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(10);
      linkedList.AddStart(1);
      linkedList.DeleteEnd();
      linkedList.DeleteEnd();
      linkedList.DeleteEnd();
      linkedList.DeleteEnd();
      Assert.True(linkedList.IsEmpty());
    }

    [Fact]
    public void DeleteEndShouldLeaveTheListInALogicalOrder()
    {
      int[] compareArray = new int[] { 1, 2 };
      linkedList.AddEnd(1);
      linkedList.AddEnd(2);
      linkedList.AddEnd(3);
      linkedList.DeleteEnd();
      Assert.True(Enumerable.SequenceEqual(compareArray, linkedList));
    }

    [Fact]
    public void DoesExistShouldReturnFalseIfListIsEmpty()
    {
      Assert.False(linkedList.DoesExist(10));
    }

    [Fact]
    public void DoesExistShouldReturnFalseIfItemDoesntExist()
    {
      Assert.False(linkedList.DoesExist(10));
    }

    [Fact]
    public void DoesExistShouldReturnTrueIfItemExists()
    {
      linkedList.AddEnd(10);
      linkedList.AddEnd(11);
      linkedList.AddEnd(12);
      Assert.True(linkedList.DoesExist(10));
    }

    [Fact]
    public void DeleteItemShouldReturnFalseIfListIsEmpty()
    {
      Assert.False(linkedList.DeleteItem(10));
    }

    [Fact]
    public void DeleteItemShouldReturnFalseIfItemIsNotInList()
    {
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);

      Assert.False(linkedList.DeleteItem(50));
    }

    [Fact]
    public void DeleteItemShouldReturnTrueIfItemExistsAndDeleted_0()
    {
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);

      Assert.True(linkedList.DeleteItem(30));
    }

    [Fact]
    public void DeleteItemShouldReturnTrueIfItemExistsAndDeleted_1()
    {
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);

      Assert.True(linkedList.DeleteItem(10));
    }

    [Fact]
    public void DeleteItemShouldReturnTrueIfItemExistsAndDeleted_2()
    {
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);

      Assert.True(linkedList.DeleteItem(20));
    }

    [Fact]
    public void DeleteItemShouldDecrementLength()
    {
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);
      linkedList.DeleteItem(20);
      Assert.Equal(2, linkedList.Length());
    }

    [Fact]
    public void DeleteItemShouldLeaveTheListInLogicalOrder_0()
    {
      int[] comapreArray = new int[] { 10, 30 };
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);
      linkedList.DeleteItem(20);
      Assert.True(Enumerable.SequenceEqual(comapreArray, linkedList));
    }

    [Fact]
    public void DeleteItemShouldLeaveTheListInLogicalOrder_1()
    {
      int[] comapreArray = new int[] { 20, 30 };
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);
      linkedList.DeleteItem(10);
      Assert.True(Enumerable.SequenceEqual(comapreArray, linkedList));
    }

    [Fact]
    public void DeleteItemShouldLeaveTheListInLogicalOrder_2()
    {
      int[] comapreArray = new int[] { 10, 20 };
      linkedList.AddEnd(10);
      linkedList.AddEnd(20);
      linkedList.AddEnd(30);
      linkedList.DeleteItem(30);
      Assert.True(Enumerable.SequenceEqual(comapreArray, linkedList));
    }
  }
}
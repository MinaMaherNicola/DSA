using DSA.Algorithms.SortingAlgorithmsNS;
using DSA.Tests.Utility;

namespace DSA.Tests.SortingAlgorithmsTestsNS
{
  public class SortingAlgorithmsTests
  {

    [Fact]
    public void IsSorted_Should_Return_False_When_Array_Is_Not_Sorted()
    {
      Assert.False(TestingUtiles.IsSorted(new int[] { 1, 2, 3, 4, 5, 10, 6 }));
    }
    [Fact]
    public void IsSorted_Should_Return_True_When_Array_Is_Sorted()
    {
      Assert.True(TestingUtiles.IsSorted(new int[] { 1, 2, 3, 4, 5, 6 }));
    }

    [Fact]
    public void InsertionSort_Should_Sort_Successfully_0()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.InsertionSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })));
    }
    [Fact]
    public void InsertionSort_Should_Sort_Successfully_1()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.InsertionSort(new int[] { 40, 1, 430, 2, -1, 200, 10, 1, 20, 1, 1, 2, 4 })));
    }

    [Fact]
    public void BubbleSort_Should_Sort_Successfully_0()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.BubbleSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })));
    }
    [Fact]
    public void BubbleSort_Should_Sort_Successfully_1()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.BubbleSort(new int[] { 40, 1, 430, 2, -1, 200, 10, 1, 20, 1, 1, 2, 4 })));
    }

    [Fact]
    public void SelectionSort_Should_Sort_Successfully_0()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.SelectionSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })));
    }
    [Fact]
    public void SelectionSort_Should_Sort_Successfully_1()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.SelectionSort(new int[] { 40, 1, 430, 2, -1, 200, 10, 1, 20, 1, 1, 2, 4 })));
    }

    [Fact]
    public void MergeSort_Should_Sort_Successfully_0()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.MergeSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })));
    }
    [Fact]
    public void MergeSort_Should_Sort_Successfully_1()
    {
      Assert.True(TestingUtiles.IsSorted(SortingAlgorithms.MergeSort(new int[] { 40, 1, 430, 2, -1, 200, 10, 1, 20, 1, 1, 2, 4 })));
    }
  }
}
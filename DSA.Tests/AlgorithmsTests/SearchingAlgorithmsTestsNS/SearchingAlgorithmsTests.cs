using DSA.Algorithms.SearchingAlgorithmsNS;

namespace DSA.Tests.AlgorithmsTests.SearchingAlgorithmsNS
{
  public class SearchingAlgorithmsTests
  {
    [Fact]
    public void LinearSearch_ShouldReturnNegativeOne_IfItDidntFindTheItem()
    {
      int[] arr = new int[0];
      int item = 10;

      Assert.Equal(-1, SearchingAlgorithms.LinearSearch(arr, item));
    }

    [Fact]
    public void LinearSearch_ShouldReturnTheIndexOfItem_IfItFindTheItem()
    {
      int[] arr = new int[] { 10, 500, 300, 200, 11, 1, 0 };
      int item = 200;

      Assert.Equal(3, SearchingAlgorithms.LinearSearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnNegativeOne_IfItDidntFindTheItem_0()
    {
      int[] arr = new int[0];
      int item = 10;

      Assert.Equal(-1, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnNegativeOne_IfItDidntFindTheItem_1()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
      int item = -10;

      Assert.Equal(-1, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnNegativeOne_IfItDidntFindTheItem_2()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
      int item = 10;

      Assert.Equal(-1, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_0()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5, 10, 20, 200 };
      int item = 200;

      Assert.Equal(7, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_1()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5, 10, 20, 200 };
      int item = 1;

      Assert.Equal(0, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_2()
    {
      int[] arr = new int[] { 1, 2, 3, 4 };
      int item = 3;

      Assert.Equal(2, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_3()
    {
      int[] arr = new int[] { 1, 2, 3, 4 };
      int item = 2;

      Assert.Equal(1, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_4()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5 };
      int item = 3;

      Assert.Equal(2, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_5()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5 };
      int item = 3;

      Assert.Equal(2, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_6()
    {
      int[] arr = new int[] { 1, 2, 3, 4 };
      int item = 1;

      Assert.Equal(0, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_7()
    {
      int[] arr = new int[] { 1, 2, 3, 4 };
      int item = 4;

      Assert.Equal(3, SearchingAlgorithms.BinarySearch(arr, item));
    }

    [Fact]
    public void BinarySearch_ShouldReturnTheIndexOfItem_IfItFindTheItem_8()
    {
      int[] arr = new int[] { 1, 2, 3, 4, 5 };
      int item = 5;

      Assert.Equal(4, SearchingAlgorithms.BinarySearch(arr, item));
    }
  }
}
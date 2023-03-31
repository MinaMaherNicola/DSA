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
  }
}
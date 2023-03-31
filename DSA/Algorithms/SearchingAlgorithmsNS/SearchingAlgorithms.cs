namespace DSA.Algorithms.SearchingAlgorithmsNS
{
  public static class SearchingAlgorithms
  {
    public static int LinearSearch(int[] arr, int item)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] == item) return i;
      }
      return -1;
    }
  }
}
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

    public static int BinarySearch(int[] arr, int item)
    {
      int left = 0, right = arr.Length - 1, mid = (right + left) / 2;
      while (right >= 0 && left < arr.Length)
      {
        if (arr[mid] == item) return mid;
        if (arr[mid] > item) right = mid - 1;
        if (arr[mid] < item) left = mid + 1;
        mid = (right + left) / 2;
      }
      return -1;
    }
  }
}
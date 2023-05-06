namespace DSA.Algorithms.SortingAlgorithmsNS
{
  public class SortingAlgorithms
  {
    public static int[] InsertionSort(int[] arr)
    {
      for (int i = 0; i < arr.Length - 1; i++)
      {
        int j = i + 1;
        while (j > 0 && arr[j] < arr[j - 1])
        {
          (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
          j--;
        }
      }
      return arr;
    }
  }
}
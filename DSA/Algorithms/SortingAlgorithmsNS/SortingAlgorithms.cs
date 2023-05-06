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

    public static int[] BubbleSort(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = 0; j < arr.Length - 1; j++)
        {
          if (arr[j] > arr[j + 1])
          {
            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
          }
        }
      }
      return arr;
    }

    public static int[] SelectionSort(int[] arr)
    {
      for (int i = 0; i < arr.Length - 1; i++)
      {
        int smallest = arr[i];
        int idx = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] < smallest)
          {
            smallest = arr[j];
            idx = j;
          }
        }
        (arr[i], arr[idx]) = (arr[idx], arr[i]);
      }
      return arr;
    }
  }
}
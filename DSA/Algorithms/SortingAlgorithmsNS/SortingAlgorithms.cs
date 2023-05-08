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


    public static int[] MergeSort(int[] a)
    {
      if (a.Length <= 1) return a;
      return MergeArrays(MergeSort(a[0..(a.Length / 2)]), MergeSort(a[(a.Length / 2)..a.Length]));
    }

    private static int[] MergeArrays(int[] a, int[] b)
    {
      int[] merged = new int[a.Length + b.Length];
      int i = 0, j = 0, k = 0;
      while (i < a.Length && j < b.Length)
      {
        if (a[i] < b[j])
        {
          merged[k] = a[i];
          i++;
        }
        else
        {
          merged[k] = b[j];
          j++;
        }
        k++;
      }
      while (i < a.Length)
      {
        merged[k] = a[i];
        i++;
        k++;
      }
      while (j < b.Length)
      {
        merged[k] = b[j];
        j++;
        k++;
      }
      return merged;
    }
  }
}
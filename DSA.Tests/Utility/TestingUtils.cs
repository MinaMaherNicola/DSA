namespace DSA.Tests.Utility
{
  public class TestingUtiles
  {
    public static bool IsSorted(int[] a)
    {
      int j = a.Length - 1;
      if (j < 1) return true;
      int ai = a[0], i = 1;
      while (i <= j && ai <= (ai = a[i])) i++;
      return i > j;
    }
  }
}
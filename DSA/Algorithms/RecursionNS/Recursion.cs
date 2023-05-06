namespace DSA.Algorithms.RecursionNS
{
  public class Recursion
  {
    public static int Factorial(int num)
    {
      if (num <= 1) return 1;
      return num * Factorial(num - 1);
    }

    public static int Fib(int num)
    {
      if (num == 0) return 0;
      if (num == 1) return 1;

      return Fib(num - 1) + Fib(num - 2);
    }
  }
}
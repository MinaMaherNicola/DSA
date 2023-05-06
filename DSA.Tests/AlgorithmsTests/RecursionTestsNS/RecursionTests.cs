using DSA.Algorithms.RecursionNS;

namespace DSA.Tests.AlgorithmsTests.RecursionTestsNS
{
  public class RecursionTests
  {
    [Fact]
    public void Calling_Factorial_Should_Return_The_Right_Result_0()
    {
      Assert.Equal(120, Recursion.Factorial(5));
    }
    [Fact]
    public void Calling_Factorial_Should_Return_The_Right_Result_1()
    {
      Assert.Equal(1, Recursion.Factorial(1));
    }
    [Fact]
    public void Calling_Factorial_Should_Return_The_Right_Result_2()
    {
      Assert.Equal(1, Recursion.Factorial(0));
    }
  }
}
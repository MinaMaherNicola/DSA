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

    [Fact]
    public void Calling_Fib_On_Ith_Fib_Element_Should_Return_The_Right_Result_0()
    {
      Assert.Equal(0, Recursion.Fib(0));
    }
    [Fact]
    public void Calling_Fib_On_Ith_Fib_Element_Should_Return_The_Right_Result_1()
    {
      Assert.Equal(1, Recursion.Fib(1));
    }
    [Fact]
    public void Calling_Fib_On_Ith_Fib_Element_Should_Return_The_Right_Result_2()
    {
      Assert.Equal(1, Recursion.Fib(2));
    }
    [Fact]
    public void Calling_Fib_On_Ith_Fib_Element_Should_Return_The_Right_Result_3()
    {
      Assert.Equal(5, Recursion.Fib(5));
    }
  }
}
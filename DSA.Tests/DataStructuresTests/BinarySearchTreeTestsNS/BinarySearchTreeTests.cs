using DSA.DataStructures.BinarySearchTreeNS;

namespace DSA.Tests.DataStructuresTests.BinarySearchTreeTestsNS
{
  public class BinarySearchTreeTests
  {
    private readonly IBinarySearchTree bst;

    public BinarySearchTreeTests()
    {
      this.bst = new BinarySearchTree();
    }

    [Fact]
    public void Calling_DoesExist_On_Empty_Tree_Should_Return_False()
    {
      Assert.False(bst.DoesExist(20));
    }

    [Fact]
    public void Calling_DoesExist_On_Elemet_That_Doesnt_Exist_Should_Return_False()
    {
      bst.Add(10);
      bst.Add(25);
      bst.Add(1);
      bst.Add(2);
      bst.Add(240);
      Assert.False(bst.DoesExist(20));
    }

    [Fact]
    public void Calling_DoesExist_On_Elemet_That_Doeس_Exist_Should_Return_True()
    {
      bst.Add(10);
      bst.Add(25);
      bst.Add(1);
      bst.Add(2);
      bst.Add(240);
      Assert.True(bst.DoesExist(240));
    }
  }
}
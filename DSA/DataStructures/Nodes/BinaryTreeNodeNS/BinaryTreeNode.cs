namespace DSA.DataStructures.Nodes.BinaryTreeNodeNS
{
  public class BinaryTreeNode
  {
    public int Data { get; set; }
    public BinaryTreeNode? Left { get; set; }
    public BinaryTreeNode? Right { get; set; }

    public BinaryTreeNode(int data, BinaryTreeNode? left = null, BinaryTreeNode? right = null)
    {
      Data = data;
      Left = left;
      Right = right;
    }
  }
}
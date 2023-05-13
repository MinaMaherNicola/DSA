using DSA.DataStructures.Nodes.BinaryTreeNodeNS;

namespace DSA.DataStructures.BinarySearchTreeNS
{
  public class BinarySearchTree : IBinarySearchTree
  {
    private BinaryTreeNode? root;

    public BinarySearchTree()
    {
      root = null;
    }
    public BinarySearchTree(int data, BinaryTreeNode? left = null, BinaryTreeNode? right = null)
    {
      root = new BinaryTreeNode(data, left, right);
    }

    public bool Add(int item)
    {
      if (this.root == null) return Init(item);
      BinaryTreeNode? cursor = this.root;

      while (cursor != null)
      {
        if (item == cursor.Data) return false;

        if (item > cursor.Data)
        {
          if (cursor.Right == null)
          {
            cursor.Right = new(item);
            return true;
          }
          cursor = cursor.Right;
          continue;
        }

        if (item < cursor.Data)
        {
          if (cursor.Left == null)
          {
            cursor.Left = new(item);
            return true;
          }
          cursor = cursor.Left;
          continue;
        }
      }
      throw new Exception("Something went wrong!");
    }
    private bool Init(int item)
    {
      this.root = new(item);
      return true;
    }
  }
}
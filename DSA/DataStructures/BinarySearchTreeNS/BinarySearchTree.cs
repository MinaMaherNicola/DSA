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

    public bool Remove(int item)
    {
      if (!DoesExist(item)) return false;
      this.root = RemoveNode(this.root, item);
      return true;
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

    public bool DoesExist(int item)
    {
      if (this.root == null) return false;

      BinaryTreeNode? cursor = this.root;

      while (cursor != null)
      {
        if (item == cursor.Data) return true;
        if (item > cursor.Data) cursor = cursor.Right;
        else cursor = cursor.Left;
      }
      return false;
    }

    public BinaryTreeNode? GetNodeIfExists(int item)
    {
      if (this.root == null) return null;

      BinaryTreeNode? cursor = this.root;

      while (cursor != null)
      {
        if (item == cursor.Data) return cursor;
        if (item > cursor.Data) cursor = cursor.Right;
        else cursor = cursor.Left;
      }
      return null;
    }

    private bool Init(int item)
    {
      this.root = new(item);
      return true;
    }
    private bool IsLeafNode(BinaryTreeNode node)
    {
      return node.Left == null && node.Right == null;
    }
    private BinaryTreeNode GetLeftMostNodeInBranch(BinaryTreeNode node)
    {
      BinaryTreeNode cursor = node;
      while (cursor.Left != null) cursor = cursor.Left;
      return cursor;
    }

    private BinaryTreeNode? RemoveNode(BinaryTreeNode? node, int item)
    {
      if (node == null) return null;

      if (item > node.Data)
      {
        node.Right = RemoveNode(node.Right, item);
      }
      if (item < node.Data)
      {
        node.Left = RemoveNode(node.Left, item);
      }
      if (item == node.Data)
      {
        if (IsLeafNode(node)) return null;
        if (node.Right == null) return node.Left;
        if (node.Left == null) return node.Right;

        node.Data = GetLeftMostNodeInBranch(node.Right).Data;
        node.Right = RemoveNode(node.Right, node.Data);
      }
      return node;
    }

    public void PreOrderTraversal()
    {
      Preorder(this.root);
    }

    public void Preorder(BinaryTreeNode? node)
    {
      if (node == null) return;

      Preorder(node.Left);
      Console.WriteLine(node.Data);
      Preorder(node.Right);
    }
  }
}
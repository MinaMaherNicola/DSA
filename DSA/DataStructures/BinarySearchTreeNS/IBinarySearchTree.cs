using DSA.DataStructures.Nodes.BinaryTreeNodeNS;

namespace DSA.DataStructures.BinarySearchTreeNS
{
  public interface IBinarySearchTree
  {
    bool Add(int item);
    bool DoesExist(int item);
    BinaryTreeNode? GetNodeIfExists(int item);
    bool Remove(int item);
    void PreOrderTraversal();
    void InOrderTraversal();
    void PostOrderTraversal();
    void BfsTraversal();
  }
}
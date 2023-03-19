namespace DSA.DataStructures.Nodes.SingleNodeNS
{
  public class SingleNode<T>
  {
    public T? Data { get; set; }
    public SingleNode<T>? Next { get; set; }

    public SingleNode()
    {
      this.Data = default(T);
      this.Next = null;
    }

    public SingleNode(T data)
    {
      this.Data = data;
      this.Next = null;
    }

    public SingleNode(T data, SingleNode<T> node)
    {
      this.Data = data;
      this.Next = node;
    }
  }
}
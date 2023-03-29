namespace DSA.DataStructures.Nodes.DoubleNodeNS
{
  public class DoubleNode<T>
  {
    public T? Data { get; set; }
    public DoubleNode<T>? Next { get; set; }
    public DoubleNode<T>? Prev { get; set; }

    public DoubleNode()
    {
      this.Data = default;
      this.Next = null;
      this.Prev = null;
    }

    public DoubleNode(T data)
    {
      this.Data = data;
      this.Next = null;
      this.Prev = null;
    }

    public DoubleNode(T data, DoubleNode<T> next, DoubleNode<T> prev)
    {
      this.Data = data;
      this.Next = next;
      this.Prev = prev;
    }
  }
}
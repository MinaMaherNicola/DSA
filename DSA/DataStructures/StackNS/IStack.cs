namespace DSA.DataStructures.StackNS
{
  public interface IStack<T> : IEnumerable<T>
  {
    void Push(T item);
    T Pop();
    T Peek();
    int Length();
  }
}
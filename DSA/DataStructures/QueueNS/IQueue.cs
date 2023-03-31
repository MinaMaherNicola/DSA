namespace DSA.DataStructures.QueueNS
{
  public interface IQueue<T> : IEnumerable<T>
  {
    void Enqueue(T item);
    T Peek();
    T Dequeue();
    int Length();
  }
}
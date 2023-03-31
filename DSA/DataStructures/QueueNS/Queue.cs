using System.Collections;
using DSA.DataStructures.LinkedLists.SingleLinkedListNS;

namespace DSA.DataStructures.QueueNS
{
  public class Queue<T> : IQueue<T>
  {
    private readonly ISingleLinkedList<T> linkedList;

    public Queue()
    {
      this.linkedList = new SingleLinkedList<T>();
    }
    public T Dequeue()
    {
      return this.linkedList.DeleteStart();
    }

    public void Enqueue(T item)
    {
      this.linkedList.AddEnd(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
      return this.linkedList.GetEnumerator();
    }

    public int Length()
    {
      return this.linkedList.Length();
    }

    public T Peek()
    {
      T item = this.linkedList.DeleteStart();
      this.linkedList.AddStart(item);
      return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }
}
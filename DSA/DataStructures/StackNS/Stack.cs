using System.Collections;
using DSA.DataStructures.LinkedLists.DoubleLinkedListNS;

namespace DSA.DataStructures.StackNS
{
  public class Stack<T> : IStack<T>
  {
    private readonly IDoubleLinkedList<T> linkedList;
    public Stack()
    {
      this.linkedList = new DoubleLinkedList<T>();
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
      T item = this.linkedList.DeleteEnd();
      this.linkedList.AddEnd(item);
      return item;
    }

    public T Pop()
    {
      return this.linkedList.DeleteEnd();
    }

    public void Push(T item)
    {
      this.linkedList.AddEnd(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }
}
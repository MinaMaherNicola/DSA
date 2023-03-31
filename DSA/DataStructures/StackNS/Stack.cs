using System.Collections;
using DSA.DataStructures.LinkedLists.SingleLinkedListNS;

namespace DSA.DataStructures.StackNS
{
  public class Stack<T> : IStack<T>
  {
    private readonly ISingleLinkedList<T> linkedList;
    public Stack()
    {
      this.linkedList = new SingleLinkedList<T>();
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

    public T Pop()
    {
      return this.linkedList.DeleteStart();
    }

    public void Push(T item)
    {
      this.linkedList.AddStart(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }
}
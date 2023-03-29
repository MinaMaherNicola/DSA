using System.Collections;

namespace DSA.DataStructures.LinkedLists.DoubleLinkedListNS
{
  public interface IDoubleLinkedList<T> : IEnumerable<T>
  {
    void AddStart(T item);
    void AddEnd(T item);
    T DeleteStart();
    T DeleteEnd();
    bool DeleteItem(T item);
    bool DoesExist(T item);
    bool IsEmpty();
    int Length();
    new IEnumerator<T> GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
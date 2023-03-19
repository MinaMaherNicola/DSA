using System.Collections;

namespace DSA.DataStructures.LinkedLists.SingleLinkedListNS
{
  public interface ISingleLinkedList<T> : IEnumerable<T>
  {
    void AddStart(T item);
    void AddEnd(T item);
    T DeleteStart();
    T DeleteEnd();
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
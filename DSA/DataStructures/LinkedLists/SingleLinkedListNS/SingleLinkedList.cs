using System.Collections;
using DSA.DataStructures.Nodes.SingleNodeNS;

namespace DSA.DataStructures.LinkedLists.SingleLinkedListNS
{
  public class SingleLinkedList<T> : ISingleLinkedList<T>, IEnumerable<T>
  {
    private SingleNode<T>? head;
    private SingleNode<T>? tail;
    private int length;

    public SingleLinkedList()
    {
      this.head = null;
      this.tail = null;
      length = 0;
    }

    public void AddEnd(T item)
    {
      if (this.head == null)
      {
        InitializeList(item);
        return;
      }
      SingleNode<T> newNode = new(item);
      this.tail!.Next = newNode;
      this.tail = newNode;
      IncrementLength();
    }

    public void AddStart(T item)
    {
      if (this.head == null)
      {
        InitializeList(item);
        return;
      }

      SingleNode<T> newNode = new(item);
      newNode.Next = this.head;
      this.head = newNode;
      IncrementLength();
    }

    public T DeleteEnd()
    {
      if (IsEmpty()) throw new Exception("Cannot delete from empty list");
      T removedItem = this.tail!.Data!;
      if (this.head == this.tail)
      {
        Clear();
        return removedItem!;
      }
      SingleNode<T> cursor = this.head!;
      while (cursor != null && cursor.Next != this.tail)
      {
        cursor = cursor.Next!;
      }
      cursor!.Next = null;
      this.tail = cursor;
      DecrementLength();
      return removedItem;
    }

    public T DeleteStart()
    {
      if (IsEmpty()) throw new Exception("Cannot delete from empty list");
      T removedItem = this.head!.Data!;
      if (this.head == this.tail)
      {
        Clear();
        return removedItem;
      }
      SingleNode<T>? holder = this.head;
      this.head = this.head.Next;
      holder = null;
      DecrementLength();
      return removedItem;
    }

    public bool DoesExist(T item)
    {
      if (IsEmpty()) return false;
      SingleNode<T> cursor = this.head!;

      while (cursor != null)
      {
        if (cursor.Data!.Equals(item)) return true;
        cursor = cursor.Next!;
      }
      return false;
    }

    public bool IsEmpty()
    {
      return this.head == null;
    }

    public int Length()
    {
      return this.length;
    }

    private void InitializeList(T item)
    {
      SingleNode<T> newNode = new(item);
      this.head = newNode;
      this.tail = this.head;
      IncrementLength();
    }

    private void IncrementLength()
    {
      this.length++;
    }

    private void DecrementLength()
    {
      this.length--;
    }

    private void Clear()
    {
      this.head = null;
      this.tail = null;
      this.length = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
      var cursor = this.head;
      while (cursor != null)
      {
        yield return cursor.Data!;
        cursor = cursor.Next;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public override string ToString()
    {
      string output = "[ Head -> ";

      var cursor = this.head;

      while (cursor != null)
      {
        output += cursor.Data!.ToString() + " -> ";
        cursor = cursor.Next;
      }
      return output += "<- Tail ]";
    }
  }
}
using System.Collections;
using DSA.DataStructures.Nodes.DoubleNodeNS;

namespace DSA.DataStructures.LinkedLists.DoubleLinkedListNS
{
  public class DoubleLinkedList<T> : IDoubleLinkedList<T>, IEnumerable<T>
  {
    private DoubleNode<T>? head;
    private DoubleNode<T>? tail;
    private int length;

    public DoubleLinkedList()
    {
      this.head = null;
      this.tail = null;
      this.length = 0;
    }

    public void AddEnd(T item)
    {
      IncrementLength();
      if (this.head == null)
      {
        InitializeList(item);
        return;
      }
      DoubleNode<T> newNode = new(item);
      newNode.Prev = this.tail;
      this.tail!.Next = newNode;
      this.tail = newNode;
    }

    public void AddStart(T item)
    {
      IncrementLength();
      if (this.head == null)
      {
        InitializeList(item);
        return;
      }
      DoubleNode<T> newNode = new(item);
      newNode.Next = this.head;
      this.head.Prev = newNode;
      this.head = newNode;
    }

    public T DeleteEnd()
    {
      if (this.IsEmpty()) if (this.IsEmpty()) throw new Exception("Cannot remove from empty list");
      this.DecrementLength();
      T deletedItem = this.tail!.Data!;
      if (this.head == this.tail)
      {
        this.Clear();
      }
      else
      {
        DoubleNode<T>? deletedNode = this.tail;
        this.tail = this.tail.Prev;
        this.tail!.Next = null;
        deletedNode.Prev = null;
        deletedNode = null;
      }
      return deletedItem;
    }

    public bool DeleteItem(T item)
    {
      if (!this.DoesExist(item)) return false;
      if (this.head!.Data!.Equals(item))
      {
        this.DeleteStart();
        return true;
      }
      if (this.tail!.Data!.Equals(item))
      {
        this.DeleteEnd();
        return true;
      }
      DecrementLength();
      DoubleNode<T>? cursor = this.head;
      while (!cursor!.Data!.Equals(item))
      {
        cursor = cursor.Next;
      }
      cursor.Prev!.Next = cursor.Next;
      cursor.Next!.Prev = cursor.Prev;
      cursor = null;
      return true;
    }

    public T DeleteStart()
    {
      if (this.IsEmpty()) throw new Exception("Cannot remove from empty list");
      DecrementLength();
      T removedItem = this.head!.Data!;
      if (this.head == this.tail)
      {
        this.Clear();
      }
      else
      {
        DoubleNode<T>? firstNode = this.head;
        this.head = this.head.Next;
        firstNode.Next = null;
        firstNode = null;
        this.head!.Prev = null;
      }

      return removedItem;
    }

    public bool DoesExist(T item)
    {
      if (this.IsEmpty()) return false;
      DoubleNode<T> cursor = this.head!;

      while (cursor != null)
      {
        if (cursor.Data!.Equals(item)) return true;
        cursor = cursor.Next!;
      }
      return false;
    }

    public bool IsEmpty()
    {
      return this.Length() == 0;
    }

    public int Length()
    {
      return this.length;
    }

    public override string ToString()
    {
      string output = "[ Head -> ";
      DoubleNode<T> cursor = this.head!;
      while (cursor != null)
      {
        output += $"{cursor.Data} -> ";
        cursor = cursor.Next!;
      }
      output += "Tail -> ]\n";
      output += "[ Tail -> ";
      cursor = this.tail!;

      while (cursor != null)
      {
        output += $"{cursor.Data} -> ";
        cursor = cursor.Prev!;
      }

      output += "Head -> ]";

      return output;
    }

    public IEnumerator<T> GetEnumerator()
    {
      DoubleNode<T> cursor = this.head!;
      while (cursor != null)
      {
        yield return cursor.Data!;
        cursor = cursor.Next!;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    private void IncrementLength()
    {
      this.length++;
    }
    private void DecrementLength()
    {
      this.length--;
    }
    private void InitializeList(T item)
    {
      this.head = new DoubleNode<T>(item);
      this.tail = this.head;
    }
    private void Clear()
    {
      this.head = null;
      this.tail = null;
    }
  }
}
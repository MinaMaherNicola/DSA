namespace DSA.DataStructures.DynamicArrayNS
{
  public class DynamicArray<T> : IDynamicArray<T>
  {
    private T[] array = new T[0];
    public DynamicArray() { }
    public T this[int index]
    {
      get => this.array[index];
      set => this.array[index] = value;
    }
    public void AddEnd(T data)
    {
      T[] newArray = new T[this.array.Length + 1];

      newArray[newArray.Length - 1] = data;
      for (int i = 0; i <= this.array.Length - 1; i++)
      {
        newArray[i] = this.array[i];
      }
      this.array = newArray;
    }

    public void AddStart(T data)
    {
      T[] newArray = new T[this.array.Length + 1];

      newArray[0] = data;
      for (int i = 0; i < this.array.Length; i++)
      {
        newArray[i + 1] = array[i];
      }
      this.array = newArray;
    }

    public bool DoesExist(T data)
    {
      for (int i = 0; i < this.array.Length; i++)
      {
        if (this.array[i] != null && this.array[i].Equals(data)) return true;
      }
      return false;
    }

    public T[] GetArray()
    {
      return this.array;
    }

    public int IndexOf(T data)
    {
      if (!DoesExist(data)) return -1;

      for (int i = 0; i < this.array.Length; i++)
      {
        if (this.array[i].Equals(data)) return i;
      }
      return -1;
    }

    public int Length()
    {
      return this.array.Length;
    }

    public T? RemoveEnd()
    {
      if (this.array.Length == 0) return default(T);

      T[] newArray = new T[this.array.Length - 1];

      for (int i = 0; i < this.array.Length - 1; i++)
      {
        newArray[i] = this.array[i];
      }
      T removedItem = this.array[this.array.Length - 1];
      this.array = newArray;
      return removedItem;
    }

    public T? RemoveStart()
    {
      if (this.array.Length == 0) return default(T);

      T[] newArray = new T[this.array.Length - 1];

      for (int i = 1; i < this.array.Length; i++)
      {
        newArray[i - 1] = this.array[i];
      }
      T removedItem = this.array[0];
      this.array = newArray;
      return removedItem;
    }
  }
}
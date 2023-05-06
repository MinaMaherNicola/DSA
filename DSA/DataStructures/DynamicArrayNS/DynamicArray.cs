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

      Array.Copy(this.array, newArray, this.array.Length);
      newArray[newArray.Length - 1] = data;
      this.array = newArray;
    }

    public void AddStart(T data)
    {
      T[] newArray = new T[this.array.Length + 1];
      Array.Copy(this.array, 0, newArray, 1, this.array.Length);
      newArray[0] = data;
      this.array = newArray;
    }

    public bool DoesExist(T data)
    {
      return this.array.Any(x => !x!.Equals(default(T)) && x.Equals(data));
    }

    public T[] GetArray()
    {
      return this.array;
    }

    public int IndexOf(T data)
    {
      if (!DoesExist(data)) return -1;
      return Array.IndexOf(this.array, data);
    }

    public int Length()
    {
      return this.array.Length;
    }

    public T RemoveAt(int index)
    {
      if (index < 0 || index >= this.array.Length) throw new IndexOutOfRangeException();

      if (index == 0) return RemoveStart()!;
      if (index == this.array.Length - 1) return RemoveEnd()!;

      T removedItem = this.array[index];
      T[] newArray = new T[this.array.Length - 1];
      Array.Copy(this.array, 0, newArray, 0, index);
      Array.Copy(this.array, index + 1, newArray, index, this.array.Length - 1 - index);

      this.array = newArray;
      return removedItem;
    }

    public T? RemoveEnd()
    {
      if (this.array.Length == 0) return default(T);

      T[] newArray = new T[this.array.Length - 1];
      T removedItem = this.array[this.array.Length - 1];
      Array.Copy(this.array, newArray, this.array.Length - 1);
      this.array = newArray;
      return removedItem;
    }

    public T? RemoveStart()
    {
      if (this.array.Length == 0) return default(T);

      T[] newArray = new T[this.array.Length - 1];
      T removedItem = this.array[0];
      Array.Copy(this.array, 1, newArray, 0, this.array.Length - 1);
      this.array = newArray;
      return removedItem;
    }
  }
}
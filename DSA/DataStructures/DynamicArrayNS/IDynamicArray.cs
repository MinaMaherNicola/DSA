namespace DSA.DataStructures.DynamicArrayNS
{
  public interface IDynamicArray<T>
  {
    T this[int index]
    {
      get;
      set;
    }
    void AddStart(T data);
    void AddEnd(T data);
    T? RemoveStart();
    T? RemoveEnd();
    bool DoesExist(T data);
    int IndexOf(T data);
    int Length();
    T[] GetArray();
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Arrays.DynamicArrayNS
{
    public class DynamicArray<T>
    {
        private T[] array;

        public DynamicArray()
        {
            array = Array.Empty<T>();
        }

        // O(1)
        public int GetLength()
        {
            return array.Length;
        }

        // O(n)
        public void Add(T item)
        {
            T[] newArray = new T[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[^1] = item;
            array = newArray;
        }

        // O(n)
        public void Shift(T item)
        {
            T[] newArray = new T[array.Length + 1];
            array.CopyTo(newArray, 1);
            newArray[0] = item;
            array = newArray;
        }

        // O(1)
        public T FirstOrDefault()
        {
            return array[0];
        }

        // O(1)
        public T LastOrDefault()
        {
            return array[^1];
        }
    }
}

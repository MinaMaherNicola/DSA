using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Arrays.DynamicArrayNS
{
    public class DynamicArray : IDynamicArray
    {
        private int[] array;

        public DynamicArray()
        {
            array = Array.Empty<int>();
        }

        public DynamicArray(int[] array)
        {
            this.array = array;
        }

        // O(1)
        public int GetLength()
        {
            return array.Length;
        }

        // O(n)
        public void Add(int item)
        {
            int[] newArray = new int[array.Length + 1];
            array.CopyTo(newArray, 0);
            newArray[^1] = item;
            array = newArray;
        }

        // O(n)
        public void Shift(int item)
        {
            int[] newArray = new int[array.Length + 1];
            array.CopyTo(newArray, 1);
            newArray[0] = item;
            array = newArray;
        }

        // O(1)
        public int FirstOrDefault()
        {
            return array[0];
        }

        // O(1)
        public int LastOrDefault()
        {
            return array[^1];
        }

        // O(n)
        public bool DoesItemExist(int item)
        {
            foreach (int n in array)
            {
                if (n == item)
                    return true;
            }
            return false;
        }

        // O(n)
        public int GetIndexOf(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                    return i;
            }
            return -1;
        }

        // O(n)
        public int DeleteAtIndex(int index)
        {
            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException();

            int deletedItem = array[index];
            int[] newArr = new int[array.Length - 1];

            Array.Copy(array, 0, newArr, 0, index);
            Array.Copy(array, index + 1, newArr, index, newArr.Length - index);

            array = newArr;

            return deletedItem;
        }

        // O(n)
        public bool CompareArray(int[] array)
        {
            if (array.Length != this.array.Length)
                return false;

            for (int i = 0; i < this.array.Length; i++)
            {
                if (array[i] != this.array[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

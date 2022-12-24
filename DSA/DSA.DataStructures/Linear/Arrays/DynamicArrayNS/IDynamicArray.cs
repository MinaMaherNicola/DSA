using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Arrays.DynamicArrayNS
{
    public interface IDynamicArray
    {
        // O(1)
        int GetLength();

        // O(n)
        void Add(int item);

        // O(n)
        void Shift(int item);

        // O(1)
        int FirstOrDefault();

        // O(1)
        int LastOrDefault();

        // O(n)
        bool DoesItemExist(int item);

        // O(n)
        int GetIndexOf(int item);

        // O(n)
        int DeleteAtIndex(int index);

        // O(n)
        bool CompareArray(int[] array);
    }
}

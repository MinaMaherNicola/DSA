using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.LinkedLists.SingleLinkedListNS
{
    public interface ISingleLinkedList
    {
        // O(1)
        void Shift(int item);

        // O(1)
        void Add(int item);

        // O(n)
        void AddAfter(int target, int item);

        // O(n)
        void ShiftBefore(int target, int item);

        // O(n)
        bool DoesExist(int item);

        // O(1)
        int GetLength();

        // O(n)
        bool DeleteItem(int item);

        // O(1)
        void Clear();

        // O(n)
        int[] ToArray();

        // O(n)
        bool CompareToArray(int[] comparer);

        // O(1)
        int? FirstOrNull();

        // O(1)
        int? LastOrNull();
    }
}

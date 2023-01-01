using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.LinkedLists.DoubleLinkedListNS
{
    public interface IDoubleLinkedList
    {
        // O(1)
        void AddFirst(int item);
        // O(1)
        void AddLast(int item);
        // O(1)
        void RemoveFirst();
        // O(1)
        void RemoveLast();
        // O(n)
        void RemoveItem(int item);
        // O(1)
        int? LastOrNull();
        // O(1)
        int? FirstOrNull();
        // O(n)
        void AddAfter(int target, int item);
        // O(n)
        void AddBefore(int target, int item);
        // O(1)
        void Clear();
        // O(n)
        int[] ToArray();
        // O(n)
        bool EqualToArray(int[] comparer);
        // O(n)
        bool DoesExist(int item);
        // O(1)
        int GetLegnth();
    }
}

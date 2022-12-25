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
        bool DoesExist(int item);

        // O(1)
        int GetLength();

        // O(n)
        void DeleteItem(int item);

        // O(1)
        void Clear();
    }
}

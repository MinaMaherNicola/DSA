using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Queue.LLQueue
{
    public interface IQueue
    {
        // O(1)
        void Enqueue(int item);
        // O(1)
        int Dequeue();
        // O(1)
        int Peek();
        // O(1)
        bool IsEmpty();
        // O(1)
        void Clear();
    }
}

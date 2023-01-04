using DSA.DataStructures.Linear.LinkedLists.DoubleLinkedListNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Stack.LLStack
{
    public class Stack : IStack
    {
        private readonly DoubleLinkedList linkedList = new();
        public void Clear()
        {
            linkedList.Clear();
        }

        public bool IsEmpty()
        {
            return linkedList.GetLegnth() == 0;
        }

        public int Peek()
        {
            return linkedList.PeekLast();
        }

        public int Pop()
        {
            return linkedList.RemoveLast();
        }

        public void Push(int item)
        {
            linkedList.AddLast(item);
        }
    }
}

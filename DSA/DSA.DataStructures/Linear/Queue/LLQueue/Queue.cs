﻿using DSA.DataStructures.Linear.LinkedLists.DoubleLinkedListNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Queue.LLQueue
{
    public class Queue : IQueue
    {
        private readonly DoubleLinkedList linkedList = new();
        public void Clear()
        {
            linkedList.Clear();
        }

        public int Dequeue()
        {
            return linkedList.RemoveFirst();
        }

        public void Enqueue(int item)
        {
            linkedList.AddLast(item);
        }

        public bool IsEmpty()
        {
            return linkedList.GetLegnth() == 0;
        }

        public int Peek()
        {
            return linkedList.PeekFirst();
        }
    }
}
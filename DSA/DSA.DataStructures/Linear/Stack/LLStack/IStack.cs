﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Stack.LLStack
{
    public interface IStack
    {
        // O(1)
        void Push(int item);
        // O(1)
        int Pop();
        // O(1)
        int Peek();
        // O(1)
        bool IsEmpty();
        // O(1)
        void Clear();
    }
}

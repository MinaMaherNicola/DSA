using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.Stack.LLStack
{
    public interface IStack
    {
        void Push(int item);
        int Pop();
        int Peek();
        bool IsEmpty();
        void Clear();
    }
}

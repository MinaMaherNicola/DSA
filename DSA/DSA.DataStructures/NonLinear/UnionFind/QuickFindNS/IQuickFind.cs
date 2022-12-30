using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.NonLinear.UnionFind.QuickFindNS
{
    public interface IQuickFind
    {
        bool Find(int a, int b);
        void Connect(int a, int b);
        int Length();
    }
}

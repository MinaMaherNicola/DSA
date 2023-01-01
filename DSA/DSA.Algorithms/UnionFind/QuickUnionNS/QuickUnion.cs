using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms.UnionFind.QuickUnionNS
{
    public class QuickUnion : IQuickUnion
    {
        private readonly int[] array;
        public QuickUnion(int l)
        {
            if (l <= 0) throw new Exception("Cannot initalize an array with length smaller than or equal to 0!");
            array = new int[l];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        public void Connect(int a, int b)
        {
            array[GetRoot(a)] = GetRoot(b);
        }

        public bool Find(int a, int b)
        {
            return GetRoot(a) == GetRoot(b);
        }

        public int Length()
        {
            return array.Length;
        }

        private int GetRoot(int i)
        {
            while (i != array[i])
            {
                i = array[i];
            }
            return i;
        }
    }
}

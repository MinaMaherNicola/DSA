using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.NonLinear.UnionFind.QuickUnionNS
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
            // 5aly al root bta3 a yb2a child ll root bta3 b
            int aRoot = GetRoot(a);
            int bRoot = GetRoot(b);

            array[aRoot] = bRoot;
        }

        public bool Find(int a, int b)
        {
            int aRoot = GetRoot(a);
            int bRoot = GetRoot(b);

            if (aRoot == bRoot) return true;
            return false;
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

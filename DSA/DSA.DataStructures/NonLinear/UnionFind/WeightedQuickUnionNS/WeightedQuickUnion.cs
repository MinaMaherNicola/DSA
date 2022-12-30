using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.NonLinear.UnionFind.WeightedQuickUnionNS
{
    public class WeightedQuickUnion : IWeightedQuickUnion
    {
        private readonly int[] ids;
        private readonly int[] sz;

        public WeightedQuickUnion(int l)
        {
            ids = new int[l];
            sz = new int[l];

            for (int i = 0; i < l; i++)
            {
                ids[i] = i;
                sz[i] = 1;
            }
        }

        public void Connect(int a, int b)
        {
            int aRootIndex = Root(a);
            int bRootIndex = Root(b);
            if (aRootIndex == bRootIndex) return;

            if (sz[aRootIndex] > sz[bRootIndex])
            {
                ids[bRootIndex] = aRootIndex;
                sz[aRootIndex] += sz[bRootIndex];
                return;
            }
            ids[aRootIndex] = bRootIndex;
            sz[bRootIndex] += sz[aRootIndex];
        }

        public bool Find(int a, int b)
        {
            return Root(a) == Root(b);
        }

        public int Length()
        {
            return ids.Length;
        }

        private int Root(int i)
        {
            while (i != ids[i])
            {
                i = ids[i];
            }
            return i;
        }
    }
}

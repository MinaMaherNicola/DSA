using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.NonLinear.UnionFind.QuickFindNS
{
    public class QuickFind : IQuickFind
    {
        private readonly int[] array;
        public QuickFind(int l)
        {
            if (l <= 0) throw new Exception("Cannot initalize an array with length smaller than or equal to 0!");
            array = new int[l];
        }
        public void Connect(int a, int b)
        {
            int aConnectivitySetId = array[a];
            int bConnectivitySetId = array[b];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == bConnectivitySetId) array[i] = aConnectivitySetId;
            }
        }

        public bool Find(int a, int b)
        {
            if (array[a] == array[b]) return true;
            return false;
        }

        public int Length()
        {
            return array.Length;
        }
    }
}

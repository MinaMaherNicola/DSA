using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Nodes
{
    public class DoubleNode
    {
        public int Data { get; set; }
        public DoubleNode? Next { get; set; }
        public DoubleNode? Prev { get; set; }

        public DoubleNode(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}

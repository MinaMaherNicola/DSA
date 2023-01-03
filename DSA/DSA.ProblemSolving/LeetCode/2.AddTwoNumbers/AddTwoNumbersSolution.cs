using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ProblemSolving.LeetCode._2.AddTwoNumbers
{
    public class AddTwoNumbersSolution
    {
        // O(n)
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            BigInteger l1Value = GetListValuesReversed(l1);
            BigInteger l2Value = GetListValuesReversed(l2);

            BigInteger outputReversed = l1Value + l2Value;
            ListNode head = new((int)(outputReversed % 10));
            outputReversed /= 10;
            ListNode cursor = head;

            while (outputReversed > 0)
            {
                cursor.next = new((int)(outputReversed % 10));
                cursor = cursor.next;
                outputReversed /= 10;
            }
            return head;

        }

        // O(n)
        public BigInteger GetListValuesReversed(ListNode l)
        {
            ListNode cursor = l;
            string listAsString = "";
            while (cursor != null)
            {
                listAsString += cursor.val;
                cursor = cursor.next;
            }
            string listAsReversedString = "";
            for (int i = listAsString.Length - 1; i >= 0; i--)
            {
                listAsReversedString += listAsString[i];
            }
            return BigInteger.Parse(listAsReversedString);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

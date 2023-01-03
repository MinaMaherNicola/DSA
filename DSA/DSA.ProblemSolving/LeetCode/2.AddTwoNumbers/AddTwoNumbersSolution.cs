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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new();
            ListNode dummy = head;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int l1Value = l1 == null ? 0 : l1.val;
                int l2Value = l2 == null ? 0 : l2.val;
                int sum = l1Value + l2Value + carry;
                int lastDigit = sum % 10;
                carry = sum / 10;

                dummy.next = new(lastDigit);
                dummy = dummy.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (carry != 0) dummy.next = new(carry);

            return head.next;
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

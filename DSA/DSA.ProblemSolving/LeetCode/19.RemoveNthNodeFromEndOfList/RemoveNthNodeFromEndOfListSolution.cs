using DSA.ProblemSolving.LeetCode._2.AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ProblemSolving.LeetCode._19.RemoveNthNodeFromEndOfList
{
    public class RemoveNthNodeFromEndOfListSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummyHead = new(0, head);
            ListNode left = dummyHead;
            ListNode right = dummyHead;

            for (int i = 0; i < n + 1; i++)
            {
                right = right.next;
            }

            while (right != null)
            {
                left = left.next;
                right = right.next;
            }
            left.next = left.next.next;
            return dummyHead.next;
        }
    }
}

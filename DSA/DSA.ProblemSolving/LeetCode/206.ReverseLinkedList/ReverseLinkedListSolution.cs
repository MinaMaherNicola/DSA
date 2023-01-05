using DSA.ProblemSolving.LeetCode._2.AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ProblemSolving.LeetCode._206.ReverseLinkedList
{
    public class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode left = null;
            ListNode right = head;

            while (right != null)
            {
                ListNode holder = right.next;
                right.next = left;
                left = right;
                right = holder;
            }
            head = left;
            return head;
        }
    }
}

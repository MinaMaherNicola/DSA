using DSA.ProblemSolving.LeetCode._2.AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ProblemSolving.LeetCode._21.MergeTwoSortedLists
{
    public class MergeTwoSortedListsSolution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyHead = new();
            ListNode cursor = dummyHead;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    cursor.next = new(list2.val);
                    cursor = cursor.next;
                    list2 = list2.next;
                    continue;
                }
                if (list2 == null)
                {
                    cursor.next = new(list1.val);
                    cursor = cursor.next;
                    list1 = list1.next;
                    continue;
                }
                if (list1.val > list2.val)
                {
                    cursor.next = new(list2.val);
                    cursor = cursor.next;
                    list2 = list2.next;
                    continue;
                }
                cursor.next = new(list1.val);
                cursor = cursor.next;
                list1 = list1.next;
                continue;
            }
            return dummyHead.next;
        }
    }
}

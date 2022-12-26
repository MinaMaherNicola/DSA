using DSA.DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.LinkedLists.SingleLinkedListNS
{
    public class SingleLinkedList : ISingleLinkedList
    {
        private SingleNode? head;
        private SingleNode? tail;
        private int length;

        public SingleLinkedList()
        {
            head = default;
            tail = default;
            length = 0;
        }

        public void Add(int item)
        {
            if (IsListEmpty())
            {
                InitializeList(item);
                return;
            }
            tail.Next = new SingleNode(item);
            tail = tail.Next;
            length++;
        }

        public void AddAfter(int target, int item)
        {
            if (IsListEmpty() || !DoesExist(target))
            {
                throw new Exception("Target is not found or LinkedList is empty!");
            }
            SingleNode cursor = head;

            while (cursor.Data != target)
            {
                cursor = cursor.Next;
            }
            SingleNode newNode = new(item);

            if (cursor.Next == null)
            {
                cursor.Next = newNode;
                tail = newNode;
                length++;
                return;
            }

            newNode.Next = cursor.Next;
            cursor.Next = newNode;
            length++;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public bool CompareToArray(int[] comparer)
        {
            if (IsListEmpty() || comparer.Length != length)
            {
                return false;
            }
            SingleNode cursor = head;

            for (int i = 0; i < comparer.Length; i++)
            {
                if (comparer[i] != cursor.Data)
                {
                    return false;
                }
                cursor = cursor.Next;
            }
            return true;
        }

        public bool DeleteItem(int item)
        {
            if (IsListEmpty() || !DoesExist(item))
            {
                return false;
            }
            if (length == 1)
            {
                Clear();
                return true;
            }
            if (head.Data == item)
            {
                head = head.Next;
                length--;
                return true;
            }

            SingleNode cursor = head;

            while (cursor.Next != tail && cursor.Next.Data != item)
            {
                cursor = cursor.Next;
            }

            if (cursor.Next == tail)
            {
                tail = cursor;
                tail.Next = null;
                length--;
                return true;
            }
            cursor.Next = cursor.Next.Next;
            length--;
            return true;
        }

        public bool DoesExist(int item)
        {
            if (IsListEmpty())
            {
                return false;
            }
            SingleNode cursor = head;

            while (cursor != null)
            {
                if (cursor.Data == item)
                {
                    return true;
                }
                cursor = cursor.Next;
            }
            return false;
        }

        public int? FirstOrNull()
        {
            if (IsListEmpty())
            {
                return null;
            }
            return head?.Data;
        }

        public int GetLength()
        {
            return length;
        }

        public int? LastOrNull()
        {
            if (IsListEmpty())
            {
                return null;
            }
            return tail?.Data;
        }

        public void Shift(int item)
        {
            if (IsListEmpty())
            {
                InitializeList(item);
                return;
            }
            head = new SingleNode(item)
            {
                Next = head
            };
            length++;
        }

        public void ShiftBefore(int target, int item)
        {
            if (IsListEmpty() || !DoesExist(target))
            {
                throw new Exception("\"Target is not found or LinkedList is empty!");
            }

            SingleNode newNode = new(item);

            SingleNode cursor = head;

            if (cursor.Data == target)
            {
                newNode.Next = head;
                head = newNode;
                length++;
                return;
            }

            while (cursor.Next != null && cursor.Next.Data != target)
            {
                cursor = cursor.Next;
            }

            newNode.Next = cursor.Next;
            cursor.Next = newNode;
            length++;
        }

        public int[] ToArray()
        {
            if (IsListEmpty())
            {
                return Array.Empty<int>();
            }
            SingleNode cursor = head;
            int[] output = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                output[i] = cursor.Data;
                cursor = cursor.Next;
            }

            return output;
        }

        private void InitializeList(int item)
        {
            head = new(item);
            tail = head;
            length++;
        }

        private bool IsListEmpty()
        {
            if (head == null || tail == null)
            {
                return true;
            }
            return false;
        }
    }
}

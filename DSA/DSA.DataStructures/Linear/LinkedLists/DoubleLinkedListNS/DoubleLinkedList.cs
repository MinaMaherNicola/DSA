using DSA.DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.LinkedLists.DoubleLinkedListNS
{
    public class DoubleLinkedList : IDoubleLinkedList
    {
        private DoubleNode? head;
        private DoubleNode? tail;
        private int length;
        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public void AddAfter(int target, int item)
        {
            if (length == 0) throw new Exception();
            if (!DoesExist(target)) throw new Exception();
            if (length == 1)
            {
                AddLast(item);
                return;
            }

            DoubleNode cursor = head;
            while (cursor != null && cursor.Data != target)
            {
                cursor = cursor.Next;
            }
            if (cursor == tail)
            {
                AddLast(item);
                return;
            }
            DoubleNode newNode = new(item);
            newNode.Next = cursor.Next;
            newNode.Next.Prev = cursor.Prev;
            newNode.Prev = cursor;
            cursor.Next = newNode;
            length++;
        }

        public void AddBefore(int target, int item)
        {
            if (length == 0) throw new Exception();
            if (!DoesExist(target)) throw new Exception();
            if (length == 1)
            {
                AddFirst(item);
                return;
            }

            DoubleNode cursor = head;
            while (cursor != null && cursor.Data != target)
            {
                cursor = cursor.Next;
            }
            if (cursor == head)
            {
                AddFirst(item);
            }
            DoubleNode newNode = new(item);
            newNode.Next = cursor;
            cursor.Prev.Next = newNode;
            newNode.Prev = cursor.Prev;
            cursor.Prev = newNode;
            length++;
        }

        public void AddFirst(int item)
        {
            if (length == 0)
            {
                InitializeList(item);
                return;
            }
            DoubleNode newNode = new(item);
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
            length++;
        }

        public void AddLast(int item)
        {
            if (length == 0)
            {
                InitializeList(item);
                return;
            }
            DoubleNode newNode = new(item);
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
            length++;
        }

        public void Clear()
        {
            head = tail = null;
            length = 0;
        }

        public bool DoesExist(int item)
        {
            if (length == 0) return false;

            if (length == 1 && head.Data == item) return true;

            DoubleNode cursor = head;

            while (cursor != null)
            {
                if (cursor.Data == item) return true;
                cursor = cursor.Next;
            }
            return false;
        }

        public bool EqualToArray(int[] comparer)
        {
            if (comparer.Length != length) return false;

            DoubleNode cursor = head;

            for (int i = 0; i < length; i++)
            {
                if (comparer[i] != cursor.Data)
                {
                    return false;
                }
                cursor = cursor.Next;
            }
            return true;
        }

        public int? FirstOrNull()
        {
            if (head == null)
            {
                return null;
            }
            return head.Data;
        }

        public int GetLegnth()
        {
            return length;
        }

        public int? LastOrNull()
        {
            if (tail == null)
            {
                return null;
            }
            return tail.Data;
        }

        public int PeekLast()
        {
            if (length == 0) throw new Exception();

            return tail.Data;
        }

        public void RemoveFirst()
        {
            if (length == 1)
            {
                Clear();
                return;
            }
            head = head.Next;
            head.Prev.Next = null;
            head.Prev = null;
            length--;
        }

        public void RemoveItem(int item)
        {
            if (!DoesExist(item)) return;

            DoubleNode cursor = head;
            while (cursor != null && cursor.Data != item)
            {
                cursor = cursor.Next;
            }

            if (cursor == head)
            {
                RemoveFirst();
                return;
            }
            if (cursor == tail)
            {
                RemoveLast();
                return;
            }
            cursor.Next.Prev = cursor.Prev;
            cursor.Prev.Next = cursor.Next;
            cursor.Next = null;
            cursor.Prev = null;
            length--;
        }

        public int RemoveLast()
        {
            if (length == 0) throw new Exception();

            int removedItem = tail.Data;
            if (length == 1)
            {
                Clear();
            }
            else
            {
                tail = tail.Prev;
                tail.Next.Prev = null;
                tail.Next = null;
                length--;
            }
            return removedItem;
        }

        public int[] ToArray()
        {
            int[] output = new int[length];
            if (length == 0) return output;

            DoubleNode cursor = head;

            for (int i = 0; i < length; i++)
            {
                output[i] = cursor.Data;
                cursor = cursor.Next;
            }
            return output;
        }

        private void InitializeList(int data)
        {
            head = new(data);
            tail = head;
            length++;
        }
    }
}

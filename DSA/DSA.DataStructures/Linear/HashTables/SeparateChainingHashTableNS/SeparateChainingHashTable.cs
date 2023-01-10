using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.HashTables.SeparateChainingHashTableNS
{
    public class SeparateChainingHashTable
    {
        private readonly LinkedList<string>[] hashtable;

        public SeparateChainingHashTable()
        {
            hashtable = new LinkedList<string>[10];
        }

        public SeparateChainingHashTable(int l)
        {
            hashtable = new LinkedList<string>[l];
        }

        public void Add(string item)
        {
            int index = Hash(item);

            if (hashtable[index] == null) hashtable[index] = new LinkedList<string>();
            hashtable[index].AddLast(item);
        }

        public bool DoesExist(string item)
        {
            int index = Hash(item);
            return hashtable[index] != null && hashtable[index].Contains(item);
        }

        private int Hash(string item)
        {
            int totalAsciiValue = 0;
            foreach (char c in item)
            {
                totalAsciiValue += c;
            }
            return totalAsciiValue % hashtable.Length;
        }
    }
}

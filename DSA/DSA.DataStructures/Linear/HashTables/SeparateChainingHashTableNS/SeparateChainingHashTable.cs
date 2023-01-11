using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures.Linear.HashTables.SeparateChainingHashTableNS
{
    internal class KeyValueLLPair
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public KeyValueLLPair(string key, int value) { Key = key; Value = value; }
    }
    public class SeparateChainingHashTable
    {
        private readonly LinkedList<KeyValueLLPair>[] hashtable;

        public SeparateChainingHashTable()
        {
            hashtable = new LinkedList<KeyValueLLPair>[10];
        }

        public SeparateChainingHashTable(int l)
        {
            hashtable = new LinkedList<KeyValueLLPair>[l];
        }

        public void Add(string key, int value)
        {
            int idx = Hash(key);
            if (DoesKeyExist(key, hashtable[idx])) throw new Exception("Key " + key + "already exists!");

            hashtable[idx] ??= new();
            hashtable[idx].AddLast(new KeyValueLLPair(key, value));
        }

        public bool DoesKeyExist(string key)
        {
            int idx = Hash(key);
            if (hashtable[idx] == null || !DoesKeyExist(key, hashtable[idx])) return false;
            return true;
        }

        private bool DoesKeyExist(string key, LinkedList<KeyValueLLPair> linkedList)
        {
            return linkedList != null && linkedList.Any(p => p.Key == key);
        }

        public int GetValue(string key)
        {
            if (!DoesKeyExist(key)) throw new Exception("Key doesn't exist!");

            int idx = Hash(key);
            return hashtable[idx].First(p => p.Key == key).Value;
        }

        private int Hash(string key)
        {
            int totalAsciiValue = 0;
            foreach (char c in key)
            {
                totalAsciiValue += c;
            }
            return totalAsciiValue % hashtable.Length;
        }
    }
}

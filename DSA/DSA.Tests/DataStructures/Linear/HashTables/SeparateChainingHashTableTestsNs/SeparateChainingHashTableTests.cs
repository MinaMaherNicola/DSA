using DSA.DataStructures.Linear.HashTables.SeparateChainingHashTableNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.DataStructures.Linear.HashTables.SeparateChainingHashTableTestsNs
{
    public class SeparateChainingHashTableTests
    {
        private readonly SeparateChainingHashTable hashTable = new();

        [Fact]
        public void Using_Add_Should_Hash_The_Value_And_Add_It_To_Its_Key()
        {
            hashTable.Add("hello");

            Assert.True(hashTable.DoesExist("hello"));
        }

        [Fact]
        public void Using_DoesExist_With_Item_That_Doesnt_Exist_Should_Return_False()
        {
            Assert.False(hashTable.DoesExist("doe"));
        }

        [Fact]
        public void Using_Add_That_Causes_Collision_Should_Chain_Values_Into_Same_List_0()
        {
            hashTable.Add("a");
            hashTable.Add("@!");

            Assert.True(hashTable.DoesExist("a"));
        }

        [Fact]
        public void Using_Add_That_Causes_Collision_Should_Chain_Values_Into_Same_List_1()
        {
            hashTable.Add("a");
            hashTable.Add("@!");

            Assert.True(hashTable.DoesExist("@!"));
        }
    }
}

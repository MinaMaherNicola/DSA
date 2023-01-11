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
            hashTable.Add("hello", 1);

            Assert.True(hashTable.DoesKeyExist("hello"));
        }

        [Fact]
        public void Adding_With_The_Same_Key_Twice_Should_Throw_Exception()
        {
            hashTable.Add("hello", 1);

            Assert.Throws<Exception>(() => hashTable.Add("hello", 2));
        }

        [Fact]
        public void Using_DoesExist_With_Item_That_Doesnt_Exist_Should_Return_False()
        {
            Assert.False(hashTable.DoesKeyExist("doe"));
        }

        [Fact]
        public void Using_Add_That_Causes_Collision_Should_Chain_Values_Into_Same_List_0()
        {
            hashTable.Add("a", 1);
            hashTable.Add("@!", 2);

            Assert.True(hashTable.DoesKeyExist("a"));
        }

        [Fact]
        public void Using_Add_That_Causes_Collision_Should_Chain_Values_Into_Same_List_1()
        {
            hashTable.Add("a", 1);
            hashTable.Add("@!", 2);

            Assert.True(hashTable.DoesKeyExist("@!"));
        }

        [Fact]
        public void Using_Add_That_Causes_Collision_Should_Chain_Values_Into_Same_List_2()
        {
            hashTable.Add("a", 1);
            hashTable.Add("@!", 2);

            Assert.Equal(1, hashTable.GetValue("a"));
        }

        [Fact]
        public void Using_Add_That_Causes_Collision_Should_Chain_Values_Into_Same_List_3()
        {
            hashTable.Add("a", 1);
            hashTable.Add("@!", 2);

            Assert.Equal(2, hashTable.GetValue("@!"));
        }
    }
}

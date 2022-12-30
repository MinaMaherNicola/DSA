using DSA.DataStructures.NonLinear.UnionFind.QuickUnionNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.DataStructures.NonLinear.UnionFind.QuickUnionTestsNS
{
    public class QuickUnionTests
    {
        [Fact]
        public void Passing_Length_L_To_Quick_Union_Constructor_Should_Create_N_Nodes()
        {
            int length = 10;

            QuickUnion quickUnion = new(length);

            Assert.Equal(length, quickUnion.Length());
        }

        [Fact]
        public void Using_Find_On_Connected_Elements_Should_Return_True_0()
        {
            QuickUnion quickUnion = new(10);

            quickUnion.Connect(1, 2);
            quickUnion.Connect(2, 3);
            quickUnion.Connect(3, 4);
            quickUnion.Connect(5, 8);
            quickUnion.Connect(1, 8);

            Assert.True(quickUnion.Find(2, 8));
        }

        [Fact]
        public void Using_Find_On_Connected_Elements_Should_Return_True_1()
        {
            QuickUnion quickUnion = new(10);

            quickUnion.Connect(1, 2);
            quickUnion.Connect(2, 3);
            quickUnion.Connect(3, 4);
            quickUnion.Connect(5, 8);
            quickUnion.Connect(1, 8);

            Assert.True(quickUnion.Find(3, 5));
        }

        [Fact]
        public void Using_Find_On_Unconnected_Elements_Should_Return_False()
        {
            QuickUnion quickUnion = new(10);

            quickUnion.Connect(1, 2);
            quickUnion.Connect(2, 3);
            quickUnion.Connect(3, 4);
            quickUnion.Connect(5, 8);
            quickUnion.Connect(1, 8);

            Assert.False(quickUnion.Find(1, 9));
        }
    }
}

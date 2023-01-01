using DSA.Algorithms.UnionFind.QuickFindNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.Algorithms.UnionFind.QuickFindTestsNS
{
    public class QuickFindTests
    {
        [Fact]
        public void Using_Constructor_With_Int_N_Should_Create_N_Number_Of_Nodes()
        {
            int length = 10;

            QuickFind quickFind = new(10);

            Assert.Equal(length, quickFind.Length());
        }

        [Fact]
        public void Using_Union_On_Unconnected_Elements_Should_Connect_Them()
        {
            QuickFind quickFind = new(10);

            quickFind.Connect(1, 4);

            Assert.True(quickFind.Find(1, 4));
        }

        [Fact]
        public void Using_Union_On_Unconnected_Elements_From_Different_Connected_Sets_Should_Connect_The_Sets()
        {
            QuickFind quickFind = new(10);

            quickFind.Connect(1, 2);
            quickFind.Connect(2, 3);
            quickFind.Connect(3, 4);
            quickFind.Connect(8, 9);
            quickFind.Connect(4, 9);

            Assert.True(quickFind.Find(9, 1));
        }

        [Fact]
        public void Using_Find_On_Unconnected_Nodes_Should_Return_False()
        {
            QuickFind quickFind = new(10);

            quickFind.Connect(1, 2);
            quickFind.Connect(2, 3);
            quickFind.Connect(3, 4);
            quickFind.Connect(8, 9);
            quickFind.Connect(4, 9);

            Assert.False(quickFind.Find(1, 6));
        }
    }
}

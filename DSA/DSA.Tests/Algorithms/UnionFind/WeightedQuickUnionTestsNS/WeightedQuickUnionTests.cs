using DSA.Algorithms.UnionFind.WeightedQuickUnionNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.Algorithms.UnionFind.WeightedQuickUnionTestsNS
{
    public class WeightedQuickUnionTests
    {
        [Fact]
        public void Initializing_WeightedQuickUnion_With_Length_L_Should_Create_L_Number_Of_Nodes()
        {
            int length = 10;

            WeightedQuickUnion weightedQuickUnion = new(length);

            Assert.Equal(length, weightedQuickUnion.Length());
        }

        [Fact]
        public void Using_Find_On_Two_Unconnected_Elements_Should_Return_False()
        {
            WeightedQuickUnion weightedQuickUnion = new(10);

            Assert.False(weightedQuickUnion.Find(1, 9));
        }

        [Fact]
        public void Using_Find_On_Two_Connected_Elements_Should_Return_True()
        {
            WeightedQuickUnion weightedQuickUnion = new(10);

            weightedQuickUnion.Connect(1, 2);
            weightedQuickUnion.Connect(2, 3);

            weightedQuickUnion.Connect(5, 6);
            weightedQuickUnion.Connect(6, 7);
            weightedQuickUnion.Connect(7, 8);
            weightedQuickUnion.Connect(8, 9);

            weightedQuickUnion.Connect(1, 8);


            Assert.True(weightedQuickUnion.Find(1, 5));
        }
    }
}

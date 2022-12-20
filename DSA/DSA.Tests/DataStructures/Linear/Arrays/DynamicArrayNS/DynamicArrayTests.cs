using DSA.DataStructures.Linear.Arrays.DynamicArrayNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.DataStructures.Linear.Arrays.DynamicArrayNS
{
    public class DynamicArrayTests
    {
        [Fact]
        public void Adding_To_Empty_Dynamic_Array_Should_Increase_Length()
        {
            DynamicArray<int> dynamicArray = new();

            dynamicArray.Add(1);

            Assert.Equal(1, dynamicArray.GetLength());
        }

        [Fact]
        public void Shifting_To_Empty_Dynamic_Array_Should_Increase_Length()
        {
            DynamicArray<int> dynamicArray = new();

            dynamicArray.Shift(1);

            Assert.Equal(1, dynamicArray.GetLength());
        }

        [Fact]
        public void Adding_To_Dynamic_Array_Should_Add_Item_To_The_End_Of_The_Array()
        {
            DynamicArray<int> dynamicArray = new();

            dynamicArray.Add(1);
            dynamicArray.Add(2);

            Assert.Equal(2, dynamicArray.LastOrDefault());
        }

        [Fact]
        public void Shifting_To_Dynamic_Array_Should_Add_Item_To_The_Beginning_Of_The_Array()
        {
            DynamicArray<int> dynamicArray = new();

            dynamicArray.Shift(1);
            dynamicArray.Shift(2);
            dynamicArray.Add(5);

            Assert.Equal(2, dynamicArray.FirstOrDefault());
        }
    }
}

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
        private DynamicArray dynamicArray = new();

        [Fact]
        public void Adding_To_Empty_Dynamic_Array_Should_Increase_Length()
        {
            dynamicArray.Add(1);

            Assert.Equal(1, dynamicArray.GetLength());
        }

        [Fact]
        public void Shifting_To_Empty_Dynamic_Array_Should_Increase_Length()
        {
            dynamicArray.Shift(1);

            Assert.Equal(1, dynamicArray.GetLength());
        }

        [Fact]
        public void Adding_To_Dynamic_Array_Should_Add_Item_To_The_End_Of_The_Array()
        {
            dynamicArray.Add(1);
            dynamicArray.Add(2);

            Assert.Equal(2, dynamicArray.LastOrDefault());
        }

        [Fact]
        public void Shifting_To_Dynamic_Array_Should_Add_Item_To_The_Beginning_Of_The_Array()
        {
            dynamicArray.Shift(1);
            dynamicArray.Shift(2);
            dynamicArray.Add(5);

            Assert.Equal(2, dynamicArray.FirstOrDefault());
        }

        [Fact]
        public void  Using_DoesItemExist_To_Search_For_Item_Not_In_The_Array_Should_Return_False()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });

            Assert.False(dynamicArray.DoesItemExist(11));
        }

        [Fact]
        public void Using_DoesItemExist_To_Search_For_Item_In_The_Array_Should_Return_True()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });

            Assert.True(dynamicArray.DoesItemExist(4));
        }

        [Fact]
        public void GetIndexOf_Should_Return_Minus_One_If_Item_Doesnt_Exist_In_Array()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });

            Assert.Equal(-1, dynamicArray.GetIndexOf(11));
        }

        [Fact]
        public void GetIndexOf_Should_Return_Correct_Index_If_Item_Exists_In_Array()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });

            Assert.Equal(3, dynamicArray.GetIndexOf(4));
        }

        [Fact]
        public void Using_CompareArray_To_Compare_Between_An_Array_And_Dynamic_Array_Should_Return_False_If_Lengths_Are_Not_Equal()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });
            int[] array = new int[] { 1 };

            Assert.False(dynamicArray.CompareArray(array));
        }

        [Fact]
        public void Using_CompareArray_To_Compare_Between_An_Array_And_Dynamic_Array_Should_Return_False_If_The_Arrays_Are_Not_Equal()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });
            int[] array = new int[] { 1, 2, 4, 5 };

            Assert.False(dynamicArray.CompareArray(array));
        }

        [Fact]
        public void Using_CompareArray_To_Compare_Between_An_Array_And_Dynamic_Array_Should_Return_True_If_The_Arrays_Are_Equal()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });
            int[] array = new int[] { 1, 2, 3, 4 };

            Assert.True(dynamicArray.CompareArray(array));
        }

        [Fact]
        public void Using_DeleteAtIndex_Should_Throw_Exception_If_Index_Is_Out_Of_Bound()
        {
            dynamicArray = new(new int[] { 1, 2, 3, 4 });

            Assert.Throws<IndexOutOfRangeException>(() => dynamicArray.DeleteAtIndex(20));
        }

        [Fact]
        public void Using_DeleteAtIndex_Should_Delete_Item_At_Given_Index_Test_0()
        {
            dynamicArray = new(new int[] { 0, 1, 2, 3, 4, 5 });
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            dynamicArray.DeleteAtIndex(0);

            Assert.True(dynamicArray.CompareArray(expected));
        }

        [Fact]
        public void Using_DeleteAtIndex_Should_Delete_Item_At_Given_Index_Test_1()
        {
            dynamicArray = new(new int[] { 0, 1, 2, 3, 4, 5 });
            int[] expected = new int[] { 0, 1, 2, 3, 4 };

            dynamicArray.DeleteAtIndex(5);

            Assert.True(dynamicArray.CompareArray(expected));
        }

        [Fact]
        public void Using_DeleteAtIndex_Should_Delete_Item_At_Given_Index_Test_2()
        {
            dynamicArray = new(new int[] { 0, 1, 2, 3, 4, 5 });
            int[] expected = new int[] { 0, 1, 3, 4, 5 };

            dynamicArray.DeleteAtIndex(2);

            Assert.True(dynamicArray.CompareArray(expected));
        }

        [Fact]
        public void Using_DeleteAtIndex_Should_Delete_Item_At_Given_Index_Test_3()
        {
            dynamicArray = new(new int[] { 0, 1, 2, 3, 4 });
            int[] expected = new int[] { 0, 2, 3, 4 };

            dynamicArray.DeleteAtIndex(1);

            Assert.True(dynamicArray.CompareArray(expected));
        }

        [Fact]
        public void Using_DeleteAtIndex_Should_Delete_Item_At_Given_Index_Test_4()
        {
            dynamicArray = new(new int[] { 0, 1, 2, 3, 4 });
            int[] expected = new int[] { 0, 1, 2, 4 };

            dynamicArray.DeleteAtIndex(3);

            Assert.True(dynamicArray.CompareArray(expected));
        }
    }
}

using DSA.DataStructures.Linear.LinkedLists.DoubleLinkedListNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.DataStructures.Linear.LinkedLists.DoubleLinkedListNS
{
    public class DoubleLinkedListTests
    {
        private readonly DoubleLinkedList doubleLinkedList = new();

        [Fact]
        public void Using_GetLength_On_Empty_List_Should_Return_Zero()
        {
            Assert.Equal(0, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_GetLength_On_List_Should_Return_Correct_Length()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);

            Assert.Equal(4, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_AddLast_Should_Add_Items_To_The_Tail_Of_The_List_0()
        {
            doubleLinkedList.AddLast(1);

            Assert.Equal(1, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_AddLast_Should_Add_Items_To_The_Tail_Of_The_List_1()
        {
            doubleLinkedList.AddLast(1);

            Assert.Equal(1, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_AddLast_Should_Add_Items_To_The_Tail_Of_The_List_2()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);

            Assert.Equal(4, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_AddFirst_Should_Add_Items_To_The_Head_Of_The_List_0()
        {
            doubleLinkedList.AddFirst(1);

            Assert.Equal(1, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_AddFirst_Should_Add_Items_To_The_Head_Of_The_List_1()
        {
            doubleLinkedList.AddFirst(1);

            Assert.Equal(1, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_AddFirst_Should_Add_Items_To_The_Head_Of_The_List_2()
        {
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            doubleLinkedList.AddFirst(4);

            Assert.Equal(4, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_DoesExist_On_Empty_List_Should_Return_False()
        {
            Assert.False(doubleLinkedList.DoesExist(10));
        }

        [Fact]
        public void Using_DoesExist_With_Existing_Value_Should_Return_True_0()
        {
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            doubleLinkedList.AddFirst(4);

            Assert.True(doubleLinkedList.DoesExist(1));
        }

        [Fact]
        public void Using_DoesExist_With_Existing_Value_Should_Return_True_1()
        {
            doubleLinkedList.AddFirst(1);

            Assert.True(doubleLinkedList.DoesExist(1));
        }

        [Fact]
        public void Using_DoesExist_With_Existing_Value_Should_Return_True_2()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);

            Assert.True(doubleLinkedList.DoesExist(4));
        }

        [Fact]
        public void Using_DoesExist_With_Existing_Value_Should_Return_True_3()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);

            Assert.True(doubleLinkedList.DoesExist(2));
        }

        [Fact]
        public void Using_DoesExist_With_Non_Existing_Value_Should_Return_False()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);

            Assert.False(doubleLinkedList.DoesExist(10));
        }

        [Fact]
        public void Using_RemoveFirst_On_List_Of_Length_One_Should_Clear_List_0()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.RemoveFirst();

            Assert.Null(doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveFirst_On_List_Of_Length_One_Should_Clear_List_1()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.RemoveFirst();

            Assert.Null(doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_RemoveFirst_On_List_Of_Length_One_Should_Clear_List_2()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.RemoveFirst();

            Assert.Equal(0, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_RemoveFirst_On_List_Should_Only_Remove_First_Item_0()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddFirst(6);
            doubleLinkedList.RemoveFirst();

            Assert.Equal(5, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveFirst_On_List_Should_Only_Remove_First_Item_1()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddFirst(6);
            doubleLinkedList.RemoveFirst();

            Assert.Equal(1, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveFirst_On_List_Should_Set_Right_Length_Of_List()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddFirst(6);
            doubleLinkedList.RemoveFirst();

            Assert.Equal(2, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_Clear_List_Should_Set_The_Length_To_Zero()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddFirst(6);

            doubleLinkedList.Clear();

            Assert.Equal(0, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_Clear_List_Should_Empty_The_List_0()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddFirst(6);

            doubleLinkedList.Clear();

            Assert.Null(doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_Clear_List_Should_Empty_The_List_1()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddFirst(6);

            doubleLinkedList.Clear();

            Assert.Null(doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_RemoveLast_On_List_Of_Length_One_Should_Clear_List_0()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.RemoveLast();

            Assert.Null(doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveLast_On_List_Of_Length_One_Should_Clear_List_1()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.RemoveLast();

            Assert.Null(doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_RemoveLast_On_List_Of_Length_One_Should_Clear_List_2()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.RemoveLast();

            Assert.Equal(0, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_RemoveLast_On_List_Should_Only_Remove_First_Item_0()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddFirst(5);
            doubleLinkedList.AddFirst(6);
            doubleLinkedList.RemoveLast();

            Assert.Equal(3, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_RemoveLast_On_List_Should_Only_Remove_First_Item_1()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddFirst(6);
            doubleLinkedList.RemoveLast();

            Assert.Equal(6, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveLast_On_List_Should_Set_Right_Length_Of_List()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddFirst(6);
            doubleLinkedList.RemoveLast();

            Assert.Equal(2, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_ToArray_On_Empty_List_Should_Return_Empty_Array()
        {
            Assert.Empty(doubleLinkedList.ToArray());
        }

        [Fact]
        public void Using_ToArray_On_List_Should_Return_A_Valid_Array_Of_List()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddLast(6);

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            Assert.Equal(array, doubleLinkedList.ToArray());
        }

        [Fact]
        public void Using_EqualToArray_To_Comapre_A_List_With_Array_Should_Return_True_If_Array_Is_In_The_Same_Length_And_Same_Item_Order()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddLast(6);

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            Assert.True(doubleLinkedList.EqualToArray(array));
        }

        [Fact]
        public void Using_EqualToArray_To_Comapre_A_List_With_Array_Should_Return_False_If_Array_Is_In_Different_Length()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddLast(6);

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.False(doubleLinkedList.EqualToArray(array));
        }

        [Fact]
        public void Using_EqualToArray_To_Comapre_A_List_With_Array_Should_Return_False_If_Array_Items_Are_Not_In_The_Same_Order()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddLast(6);

            int[] array = new int[] { 2, 1, 3, 4, 5, 6 };

            Assert.False(doubleLinkedList.EqualToArray(array));
        }

        [Fact]
        public void Using_AddAfter_On_Empty_List_Should_Throw_Exception()
        {
            Assert.Throws<Exception>(() => doubleLinkedList.AddAfter(10, 20));
        }

        [Fact]
        public void Using_AddBefore_On_Empty_List_Should_Throw_Exception()
        {
            Assert.Throws<Exception>(() => doubleLinkedList.AddBefore(10, 20));
        }

        [Fact]
        public void Using_AddAfter_On_List_Of_One_Should_Add_To_Tail()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddAfter(1, 10);

            Assert.Equal(10, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_AddAfter_On_Last_Element_Should_Add_To_Tail()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddAfter(2, 10);

            Assert.Equal(10, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_AddBefore_On_List_Of_One_Should_Add_To_Head()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddBefore(1, 10);

            Assert.Equal(10, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_AddBefore_On_List_Should_Increment_Length()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddBefore(1, 10);

            Assert.Equal(2, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_AddAfter_On_List_Should_Increment_Length()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddAfter(1, 10);

            Assert.Equal(2, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_AddAfter_On_List_Should_Keep_Items_In_Order()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddAfter(1, 2);

            Assert.True(doubleLinkedList.EqualToArray(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Fact]
        public void Using_AddBefore_On_List_Should_Keep_Items_In_Order()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.AddLast(5);
            doubleLinkedList.AddBefore(3, 2);

            Assert.True(doubleLinkedList.EqualToArray(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Fact]
        public void Using_AddBefore_On_List_With_Non_Existing_Target_Should_Throw_Exception()
        {
            doubleLinkedList.AddLast(1);

            Assert.Throws<Exception>(() => doubleLinkedList.AddBefore(3, 2));
        }

        [Fact]
        public void Using_AddAfter_On_List_With_Non_Existing_Target_Should_Throw_Exception()
        {
            doubleLinkedList.AddLast(1);

            Assert.Throws<Exception>(() => doubleLinkedList.AddAfter(3, 2));
        }

        [Fact]
        public void Using_AddBefore_On_First_Element_Should_Add_To_Head()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddBefore(1, 10);

            Assert.Equal(10, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveItem_On_Element_That_Doesnt_Exist_Should_Do_Nothing()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.RemoveItem(5);

            Assert.Equal(3, doubleLinkedList.GetLegnth());
        }

        [Fact]
        public void Using_RemoveItem_On_Head_Should_Set_New_Head()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.RemoveItem(1);

            Assert.Equal(2, doubleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_RemoveItem_On_Tail_Should_Set_New_Tail()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.RemoveItem(3);

            Assert.Equal(2, doubleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_RemoveItem_Should_Only_Remove_Passed_Item_0()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.RemoveItem(3);

            Assert.True(doubleLinkedList.EqualToArray(new int[] { 1, 2, 4 }));
        }

        [Fact]
        public void Using_RemoveItem_Should_Only_Remove_Passed_Item_1()
        {
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            doubleLinkedList.AddLast(3);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.RemoveItem(2);

            Assert.True(doubleLinkedList.EqualToArray(new int[] { 1, 3, 4 }));
        }
    }
}

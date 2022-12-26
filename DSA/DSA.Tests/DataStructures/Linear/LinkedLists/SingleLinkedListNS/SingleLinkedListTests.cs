using DSA.DataStructures.Linear.LinkedLists.SingleLinkedListNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.DataStructures.Linear.LinkedLists.SingleLinkedListNS
{
    public class SingleLinkedListTests
    {
        private readonly SingleLinkedList singleLinkedList = new();

        [Fact]
        public void Using_GetLength_On_Uninitialized_List_Should_Return_Zero()
        {
            Assert.Equal(0, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_GetLength_On_Initialized_List_Should_Return_Valid_Length_1()
        {
            singleLinkedList.Shift(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Shift(3);

            Assert.Equal(3, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_GetLength_On_Initialized_List_Should_Return_Valid_Length_2()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.Equal(3, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_GetLength_On_Initialized_List_Should_Return_Valid_Length_3()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.Shift(5);
            singleLinkedList.Shift(6);

            Assert.Equal(6, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_GetLength_On_Initialized_List_Should_Return_Valid_Length_4()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.Shift(5);
            singleLinkedList.Shift(6);
            singleLinkedList.AddAfter(1, 7);
            singleLinkedList.AddAfter(2, 8);
            singleLinkedList.Shift(9);

            Assert.Equal(9, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_GetLength_On_Initialized_List_Should_Return_Valid_Length_5()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.Shift(5);
            singleLinkedList.Shift(6);
            singleLinkedList.ShiftBefore(1, 7);
            singleLinkedList.ShiftBefore(2, 8);
            singleLinkedList.Shift(9);

            Assert.Equal(9, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_GetLength_On_Initialized_List_Should_Return_Valid_Length_6()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.Shift(5);
            singleLinkedList.Shift(6);
            singleLinkedList.ShiftBefore(1, 7);
            singleLinkedList.ShiftBefore(2, 8);
            singleLinkedList.Shift(9);
            singleLinkedList.AddAfter(8, 10);
            singleLinkedList.Add(11);
            singleLinkedList.AddAfter(10, 12);

            Assert.Equal(12, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_Shift_Should_Add_Item_To_Empty_List_Should_Initialize_The_List()
        {
            singleLinkedList.Shift(1);

            Assert.Equal(1, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_FirstOrNull_Should_Return_Null_If_List_Is_Empty()
        {
            Assert.Null(singleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_FirstOrNull_Should_Return_First_Item_On_Initialize_List()
        {
            singleLinkedList.Shift(0);
            singleLinkedList.Shift(1);
            singleLinkedList.Shift(2);

            Assert.Equal(2, singleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_LastOrNull_Should_Return_Null_If_List_Is_Empty()
        {
            Assert.Null(singleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_LastOrNull_Should_Return_Last_Item_On_Initialize_List()
        {
            singleLinkedList.Add(0);
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);

            Assert.Equal(2, singleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_Shift_On_Initialized_List_Should_Always_Add_Item_To_The_Beginning_Of_The_List()
        {
            singleLinkedList.Shift(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Shift(3);

            Assert.Equal(3, singleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_Shift_Multiple_Time_Should_Set_The_Tail_To_Point_At_The_Last_Node()
        {
            singleLinkedList.Shift(1);
            singleLinkedList.Shift(2);
            singleLinkedList.Shift(3);

            Assert.Equal(1, singleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_Add_On_Empty_List_Should_Initialize_List()
        {
            singleLinkedList.Add(1);

            Assert.Equal(1, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_Add_On_List_Should_Add_Items_To_End()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.Equal(3, singleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_Add_Multiple_Time_Should_Set_The_Head_To_Point_At_The_First_Node()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.Equal(1, singleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_DoesExist_On_Empty_List_Should_Return_False()
        {
            Assert.False(singleLinkedList.DoesExist(10));
        }

        [Fact]
        public void Using_DoesExist_On_Item_Thats_Not_In_The_List_Should_Return_False()
        {
            singleLinkedList.Add(20);

            Assert.False(singleLinkedList.DoesExist(10));
        }

        [Fact]
        public void Using_DoesExist_On_Item_Thats_In_The_List_Should_Return_True()
        {
            singleLinkedList.Add(20);
            singleLinkedList.Add(10);

            Assert.True(singleLinkedList.DoesExist(10));
        }

        [Fact]
        public void Using_AddAfter_On_Empty_List_Should_Throw_Exception()
        {
            Assert.Throws<Exception>(() => singleLinkedList.AddAfter(5, 10));
        }

        [Fact]
        public void Using_AddAfter_With_Non_Exist_Target_Should_Throw_Exception()
        {
            singleLinkedList.Add(1);

            Assert.Throws<Exception>(() => singleLinkedList.AddAfter(5, 10));
        }

        [Fact]
        public void Using_AddAfter_With_Valid_Target_And_List_Having_One_Item_Should_Add_To_End()
        {
            singleLinkedList.Add(1);
            singleLinkedList.AddAfter(1, 2);

            Assert.Equal(2, singleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_AddAfter_With_Valid_Target_To_Add_Into_The_Middle_Should_Add_To_The_Middle_1()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(4);
            singleLinkedList.AddAfter(2, 3);

            Assert.Equal(4, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_AddAfter_With_Valid_Target_To_Add_Into_The_Middle_Should_Add_To_The_Middle_2()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(4);
            singleLinkedList.AddAfter(2, 3);

            Assert.True(singleLinkedList.CompareToArray(new int[] { 1, 2, 3, 4 }));
        }

        [Fact]
        public void Using_CompareToArray_With_Empty_List_Should_Return_False()
        {
            Assert.False(singleLinkedList.CompareToArray(new int[] { 1 }));
        }

        [Fact]
        public void Using_CompareToArray_With_Array_Of_Different_Length_Should_Return_False()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.False(singleLinkedList.CompareToArray(new int[] { 1, 2 }));
        }

        [Fact]
        public void Using_CompareToArray_With_Array_Of_Same_Length_But_Different_Items_Should_Return_False()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.False(singleLinkedList.CompareToArray(new int[] { 1, 2, 4 }));
        }

        [Fact]
        public void Using_CompareToArray_With_Array_Of_Same_Length_But_Different_Item_Order_Should_Return_False()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.False(singleLinkedList.CompareToArray(new int[] { 3, 1, 2 }));
        }

        [Fact]
        public void Using_CompareToArray_With_Array_Of_Same_Length_And_Same_Items_With_Correct_Order_Should_Return_True()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.True(singleLinkedList.CompareToArray(new int[] { 1, 2, 3 }));
        }

        [Fact]
        public void Using_ShiftBefore_On_Empty_List_Should_Throw_Exception()
        {
            Assert.Throws<Exception>(() => singleLinkedList.ShiftBefore(5, 10));
        }

        [Fact]
        public void Using_ShiftBefore_With_Non_Exist_Target_Should_Throw_Exception()
        {
            singleLinkedList.Add(1);

            Assert.Throws<Exception>(() => singleLinkedList.ShiftBefore(5, 10));
        }

        [Fact]
        public void Using_ShiftBefore_With_Valid_Target_And_List_Having_One_Item_Should_Add_To_Start()
        {
            singleLinkedList.Add(1);
            singleLinkedList.ShiftBefore(1, 2);

            Assert.Equal(2, singleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_ShiftBefore_With_Valid_Target_To_Add_Into_The_Middle_Should_Add_To_The_Middle_1()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(4);
            singleLinkedList.ShiftBefore(4, 3);

            Assert.Equal(4, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_ShiftBefore_With_Valid_Target_To_Add_Into_The_Middle_Should_Add_To_The_Middle_2()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(4);
            singleLinkedList.ShiftBefore(4, 3);

            Assert.True(singleLinkedList.CompareToArray(new int[] { 1, 2, 3, 4 }));
        }

        [Fact]
        public void Using_Clear_On_Initialized_Array_Should_Return_Length_Of_One()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(4);

            singleLinkedList.Clear();

            Assert.Equal(0, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_ToArray_On_Empty_List_Should_Return_Empty_List()
        {
            Assert.Empty(singleLinkedList.ToArray());
        }

        [Fact]
        public void Using_ToArray_On_Initialized_Array_Should_Return_A_Valid_Array()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);

            Assert.Equal(new int[] { 1, 2, 3 }, singleLinkedList.ToArray());
        }

        [Fact]
        public void Using_Delete_On_Empty_List_Should_Return_False()
        {
            Assert.False(singleLinkedList.DeleteItem(10));
        }

        [Fact]
        public void Using_Delete_On_List_With_Only_One_Item_Should_Clear_The_List()
        {
            singleLinkedList.Add(10);
            singleLinkedList.DeleteItem(10);


            Assert.Equal(0, singleLinkedList.GetLength());
        }

        [Fact]
        public void Using_Delete_On_Initialized_List_Should_Not_Mess_With_Item_Order_1()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.DeleteItem(3);


            Assert.True(singleLinkedList.CompareToArray(new int[] { 1, 2, 4 }));
        }

        [Fact]
        public void Using_Delete_On_Initialized_List_Should_Not_Mess_With_Item_Order_2()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.DeleteItem(4);


            Assert.Equal(3, singleLinkedList.LastOrNull());
        }

        [Fact]
        public void Using_Delete_On_Initialized_List_Should_Not_Mess_With_Item_Order_3()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.DeleteItem(1);


            Assert.Equal(2, singleLinkedList.FirstOrNull());
        }

        [Fact]
        public void Using_Delete_On_Initialized_List_Should_Not_Mess_With_Item_Order_4()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.DeleteItem(1);


            Assert.True(singleLinkedList.CompareToArray(new int[] { 2, 3, 4 }));
        }

        [Fact]
        public void Using_Delete_On_Initialized_List_Should_Not_Mess_With_Item_Order_5()
        {
            singleLinkedList.Add(1);
            singleLinkedList.Add(2);
            singleLinkedList.Add(3);
            singleLinkedList.Add(4);
            singleLinkedList.DeleteItem(2);


            Assert.True(singleLinkedList.CompareToArray(new int[] { 1, 3, 4 }));
        }
    }
}

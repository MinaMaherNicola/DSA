using DSA.Algorithms.SearchingAlgorithmsNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Tests.Algorithms.SearchingAlgorithmsTestsNS
{
    public class SearchingAlgorithmsTests
    {
        [Fact]
        public void Calling_BinarySearch_On_Element_That_Doesnt_Exist_Should_Return_Null()
        {
            Assert.Null(SearchingAlgorithms.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 7));
        }

        [Fact]
        public void Calling_BinarySearch_On_Existing_Element_Should_Return_Its_Index_0()
        {
            Assert.Equal(5, SearchingAlgorithms.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 6));
        }

        [Fact]
        public void Calling_BinarySearch_On_Existing_Element_Should_Return_Its_Index_1()
        {
            Assert.Equal(0, SearchingAlgorithms.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 1));
        }

        [Fact]
        public void Calling_BinarySearch_On_Existing_Element_Should_Return_Its_Index_2()
        {
            Assert.Equal(2, SearchingAlgorithms.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3));
        }

        [Fact]
        public void Calling_BinarySearch_On_Existing_Element_Should_Return_Its_Index_3()
        {
            Assert.Equal(4, SearchingAlgorithms.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 5));
        }

        [Fact]
        public void Calling_BinarySearch_On_Existing_Element_Should_Return_Its_Index_4()
        {
            Assert.Equal(1, SearchingAlgorithms.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 2));
        }
    }
}

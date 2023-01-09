using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms.SearchingAlgorithmsNS
{
    public static class SearchingAlgorithms
    {
        public static int? BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (right + left) / 2;

                if (arr[mid] == target) return mid;

                if (arr[mid] > target) right = mid - 1;
                if (arr[mid] < target) left = mid + 1;
            }
            return null;
        }
    }
}

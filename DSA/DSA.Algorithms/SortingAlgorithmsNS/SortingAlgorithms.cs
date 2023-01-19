using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms.SortingAlgorithmsNS
{
    public static class SortingAlgorithms
    {
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallestIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallestIndex]) smallestIndex = arr[j];
                }
                (arr[i], arr[smallestIndex]) = (arr[smallestIndex], arr[i]);
            }
            return arr;
        }
    }
}

// stuff to implement:
// bubble sort
// insertion sort
// merge sort
// heap sort
// quick sort
// radix sort
// count sort
// bucket sort

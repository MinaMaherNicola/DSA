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

        public static int[] BubbleSort(int[] arr)
        {
            int maxLength = arr.Length;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int left = 0, right = 1;
                while (right < maxLength)
                {
                    if (arr[left] > arr[right]) (arr[left], arr[right]) = (arr[right], arr[left]);
                    left++;
                    right++;
                }
            }
            return arr;
        }

        private static void PrintArr(int[] arr)
        {
            foreach (int i in arr) Console.Write(i + " ");

            Console.WriteLine();
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

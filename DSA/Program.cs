using DSA.Algorithms.SortingAlgorithmsNS;

SortingAlgorithms.QuickSort(new int[] { 5, 1, 9, 2, 6 }).ToList().ForEach(x => Console.Write($"{x}, "));
System.Console.WriteLine();
SortingAlgorithms.QuickSort(new int[] { 3, 1, 1, 2, 1 }).ToList().ForEach(x => Console.Write($"{x}, "));
Console.WriteLine();
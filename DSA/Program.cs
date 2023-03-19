
using DSA.DataStructures.LinkedLists.SingleLinkedListNS;

SingleLinkedList<int> list = new();
list.AddStart(5);
list.AddStart(4);
list.AddStart(3);
list.AddStart(2);
list.AddStart(1);

int[] arr = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine(list.ToString());

Console.WriteLine(Enumerable.SequenceEqual(arr, list));

using DSA.DataStructures.LinkedLists.DoubleLinkedListNS;
using DSA.DataStructures.LinkedLists.SingleLinkedListNS;

DoubleLinkedList<int> list = new();
list.AddEnd(5);
list.AddEnd(4);
list.AddEnd(3);
list.AddEnd(2);
list.AddEnd(1);

int[] arr = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine(list.ToString());

System.Console.WriteLine(list.Any(x => x == 5));
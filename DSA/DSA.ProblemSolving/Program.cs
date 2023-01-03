using DSA.ProblemSolving.LeetCode._2.AddTwoNumbers;

namespace DSA.ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new(9);
            ListNode l2 = new(1, new(9, new(9, new(9, new(9, new(9, new(9, new(9, new(9, new(9))))))))));

            AddTwoNumbersSolution h5a = new();
            h5a.AddTwoNumbers(l1, l2);
        }
    }
}
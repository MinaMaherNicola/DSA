using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms.PracticeGround
{
    public static class Practice
    {
        public static int Factorial(int n)
        {
            if (n == 1) return n;
            return n * Factorial(n - 1);
        }

        public static int AddUpTo(int n)
        {
            if (n == 1) return n;
            return n + AddUpTo(n - 1);
        }

        public static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}

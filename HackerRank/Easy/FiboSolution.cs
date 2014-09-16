using System.Collections.Generic;

namespace HackerRank.Easy
{
    public class FiboSolution
    {
        public string Output { get; private set; }

        public FiboSolution(string input)
        {
            long n = long.Parse(input);

            Output = fibs.Contains(n) ? "IsFibo" : "IsNotFibo";
        }

        static Dictionary<int, long> fib_cache = new Dictionary<int, long>();
        static HashSet<long> fibs;
        static readonly int LIMIT = 60;

        static long max = 0;

        static FiboSolution()
        {
            //build caches
            FibonacciMemorization(LIMIT);
            fibs = new HashSet<long>(fib_cache.Values);
        }

        static void FibonacciMemorization(int n)
        {
            if (n == 0)
            {
                fib_cache.Add(0, 0);
                return;
            }

            if (n == 1)
            {
                fib_cache.Add(1, 1);
                return;
            }

            long fib;
            if (!fib_cache.TryGetValue(n - 2, out fib))
                FibonacciMemorization(n - 2);

            if (!fib_cache.TryGetValue(n - 1, out fib))
                FibonacciMemorization(n - 1);

            //Store the ${n}^{th}$ Fibonacci no. in memory & use previous results.
            fib_cache.Add(n, fib_cache[n - 1] + fib_cache[n - 2]);
        }

        //static int Fibonacci(int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    else if (n == 1)
        //        return 1;
        //    else
        //        return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}
    }
}

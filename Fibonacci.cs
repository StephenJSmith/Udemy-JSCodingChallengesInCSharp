using System.Collections.Generic;

namespace CodingChallenge
{
    public class Fibonacci
    {
        private IDictionary<int, int> _fib = new Dictionary<int, int>();

        public int ExecuteIteratively(int nth)
        {
            if (nth <= 1)
            {
                return nth;
            }

            var nrs = new List<int>{ 0, 1 };

            for (var i = 2; i <= nth; i++)
            {
                var nr = nrs[i - 1] + nrs[i - 2];
                nrs.Add(nr);
            }

            return nrs[nth];
        }

        public int ExecuteRecursively(int nth)
        {
            if (nth <= 1)
            {
                return nth;
            }

            var a = ExecuteRecursively(nth - 1);
            var b = ExecuteRecursively(nth - 2);

            return a + b;
        }

        public int ExecuteRecursivelyWithMemoisation(int nth)
        {
            if (nth <= 1)
            {
                return nth;
            }

            var a = GetCachedFib(nth - 1);
            var b = GetCachedFib(nth - 2);

            return a + b;
        }

        private int GetCachedFib(int key)
        {
            if (!_fib.ContainsKey(key))
            {
                var value = ExecuteRecursivelyWithMemoisation(key);
                _fib[key] = value;
            }

            return _fib[key];
        }
    }
}

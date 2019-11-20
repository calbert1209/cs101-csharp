using System;

namespace cs101
{
    public class DisjointSet
    {
        private int _n;
        private int[] _roots;
        private int[] _sizes;
        public DisjointSet(int n)
        {
            _n = n;
            ComponentCount = n;
            _roots = new int[n];
            _sizes = new int[n];
            for (int i = 0; i < n; i++)
            {
                _roots[i] = i;
                _sizes[i] = 1;
            }
        }

        public int ComponentCount { get; private set; }

        public int Find(int x)
        {
            if (x > _n)
            {
                throw new System.ArgumentOutOfRangeException($"{x} > _n of {_n}");
            }
            if (_roots[x] != x)
            {
                _roots[x] = Find(_roots[x]);
            }
            return _roots[x];
        }

        public void Union(int a, int b)
        {
            if (a > _n || b > _n)
            {
                throw new ArgumentOutOfRangeException($"a ({a}) or b ({b}) > _n ({_n}) ");
            }

            var rootA = Find(a);
            var rootB = Find(b);
            if (rootA == rootB)
            {
                return;
            }

            if (_sizes[rootA] > _sizes[rootB])
            {
                _roots[rootA] = rootB;
                _sizes[rootB] += _sizes[rootA];
                _sizes[rootA] = 0;
            }
            else
            {
                _roots[rootB] = rootA;
                _sizes[rootA] += _sizes[rootB];
                _sizes[rootB] = 0;
            }
            ComponentCount -= 1;
        }
    }
}
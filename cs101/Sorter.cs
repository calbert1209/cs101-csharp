using System;
using System.Collections.Generic;
using System.Text;

namespace cs101
{
    public static class ListExtensions
    {
        public static IList<int> Slice(this IList<int> list, int start, int end)
        {
            var slice = new List<int>();
            for (var i = start; i < end; i++)
            {
                slice.Add(list[i]);
            }
            return slice;
        }
    }
    public class Sorter
    {        
        public static IList<int> MergeSort(IList<int> unsorted)
        {
            var count = unsorted.Count;
            if (count <= 1)
            {
                return unsorted;
            }

            var midpoint = count / 2;
            var left = MergeSort(unsorted.Slice(0, midpoint));
            var right = MergeSort(unsorted.Slice(midpoint, count));

            var lQueue = new Queue<int>(left);
            var rQueue = new Queue<int>(right);

            var output = new List<int>();
            while(lQueue.Count > 0 && rQueue.Count > 0)
            {
                if (lQueue.Peek() < rQueue.Peek())
                {
                    output.Add(lQueue.Dequeue());
                }
                else
                {
                    output.Add(rQueue.Dequeue());
                }
            }

            output.AddRange(lQueue);
            output.AddRange(rQueue);
            return output;
        }
    }
}

using System;

namespace CSharp_Sorts
{
    internal class ArrayAssertions
    {
        public static bool IsInSortedOrder<T>(T[] arr) 
            where T : IComparable
        {
            if (arr.Length == 0) return true;

            T prev = arr[0];

            for (var x = 1; x < arr.Length; x++)
            {
                var cur = arr[x];

                if (prev != null && 
                    prev.CompareTo(cur) > 0)
                {
                    return false;
                }

                prev = arr[x];
            }
            return true;
        }
    }
}
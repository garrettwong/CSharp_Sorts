using CSharp_Sorts.Sorts;
using System;

namespace CSharp_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[]
            {
                1, 7, 16, 3, 39, 20, 21, 4, 6, 1, 2, 3
            };

            var negativeArray = new int[]
            {
                4, 6, -1, -2, -3, -9, 0
            };

            ISort sorter = new Quicksort();
            sorter.Sort(intArray);
            sorter.Sort(negativeArray);

            if (!ArrayAssertions.IsInIncreasingOrder(intArray))
            {
                throw new SystemException("Is not ordered!");
            }

            ArrayAssertions.Print(intArray);
            ArrayAssertions.Print(negativeArray);
        }
    }
}

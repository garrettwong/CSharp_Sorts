using System;

namespace CSharp_Sorts
{
    internal class ArrayAssertions
    {
        public static bool IsInIncreasingOrder(int[] intArray)
        {
            if (intArray.Length == 0) return true;

            int? prev = null;

            for (var x = 0; x < intArray.Length; x++)
            {
                var val = intArray[x];
                if (prev != null && prev > val)
                {
                    return false;
                }

                prev = intArray[x];
            }
            return true;
        }
        public static void Print(int[] intArray)
        {
            for (var x = 0; x < intArray.Length; x++)
            {
                Console.Write(intArray[x] + ", ");
            }

            Console.WriteLine();
        }
    }
}
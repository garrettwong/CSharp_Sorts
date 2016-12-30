using System;

namespace CSharp_Sorts
{
    internal class ArrayPrint
    {
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
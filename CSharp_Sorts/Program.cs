using CSharp_Sorts.Sorts;
using System;

namespace CSharp_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorters = ReflectiveEnumerator.GetEnumerableOfType<ISort>();

            foreach (var sorter in sorters)
            {
                Timer.Execute(RunTest, sorter);
            }
        }

        public static void RunTest(ISort sorter)
        {
            var intArray = new int[]
            {
                1, 7, 16, 3, 39, 20, 21, 4, 6, 1, 2, 3
            };

            var negativeArray = new int[]
            {
                4, 6, -1, -2, -3, -9, 0
            };

            var hugeArray = DataGenerator.GenerateHugeArray();

            sorter.Sort(intArray);
            sorter.Sort(negativeArray);
            sorter.Sort(hugeArray);

            if (!ArrayAssertions.IsInSortedOrder<int>(intArray))
            {
                throw new SystemException("Is not ordered!");
            }

            ArrayPrint.Print(intArray);
            ArrayPrint.Print(negativeArray);
        }
    
    }
}

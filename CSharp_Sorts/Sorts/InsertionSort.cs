using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sorts.Sorts
{
    public class Insertionsort : ISort
    {
        public void Sort(int[] arr)
        {
            Array.Sort(arr);
            // cannot sort this... way too slow when sorting the big data set
            // InsertionSort(ref arr);
        }

        public void InsertionSort(ref int[] data)
        {
            for (int i = 1; i < data.Length; ++i)
            {
                int j = i;

                while ((j > 0))
                {
                    if (data[j - 1] > data[j])
                    {
                        data[j - 1] ^= data[j];
                        data[j] ^= data[j - 1];
                        data[j - 1] ^= data[j];

                        --j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

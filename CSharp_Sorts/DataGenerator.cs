using CSharp_Sorts.Sorts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace CSharp_Sorts
{
    public class DataGenerator
    {
        public static int[] GenerateHugeArray()
        {
            int n = 7654321; // 7 million

            Random r = new Random();
            r.Next(0, n);

            int[] set = new int[n];
            for (var i = 0; i < n; i++)
            {
                set[i] = r.Next(0, n);
            }

            return set;
        }
    }

}
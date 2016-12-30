using System;
using System.Diagnostics;

namespace CSharp_Sorts
{
    public static class Timer
    {
        public static void Execute<T>(Action<T> func, T instance)
        {
            Console.WriteLine($"Sorter: {instance.GetType()}");

            Stopwatch stopwatch = Stopwatch.StartNew(); //creates and start the instance of Stopwatch

            func(instance);

            stopwatch.Stop();

            Console.WriteLine($"Time to sort both datasets: {stopwatch.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }
    }
}
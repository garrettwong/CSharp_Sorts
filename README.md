
# CSharp_Sorts

> A test harness project that dynamically runs sorts which implement the ISort interface.

## Sorts
* Quicksort
* OptimizedQuicksort
* Mergesort

## Getting Started
* Use 'F5' to run program.  This is a console application.  

## Code
```
static void Main(string[] args)
{
    IEnumerable<ISort> sorters = ReflectiveEnumerator.GetEnumerableOfType<ISort>();

    foreach (ISort sorter in sorters)
    {
        Timer.Execute(RunTest, sorter);
    }
}


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

```

# CSharp_Sorts

> A test harness project that dynamically runs sorts which implement the ISort interface.

## Sorts
* Quicksort
* OptimizedQuicksort
* Mergesort
* .NET Default Sort
* Introsort


## Getting Started
* Use 'F5' to run program.  This is a console application.  

## Code
```csharp
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

## Results - Console Output

```
Sorter: CSharp_Sorts.Sorts.DotNetArraySort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 1356ms

Sorter: CSharp_Sorts.Sorts.Insertionsort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 1481ms

Sorter: CSharp_Sorts.Sorts.Introsort2
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 2693ms

Sorter: CSharp_Sorts.Sorts.Introsort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 8022ms

Sorter: CSharp_Sorts.Sorts.Radixsort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 3830ms

Sorter: CSharp_Sorts.Sorts.OptimizedQuicksort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 3031ms

Sorter: CSharp_Sorts.Sorts.Mergesort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 4669ms

Sorter: CSharp_Sorts.Sorts.Quicksort
1, 1, 2, 3, 3, 4, 6, 7, 16, 20, 21, 39,
-9, -3, -2, -1, 0, 4, 6,
Time to sort both datasets: 2620ms
```
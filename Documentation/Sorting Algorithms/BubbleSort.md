# Bubble Sort

Bubble sorting is one of the simplest sortings commonly used to teach students. The principle of ascending bubble sorting is quite simple, we go through the array by moving the largest elements to the end of the array. Bubble sorting is a stable sorting algorithm. We swap elements only if one element (say `A`) is smaller than another (say `B`). If `A` is equal to `B`, we do not swap them, so the relative order between equal elements is preserved.

Here is the video of the bubble sorting example:

![Bubble Sort](./Media/bubble-sort.gif)


|              	| Time complexity 	| Space complexity 	|
|--------------	|-----------------	|------------------	|
| Worst case   	| O(N^2)          	| O(1)             	|
| Average case 	| O(N^2)          	| O(1)             	|
| Best case    	| O(N)            	| O(1)             	|


Below is the C# implementation of the bubble sorting algorithm:

```c#
public sealed class BubbleSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        int n = array.Count;
        Comparer<T> comparer = Comparer<T>.Default;

        for (int i = 0; i < n; i++)
        {
            bool swapPerformed = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (comparer.Compare(array[j], array[j + 1]) > 0)
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    swapPerformed = true;
                }
            }

            // if there were no swaps, array is sorted
            if (!swapPerformed)
            {
                break;
            }
        }
    }
}
```

We use `swapPerformed` to check if there were any swaps. If there were no swaps, it means that the array is already sorted and we should break the loop.

The `ISorter<T>` interface is declared as follows:

```c#
public interface ISorter<T> where T : IComparable<T>
{
    void Sort(IList<T?> array);
}
```

## Source code reference

[Bubble Sort algorithm implementation](../../Algorithms/SortingAlgorithms/BubbleSorter.cs)

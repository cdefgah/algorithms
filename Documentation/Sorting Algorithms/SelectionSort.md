# Selection Sort

The algorithm of sorting by selection is not a stable sorting algorithm, which consists of searching the raw slice of an array or list for the minimum value and then exchanging this value with the first element of the raw slice (minimum search and permutation). The next step is to reduce the raw slice by one element.

Here is the video of the selection sorting example:

![Insertion Sort](./Media/selection-sort.gif)


|              	| Time complexity 	| Space complexity 	|
|--------------	|-----------------	|------------------	|
| Worst case   	| O(N^2)          	| O(1)             	|
| Average case 	| O(N^2)          	| O(1)             	|
| Best case    	| O(N^2)           	| O(1)             	|


Below is the C# implementation of the selection sorting algorithm:

```c#
public sealed class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        int n = array.Count;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimal element in unsorted (sub)-array and keep its index
            // assume the minimal element is the first element.
            int minValueIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (Comparer<T>.Default.Compare(array[j], array[minValueIndex]) < 0)
                {
                    minValueIndex = j;
                }
            }

            // Swap the found minimum element 
            // with the first element in unsorted (sub)-array.
            if (minValueIndex != i)
            {
                (array[i], array[minValueIndex]) = (array[minValueIndex], array[i]);
            }
        }
    }
}
```

The `ISorter<T>` interface is declared as follows:

```c#
public interface ISorter<T> where T : IComparable<T>
{
    void Sort(IList<T?> array);
}
```

## Source code reference

[Selection Sort algorithm implementation](../../Algorithms/SortingAlgorithms/SelectionSorter.cs)

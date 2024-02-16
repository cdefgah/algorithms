# Insertion Sort

Insertion Sorting is a sorting algorithm in which the elements of the input sequence are considered one at a time, and each newly arriving element is placed in an appropriate position among the previously ordered elements. Insertion sorting is a stable sorting algorithm. In selection sorting, we swap the order of any two items only if the item on the right is smaller than the item on the left. Therefore, the order of two equivalent items is always preserved in insertion sorting.

Here is the video of the insertion sorting example:

![Insertion Sort](./Media/insertion-sort.gif)


|              	| Time complexity 	| Space complexity 	|
|--------------	|-----------------	|------------------	|
| Worst case   	| O(N^2)          	| O(1)             	|
| Average case 	| O(N^2)          	| O(1)             	|
| Best case    	| O(N)            	| O(1)             	|


Below is the C# implementation of the insertion sorting algorithm:

```c#
public sealed class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        // We start with 1, because we compare the current element with the previous one.
        for (int i = 1; i < array.Count; i++)
        {
            T? currentValue = array[i];
            int index = i;

            // Find the position where currentValue should be inserted.
            while (index > 0 && Comparer<T>.Default.Compare(array[index - 1], currentValue) > 0)
            {
                // Shift values to the right.
                array[index] = array[index - 1];
                index--;
            }

            // Insert currentValue at the found position.
            array[index] = currentValue;
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

[Insertion Sort algorithm implementation](../../Algorithms/SortingAlgorithms/InsertionSorter.cs)

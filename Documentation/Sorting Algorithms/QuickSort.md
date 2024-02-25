# Quick Sort

Quicksort is one of the most efficient sorting algorithms. It works by splitting an array (partition) into smaller ones and swapping the smaller ones based on a comparison with the selected pivot element. Most implementations of quicksort are not stable, i.e. the relative order of the same sort elements is not preserved.

There are two different partitioning schemes that can be used in the implementation of the quicksort algorithm: Hoare and Lomuto. The Hoare and Lomuto partitioning schemes are two different methods used in the implementation of the quicksort algorithm.


## Implementation

There's base class to implement quick sorting algorithm for different partitioning schemes.

```c#
public abstract class QuickSorterBase<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        QuickSort(array, 0, array.Count - 1);
    }

    private void QuickSort(IList<T?> array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    protected abstract int Partition(IList<T?> array, int low, int high);
}
```

where `ISorter` is an interface that defines the `Sort` method:

```c#
public interface ISorter<T> where T : IComparable<T>
{
    void Sort(IList<T?> array);
}
```

Let's consider two derived classes that implement Lomuto and Hoare partitioning schemes.

### Sorting with Lomuto partitioning scheme implementation

Algorithm: It works by choosing a pivot (usually the last element in the array) and maintaining an index to store the position of the smaller (or equal) element found so far. As it scans the array from beginning to end, it swaps elements to ensure that at the end, all elements smaller than the pivot are to its left and all larger elements are to its right. Lomuto's partition is easier to understand and implement, which is why it is often found in educational materials.

Performance: Typically less efficient than Hoare's partition because it does more swaps and tends to create unbalanced partitions, especially if the pivot is not near the median, leading to worst-case performance of `O(N^2)` in already sorted arrays or arrays with many duplicates.

Pivot selection: The pivot is typically selected as the last element, which can lead to poor performance for certain inputs.

Recursion handling: The element at the pivot index is at its final sorted position after partitioning. The recursive calls are made for the ranges `(low, p - 1)` and `(p + 1, high)`, where `p` is the pivot index.

```c#
public sealed class QuickSorterLomuto<T> : QuickSorterBase<T> where T : IComparable<T>
{
   protected override int Partition(IList<T?> array, int low, int high)
    {
        T? pivot = array[high];
        int i = (low - 1);

        Comparer<T> comparer = Comparer<T>.Default;

        for (int j = low; j < high; j++)
        {
            if (comparer.Compare(array[j], pivot) < 0)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        // Move pivot element to its corrected position
        int correctedPivotIndex = i + 1;
        (array[high], array[correctedPivotIndex]) = (array[correctedPivotIndex], array[high]);

        return correctedPivotIndex;
    }
}
```

Let's look at the `Partition` method for the `Lomuto` partitioning scheme step by step.

Suppose we have an initial array with five elements: `[9, 3, 5, 18, 7]`.

Step 1. The pivot element is set to the last element in the array: `7`;

Step 2. The index `i` is set to `-1` because `low == 0`;

For-loop, we use it to find the correct index for the pivot element in the array, for `j = 0, 1, 2, 3`.

* #1: `j=0`, `array[j] > pivot`, going to next iteration; 
* #2: `j=1`, `array[j] < pivot`, increment `i`, from `-1` to `0`, and swap `array[i]` and `array[j]` => (array[0] and array[1]), as a result we have array: `[3, 9, 5, 18, 7]`;
* #3: `j=2`, `array[j] < pivot`, increment `i`, from `0` to `1`, and swap `array[i]` and `array[j]` => (array[1] and array[2]), as a result we have array: `[3, 5, 9, 18, 7]`;
* #4: `j=3`, `array[j] > pivot`, going to next iteration;

Step 3: `correctedPivotIndex = i + 1`, as a result we have `correctedPivotIndex = 2`;

Step 4: Swapping `array[high]` (array[4]) with `array[correctedPivotIndex]` (array[2]), and the result is array: `[3, 5, 7, 18, 9]`;

Step 5: Returning `correctedPivotIndex`, it is equal to `2`;

Then the following code is being executed:

```c#
QuickSort(array, low, pivotIndex - 1);
QuickSort(array, pivotIndex + 1, high);
```

We call `QuickSort` with the following parameters:

```c#
QuickSort(array, 0, 2 - 1); // to process sub-array [3, 5]
QuickSort(array, 2 + 1, 4);  // to process sub-array [18, 9]
```

Let's examine this call step by step: 

```c#
QuickSort(array, 0, 2 - 1); // to process sub-array [3, 5]
```

Step 6: low < high, continue running the method;

Step 7: 

```c#
int pivotIndex = Partition(array, low, high); // low = 0, high = 1 
```

Step into `Partition` method invocation.

Step 8: `pivot = array[high]` => `pivot = array[1]` => `pivot = 5`;

Step 9: `i = low - 1` => `i = 0 - 1` => `i = -1`;

Now, entering for-loop

```c#
 for (int j = low; j < high; j++) // j = 0, j < 1, j++
 {
     if (Comparer<T>.Default.Compare(array[j], pivot) < 0)
     {
         i++;
         (array[i], array[j]) = (array[j], array[i]);
     }
 }
```

We'll perform single iteration, for `j = 0`;

* #1: `j=0`, `array[j] < pivot` => `3 < 5` => `i++` => `i == 0`, swapping `array[i]` with `array[j]`, as `i` and `j` equal to `0`, this swap does not change the array;

Step 10: `correctedPivotIndex = i + 1` => `correctedPivotIndex = 0 + 1` => `correctedPivotIndex = 1`;

Step 11: Returning `correctedPivotIndex` => returning `1`;

Step 12: `pivotIndex` mentioned on Step 7 will be equal to `1`;

Step 13: Attempting to call:

```c#
QuickSort(array, low, pivotIndex - 1); // low = 0, pivotIndex - 1 => 0;
QuickSort(array, pivotIndex + 1, high); // pivotIndex + 1 => 2, high = 1;
```

Since we have 

```c#
if (low < high)
{
    // process sub-arrays
}
```

condition, both calls will exit without further processing;

Now, let's examine this call step by step (mentioned on Step 5):

```c#
QuickSort(array, 2 + 1, 4);  // to process sub-array [18, 9]
```

Step 14: Initial condition is true (`low < high` => `3 < 4`), processing further;

Step 15:

```c#
  int pivotIndex = Partition(array, low, high); // low = 3, high = 4 
```

Step into `Partition` method invocation.

Step 16: `pivot = array[high]` => `pivot = array[4]` => `pivot = 9`;

Step 17: `i = low - 1` => `i = 3 - 1` => `i = 2`;

Step 19: Now, entering for-loop

```c#
 for (int j = low; j < high; j++) // j = 3, j < 4, j++
 {
     if (Comparer<T>.Default.Compare(array[j], pivot) < 0)
     {
         i++;
         (array[i], array[j]) = (array[j], array[i]);
     }
 }
```

We'll perform single iteration, for `j = 3`;

* #1: `j=3`, `array[j] > pivot` => `18 > 9` => skipping the iteration;

Step 20: `correctPivotIndex = i + 1` => `correctPivotIndex = 2 + 1` => `correctPivotIndex = 3`;

Step 21: Swap for `array[high]` with `array[correctPivotIndex]` => swap for `array[4]` and `array[3]` => `[3, 5, 7, 18, 9]` => `[3, 5, 7, 9, 18]`;

Step 22: Return `correctPivotIndex` => return `3`;

Step 23: Attempting to call:

```c#
QuickSort(array, low, pivotIndex - 1); // low = 3, pivotIndex - 1 => 2; this call will exit without further processing;
QuickSort(array, pivotIndex + 1, high); // pivotIndex + 1 => 4, high = 4; this call will exit without further processing;
```

And we have sorted array: `[3, 5, 7, 9, 18]`.


### Sorting with Hoare partitioning scheme implementation

To be done...



## Source code references

* [QuickSorterBase class](../../Algorithms/SortingAlgorithms/Base/QuickSorterBase.cs)
* [QuickSorterLomuto class](../../Algorithms/SortingAlgorithms/QuickSorterLomuto.cs)
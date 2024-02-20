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

```c#
public sealed class QuickSorterLomuto<T> : QuickSorterBase<T> where T : IComparable<T>
{
   protected override int Partition(IList<T?> array, int low, int high)
    {
        T? pivot = array[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (Comparer<T>.Default.Compare(array[j], pivot) < 0)
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
* #2: `j=1`, `array[j] < pivot`, increment `i`, from `-1` to `0`, and swap `array[i]` and `array[j]` (array[0] and array[1]), as a result we have array: `[3, 9, 5, 18, 7]`;
* #3: `j=2`, `array[j] < pivot`, increment `i`, from `0` to `1`, and swap `array[i]` and `array[j]` (array[1] and array[2]), as a result we have array: `[3, 5, 9, 18, 7]`;
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

Step 8: `pivot = array[high]`, `pivot = array[1]`, `pivot = 5`;
Step 9: `i = low - 1`, `i = 0 - 1`, `i = -1`;


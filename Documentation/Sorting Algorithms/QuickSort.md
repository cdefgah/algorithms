# Quick Sort

Quicksort is one of the most efficient sorting algorithms. It works by splitting an array (partition) into smaller ones and swapping the smaller ones based on a comparison with the selected pivot element. Most implementations of quicksort are not stable, i.e. the relative order of the same sort elements is not preserved.

There are two different partitioning schemes that can be used in the implementation of the quicksort algorithm: Hoare and Lomuto.

## Implementation

### Implementations with Lomuto partitioning scheme

Algorithm: It works by choosing a pivot (usually the last element in the array) and maintaining an index to store the position of the smaller (or equal) element found so far. As it scans the array from beginning to end, it swaps elements to ensure that at the end, all elements smaller than the pivot are to its left and all larger elements are to its right. Lomuto's partition is easier to understand and implement, which is why it is often found in educational materials.

Performance: Typically less efficient than Hoare's partition because it does more swaps and tends to create unbalanced partitions, especially if the pivot is not near the median, leading to worst-case performance of `O(N^2)` in already sorted arrays or arrays with many duplicates.

Pivot selection: The pivot is typically selected as the last element, which can lead to poor performance for certain inputs.

* [Recursive implementation with Lomuto partitioning scheme](./QuickSortLomutoRecursive.md)

* [Non-Recursive implementation with Lomuto partitioning scheme](./QuickSortLomutoNonRecursive.md)


### Implementations with Hoare partitioning scheme

To be done

* [Recursive implementation with Hoare partitioning scheme](./QuickSortHoareRecursive.md)
* [Non-Recursive implementation with Hoare partitioning scheme](./QuickSortHoareNonRecursive.md)

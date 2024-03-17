# Quick Sort

Quicksort is one of the most efficient sorting algorithms. It works by splitting an array (partition) into smaller ones and swapping the smaller ones based on a comparison with the selected pivot element. Most implementations of quicksort are not stable, i.e. the relative order of the same sort elements is not preserved.

There are two different partitioning schemes that can be used in the implementation of the quicksort algorithm: Hoare and Lomuto.

## Implementation

### Lomuto partitioning scheme

Algorithm: It works by choosing a pivot (usually the last element in the array) and maintaining an index to store the position of the smaller (or equal) element found so far. As it scans the array from beginning to end, it swaps elements to ensure that at the end, all elements smaller than the pivot are to its left and all larger elements are to its right. Lomuto's partition is easier to understand and implement, which is why it is often found in educational materials.

Performance: Typically less efficient than Hoare's partition because it does more swaps and tends to create unbalanced partitions, especially if the pivot is not near the median, leading to worst-case performance of `O(N^2)` in already sorted arrays or arrays with many duplicates.

#### Time Complexity

Best and Average Case Time Complexity: `O(NlogN)` when the pivot element are chosen to create balanced partitions.

Worst Case Time Complexity: `O(N^2)`: This occurs when the smallest or largest element is always chosen as the pivot, leading to highly unbalanced partitions, with one partition containing all the elements except the pivot.

#### Space Complexity

* Recursive: `O(N)` in the worst case due to the deep recursion stack.
* Non-Recursive (Iterative): `O(logN)` for the stack data structure used to simulate the recursive calls.

#### Source code reference

* [Recursive implementation with Lomuto partitioning scheme](../../Algorithms/SortingAlgorithms/QuickSorterLomutoRecursive.cs)
* [Non-recursive implementation with Lomuto partitioning scheme](../../Algorithms/SortingAlgorithms/QuickSorterLomutoNonRecursive.cs)


### Hoare partitioning scheme

Algorithm: Hoare's partitioning scheme works by initializing two indexes that start at either end, the two indexes move toward each other until an inversion is found (a smaller value on the left side and a larger value on the right side). When an inversion is found, the two values are swapped and the process is repeated.

#### Time Complexity

Best and Average Case Time Complexity: `O(NlogN)`.

Similar to Lomuto, the pivot splits the array in half, which results in a logarithmic number of partitions. Hoare's partitioning is generally more efficient than Lomuto's because it does fewer swaps and creates more balanced partitions.

Worst Case Time Complexity: `O(N^2)`. Like Lomuto, the worst case occurs when the pivot is the smallest or largest element, causing highly unbalanced partitions.

#### Space Complexity

* Recursive: `O(logN)` in the best and average case, but `O(N)` in the worst case due to the deep recursion stack.
* Non-Recursive (Iterative): `O(logN)` for the stack data structure used to simulate the recursive calls, `O(N)` for the worst case due to poor pivot choices.

#### Source code reference

* [Recursive implementation with Hoare partitioning scheme](../../Algorithms/SortingAlgorithms/QuickSorterHoareRecursive.cs)
* [Non-recursive implementation with Hoare partitioning scheme](../../Algorithms/SortingAlgorithms/QuickSorterHoareNonRecursive.cs)

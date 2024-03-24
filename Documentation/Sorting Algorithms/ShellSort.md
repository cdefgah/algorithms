# Shell Sort

Shell sort is an in-place comparison-based sorting algorithm that is a generalization of insertion sort. The main idea of Shell Sort is to allow swapping of distant elements first, then successively reduce the distance between the elements to be compared. By starting with distant elements, it can move some misplaced elements into position faster than a simple nearest neighbor swap. ShellSort is not a stable sorting algorithm, it does not guarantee that equal elements won't swap positions during the sorting process. 

## How Shell Sort Works:

1. __Initial Gap Selection__: The algorithm starts by sorting pairs of elements far apart from each other, then progressively reducing the gap between elements to be compared. The gaps are typically determined by a sequence known as the gap sequence. A common gap sequence is to start with a gap of approximately half the size of the list, then reduce the gap by half each time. However, many other gap sequences are possible, and the choice of sequence can affect performance.

2. __Gap Sorting__: During each pass, the list is sorted according to the current gap. This is similar to an insertion sort, but instead of comparing only adjacent elements, elements at the distance of the current gap are compared and swapped if necessary.

3. __Reducing the Gap__: After completing a pass, the gap is reduced (usually halved), and another pass is made over the array with the new gap. This continues until the gap is 1.

4. __Final Insertion Sort__: When the gap is reduced to 1, the algorithm performs a standard insertion sort (but by this time, the list is already fairly sorted, making the final pass much faster).


### Example:

Let's say we have an array `[13, 14, 3, 2]` and we start with an initial gap of 2.

* First Pass (gap = 2):
    * Compare and swap elements 2 positions apart.
    * `[3, 14, 13, 2]` (13 and 3 are swapped)

* Second Pass (gap = 1):
    * Perform a standard insertion sort.
    * `[2, 3, 13, 14]` (The list is now sorted)


## Time and space complexity

|              	| Time complexity 	| Space complexity 	|
|--------------	|-----------------	|------------------	|
| Worst case   	| O(N^2)          	| O(1)             	|
| Average case 	| O(N log N)       	| O(1)             	|
| Best case    	| O(N log N)       	| O(1)             	|


## Source code reference

[Shell Sort algorithm implementation](../../Algorithms/SortingAlgorithms/ShellSorter.cs)
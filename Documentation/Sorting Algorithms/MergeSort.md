# Merge Sort

Merge Sort is a divide-and-conquer sorting algorithm that divides the input array into two halves, sorts the two halves independently, and then merges the sorted halves to produce the sorted result. Merge Sort is a stable sort, which means that it preserves the relative order of equal elements. This can be important when sorting complex records with multiple fields.

## How Merge Sort Works:

__Divide__: The array is recursively split into two halves until each sub-array contains a single element or no elements (an array of a single element is considered sorted).

__Conquer__: Once the array is divided into single-element arrays, the merge process begins. Two adjacent sub-arrays are merged into a sorted array.

__Combine__: The sorted sub-arrays are continually merged back together until a single sorted array is obtained.


### Detailed Explanation:

__Base Case__: If the array length is 1 or 0, it is already sorted, and no action is needed.

__Recursive Case__: If the array length is greater than 1, it is split into two halves. The algorithm is then called recursively on both halves.

__Merge__: Two sorted arrays are combined into one sorted array. This is done by comparing the first elements of each array and moving the smaller element into the new array, repeating this process until all elements from both arrays are merged.


## Time and space complexity

|              	| Time complexity 	| Space complexity 	|
|--------------	|-----------------	|------------------	|
| Worst case   	| O(N log N)      	| O(N)             	|
| Average case 	| O(N log N)      	| O(N)             	|
| Best case    	| O(N log N)      	| O(N)             	|

The time complexity of Merge Sort is `O(N log N)` in all cases because the array is always divided into two halves (which gives the `log N` part), and the merging of N elements takes `O(N)` time.


## Source code reference

[Merge Sort algorithm implementation](../../Algorithms/SortingAlgorithms/MergeSorter.cs)
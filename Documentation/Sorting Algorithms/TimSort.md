# TimSort Algorithm

TimSort is a hybrid sorting algorithm derived from merge sort and insertion sort, designed to perform well on many kinds of real-world data. It was implemented by Tim Peters in 2002 for use in the Python programming language, and has since been adopted in other languages.

TimSort works as follows:

* The array is divided into small blocks known as `runs`. Typically, the size of a run may be 32 or 64 elements, but this can vary depending on the size of the array.
* Each run is sorted using insertion sort individually.
* These sorted runs are then merged together using an algorithm similar to merge sort.

## Time and space complexity

|              	| Time complexity 	| Space complexity 	|
|--------------	|-----------------	|------------------	|
| Worst case   	| O(N log N)      	| O(N)             	|
| Average case 	| O(N log N)       	| O(N)             	|
| Best case    	| O(N)           	| O(N)             	|


## Source code reference

[TimSort algorithm implementation](../../Algorithms/SortingAlgorithms/TimSorter.cs)

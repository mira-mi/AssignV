# AssignV

This folder consists of six different algorithms that all do the same thing, they all sort data
## In this folder, there is:

 - Bubble Sort: starts at the beginning of an array and swaps the first two elements if the first is greater than the second. Moving to the next pair, the same comparison is made.
Runtime: O(n2) average and worst case
Memory: O(1)

- Insertion Sort: a simple sorting algorithm that builds the final sorted set one item at a time. It is efficient on small data sets but is much less efficient on large sets than quicksort, heapsort, or merge sort. 
Runtime: best case is O(n), and worst case is O(n2)
Memory: O(1) to O(n)

- Selection Sort: an in-place comparison sorting algorithm. It is inefficient on large lists, and generally performs worse than insertion sort. 
Runtime: O(n2) average and worst case
Memory: O(1)

- Heao Sort: a comparison-based sort-in-place algorithm that takes no extra storage. It is often described as an improved selection sort. It has an O(n log n) run time. 
Asymptotically O(n log n) is the fastest possible for an algorithm that sorts by using comparisons (although quicksort usually runs a bit faster). 
Like selection sort: heapsort divides the input into sorted and unsorted areas.
Unlike selection sort: maintains the unsorted area in a heap data structure which allows the largest element in each step to be found more quickly.

- Quick Sort:  a  comparison-based sort-in-place divide-and-conquer strategy.
Divide-and-conquer means that a larger group is separated into smaller groups that can be more easily processed or handled.
The algorithm takes O(n log n) comparisons on average to sort n items. Worst case is O(n2).

- Merge Sort: In sorting n objects, merge sort has an average and worst-case performance of O(n log n).
"Like quicksort, mergesort uses a divide-and-conquer strategy.
Instead of picking a dividing item and splitting the items into two groups holding items that are larger and smaller than the dividing item, mergesort splits the items into two halves holding an equal number of items. It then recursively calls itself to sort the two halves.

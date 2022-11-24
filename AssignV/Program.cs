using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Timers;
using static System.Console;

namespace AssignV
{
     class Program
    {
        static double[] differentTimes = new double[6];
        public static System.Timers.Timer aTimer;

        public static ElapsedEventHandler OnTimedEvent { get; private set; }

        static void Main(string[] args)
        {
            string textFilePath = "score.text";
            string[] stringScores = File.ReadAllLines(textFilePath);
            int[] scores = Array.ConvertAll(stringScores, int.Parse);
            Bubblesort(scores);
            

            
        }
        public static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        #region BubbleSort
        /*BubbleSort 
         * Description: starts at the beginning of an array and swaps the first two elements if the first is greater than the second. 
         * Moving to the next pair, the same comparison is made.
         * Best Case: O(n)
         * Worst Case: O(n^2)
         * puesdocode:
         * Bubblesort(Data: values[])
    // Repeat until the array is sorted.
    Boolean: not_sorted = True
    While (not_sorted)
        // Assume we won't find a pair to swap.
        not_sorted = False
        // Search the array for adjacent items that are out of order.
        For i = 0 To <length of values> - 1

// See if items i and i - 1 are out of order.
            If (values[i] < values[i - 1]) Then
                // Swap them.
                Data: temp = values[i]
                values[i] = values[i - 1]
                values[i - 1] = temp
 
                // The array isn't sorted after all.
                not_sorted = True
            End If
        Next i
    End While
End Bubblesort 
         */

        static int[] Bubblesort(int[] array)
        {
            SetTimer();
            bool notSorted = true;
            while (notSorted)
            {
                notSorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        notSorted = true;
                    }
                }
            }
            
            aTimer.Stop();
            
            return array;
        }

        #endregion

        #region InsertionSort
        /*Description: a simple sorting algorithm that builds the final sorted set one item at a time. 
         * It is efficient on small data sets but is much less efficient on large sets than quicksort, heapsort, or merge sort. 
         * Best Case: 0(n)
         * Worst Case: 0(n^2)
         * Puesdocode:
         * Insertionsort(Data: values[])
   For i = 0 To <length of values> - 1
       // Move item i into position
       //in the sorted part of the array
       < Find  the first index j where
         j < i and values[j] > values[i].>
       <Move the item into position j.>
   Next i
End Insertionsort
         */
        static int[] Insertionsort(int[] array)
        {
            SetTimer();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        var temp = array[j - 1];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }


                }
            }
            aTimer.Stop();
            return array;
        }

        #endregion

        #region SelectionSort
        /*Description: an in-place comparison sorting algorithm. 
         * It is inefficient on large lists, and generally performs worse than insertion sort. 
         * Best Case: O(n)
         * Worst Case: 0(n^2)
         * Puesdocode:
         * Selectionsort(Data: values[])
    For i = 0 To <length of values> - 1
        // Find the item that belongs in position i.
        <Find the smallest item with index j >= i.>
        <Swap values[i] and values[j].>
    Next i
End Selectionsort  
         */

        static int[] Selectionsort(int[] array)
        {
            SetTimer();
            int temp, smallest;
            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

            aTimer.Stop();
            return array;

        }

        #endregion

        #region HeapSort
        /*Description: a comparison-based sort-in-place algorithm that takes no extra storage.
         * It is often described as an improved selection sort.
         * Best Case: O(n log n)
         * Worst Case: 0(n log n)
         * Puesdocode:
         * Heapsort(Data: values)
    <Turn the array into a heap.>
 
    For i = <length of values> - 1 To 0 Step -1
        // Swap the root item and the last item.
        Data: temp = values[0]
        values[0] = values[i]
        values[i] = temp
 
        <Consider the item in position i to be removed from the heap,
         so the heap now holds i - 1 items. Push the new root value
         down into the heap to restore the heap property.>
    Next i
End Heapsort  
         */

        static int[] Heapsort(int[] array)
        {
            SetTimer();
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                addToHeap(array, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                addToHeap(array, i, 0);
            }
            //foreach (int i in array) { Console.Write(i + " ");  }
            aTimer.Stop();
            return array;
        }

        private static void addToHeap(int[] array, int n, int i)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region QuickSort
        /*Description:  is a  comparison-based sort-in-place divide-and-conquer strategy.
         * Best Case: O(n log n)
         * Worst Case: O(n^2)
         * Puesdocode:
         * algorithm quicksort(A, lo, hi) is
    if lo < hi then
        p := pivot(A, lo, hi)
        left, right := partition(A, p, lo, hi)  // note: multiple return values
        quicksort(A, lo, left - 1)
        quicksort(A, right + 1, hi)
         */





        #endregion
    }




}

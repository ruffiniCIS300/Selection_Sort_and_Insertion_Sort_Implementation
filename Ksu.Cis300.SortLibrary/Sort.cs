/*
 * Sort.cs
 * Author: Nick Ruffini
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.SortLibrary
{
    /// <summary>
    /// Class that contains both the insertion and selection sorting algorithms!
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Swaps the value at location i in list with the value in location j
        /// </summary>
        /// <param name="list"> List that we are swapping the two values in </param>
        /// <param name="i"> Location of the first value we are swapping </param>
        /// <param name="j"> Location of the second value we are swapping </param>
        private static void Swap(IList<int> list, int i, int j)
        {
            int temp = list[j];
            list[j] = list[i];
            list[i] = temp;
        }
        /// <summary>
        /// Selection sorting method that increments through a list, sorting from smallest to biggest
        /// as it goes. 
        /// </summary>
        /// <param name="list"> List that we are applying selection sort to </param>
        public static void SelectionSort(IList<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int minIndex = i; 
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, minIndex, i);
            }
        }
        /// <summary>
        /// Insertion sorting method that takes the first element that is unsorted, and works it's way 
        /// backwards through the sorted set!
        /// </summary>
        /// <param name="list"> List that we are applying insertion sort onto </param>
        public static void InsertionSort(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int cur = list[i];
                int j;
                for (j = i; j > 0; j--)
                {
                    if (list[j - 1] > cur)
                    {
                        list[j] = list[j - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                list[j] = cur;
            }
        }
    }
}

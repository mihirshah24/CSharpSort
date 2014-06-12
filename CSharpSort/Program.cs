using System;
using System.Collections.Generic;

namespace CSharpSort
{
    class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            var numbers = new List<int> { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int count = numbers.Count;
            
            Console.WriteLine("MergeSort By Recursive Method");
            MergeSortRecursive(numbers, 0, count - 1);

            for (var i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);
            
            Console.ReadLine();
        }

        /// <summary>
        /// Merges the sort recursive.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        private static void MergeSortRecursive(IList<int> numbers, int left, int right)
        {
            if (right <= left) return;
            
            var mid = (right + left)/2;
            MergeSortRecursive(numbers, left, mid);
            MergeSortRecursive(numbers, (mid + 1), right);

            DoMerge(numbers, left, (mid + 1), right);
        }

        /// <summary>
        /// Does the merge.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="left">The left.</param>
        /// <param name="mid">The mid.</param>
        /// <param name="right">The right.</param>
        private static void DoMerge(IList<int> numbers, int left, int mid, int right)
        {
            int totalNumbers = numbers.Count;

            var temp = new int[totalNumbers];
            //var temp = new List<int>(totalNumbers);

            //for (int i = 0; i < totalNumbers; i++)
            //{
            //    temp.Add(0);
            //}

            int leftEnd = (mid - 1);
            int tempPosition = left;
            int numberOfElements = (right - left + 1);
            
            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tempPosition++] = numbers[left++];
                else
                    temp[tempPosition++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[tempPosition++] = numbers[left++];

            while (mid <= right)
                temp[tempPosition++] = numbers[mid++];
            
            for (int i = 0; i < numberOfElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

    }
}

namespace CSharpSort
{
    /// <summary>
    /// 
    /// </summary>
    public class QuickSortDualPivot
    {

        /// <summary>
        /// Sorts the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public void Sort(int[] input)
        {
            Sort(input, 0, input.Length-1);
        }


        private static void Sort(int[] input, int lowIndex, int highIndex)
        {
            if (highIndex <= lowIndex) return;

            int pivot1 = input[lowIndex];
            int pivot2 = input[highIndex];

            if (pivot1 < pivot2)
            {
                input.Exchange(lowIndex, highIndex);
                pivot1 = input[lowIndex];
                pivot2 = input[highIndex];
            }
            else if (pivot1 == pivot2)
            {
                while (pivot1 == pivot2 && lowIndex < highIndex)
                {
                    lowIndex++;
                    pivot1 = input[lowIndex];
                }
            }

            int i = lowIndex + 1;
            int lt = lowIndex + 1;
            int gt = highIndex - 1;

            while(i <= gt)
            {
                if (input[i].LessThan(pivot1))
                    input.Exchange(i++, lt++);
                else if (pivot2.LessThan(input[i]))
                    input.Exchange(i, gt--);
                else i++;
            }

            input.Exchange(lowIndex, --lt);
            input.Exchange(highIndex, ++gt);

            Sort(input, lowIndex, lt-1);
            Sort(input, lt+1, gt-1);
            Sort(input, gt+1, highIndex);
        }

    }
}

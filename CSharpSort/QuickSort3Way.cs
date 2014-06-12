namespace CSharpSort
{
    /// <summary>
    /// 
    /// </summary>
    public class QuickSort3Way
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

            int lt = lowIndex;
            int gt = highIndex;
            int i = lowIndex + 1;

            int pivotIndex = lowIndex;
            int pivotValue = input[pivotIndex];

            while (i <= gt)
            {
                if (input[i].LessThan(pivotValue))
                {
                    input.Exchange(i++, lt++);
                }
                else if (pivotValue.LessThan(input[i]))
                {
                    input.Exchange(i, gt--);
                }
                else i++;
            }

            Sort(input, lowIndex, lt-1);
            Sort(input, gt+1, highIndex);
        }

    }
}

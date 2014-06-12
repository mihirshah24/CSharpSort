namespace CSharpSort
{
    /// <summary>
    /// 
    /// </summary>
    public class QuickSortBasic
    {

        /// <summary>
        /// Sorts the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public void Sort(int[] input)
        {
            Sort(input, 0, input.Length - 1);
        }

        private static void Sort(int[] input, int lowIndex, int highIndex)
        {
            if (highIndex <= lowIndex)
                return;

            int partitionIndex = Partition(input, lowIndex, highIndex);

            Sort(input, lowIndex, partitionIndex-1);
            Sort(input, partitionIndex+1, highIndex);
        }

        private static int Partition(int[] input, int lowIndex, int highIndex)
        {
           	int i = lowIndex;
            int pivotIndex = lowIndex;
            int j = highIndex + 1;


            while (true)
            {
                while (input[++i] < input[pivotIndex])
                {
                    if (i == highIndex) break;
                }

                while (input[pivotIndex] < input[--j])
                {
                    if (j == lowIndex) break;
                }

                if (i >= j) break;

                input.Exchange(i, j);

            }

            input.Exchange(pivotIndex, j);

            return j;
        }

        	

            

    }
}

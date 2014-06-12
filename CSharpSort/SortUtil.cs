namespace CSharpSort
{
    /// <summary>
    /// 
    /// </summary>
    public static class SortUtil
    {
        /// <summary>
        /// Exchanges the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static void Exchange(this int[] array, int from, int to)
        {
            var temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }

        /// <summary>
        /// Lesses the specified a.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        public static bool LessThan(this int a, int b)
        {
            return a < b;
        }

    }
}

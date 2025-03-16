namespace Cdefgah.SortingAlgorithms.Utils;

/// <summary>
/// Provides insertion sort functionality for various classes, that use this functionality.
/// </summary>
internal static class InsertionSortProvider
{
    /// <summary>
    /// Performs insertion sort.
    /// </summary>
    /// <typeparam name="T">Type of the collection element.</typeparam>
    /// <param name="array">Array to be sorted.</param>
    /// <param name="startIndex">Start element index to be used for sorting.</param>
    /// <param name="endIndex">End element index to be used for sorting.</param>
    /// <param name="comparer">Actual comparer to be used for sorting.</param>
    public static void InsertionSort<T>(IList<T?> array, int startIndex, int endIndex, IComparer<T> comparer) where T : IComparable<T>
    {
        // We start with the second element with i = 1, because we compare the current element with the previous one.
        for (int i = startIndex; i <= endIndex; i++)
        {
            T? currentValue = array[i];
            int index = i;

            // Find the position where currentValue should be inserted.
            while (index > 0 && comparer.Compare(array[index - 1], currentValue) > 0)
            {
                // Shift values to the right.
                array[index] = array[index - 1];
                index--;
            }

            // Insert currentValue at the found position.
            array[index] = currentValue;
        }
    }
}

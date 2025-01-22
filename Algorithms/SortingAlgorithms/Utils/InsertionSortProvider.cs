namespace Cdefgah.SortingAlgorithms.Utils;

internal static class InsertionSortProvider
{
    public static void InsertionSort<T>(IList<T?> array, int startIndex, int endIndex) where T : IComparable<T>
    {
        Comparer<T> comparer = Comparer<T>.Default;

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

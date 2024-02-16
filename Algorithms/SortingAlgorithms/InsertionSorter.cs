using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

public sealed class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        // We start with the second element with i = 1, because we compare the current element with the previous one.
        for (int i = 1; i < array.Count; i++)
        {
            T? currentValue = array[i];
            int index = i;

            // Find the position where currentValue should be inserted.
            while (index > 0 && Comparer<T>.Default.Compare(array[index - 1], currentValue) > 0)
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

using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

public sealed class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        int n = array.Count;
        Comparer<T> comparer = Comparer<T>.Default;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimal element in unsorted (sub)-array and keep its index
            // assume the minimal element is the first element.
            int minValueIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (comparer.Compare(array[j], array[minValueIndex]) < 0)
                {
                    minValueIndex = j;
                }
            }

            // Swap the found minimum element 
            // with the first element in unsorted (sub)-array.
            if (minValueIndex != i)
            {
                (array[i], array[minValueIndex]) = (array[minValueIndex], array[i]);
            }
        }
    }
}

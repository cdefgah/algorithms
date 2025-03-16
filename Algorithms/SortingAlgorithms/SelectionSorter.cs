using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

public sealed class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    public SelectionSorter()
    {
        comparer = Comparer<T>.Default;
    }

    public SelectionSorter(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    public void Sort(IList<T?> array)
    {
        ArgumentNullException.ThrowIfNull(array);
        int n = array.Count;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the smallest element in an unsorted(sub-)array
            // and keep its index, assuming that the smallest element is the first element.
            int minValueIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (comparer.Compare(array[j], array[minValueIndex]) < 0)
                {
                    minValueIndex = j;
                }
            }


            // Swap the smallest element found with the first element in the unsorted (sub)array.
            if (minValueIndex != i)
            {
                (array[i], array[minValueIndex]) = (array[minValueIndex], array[i]);
            }
        }
    }
}

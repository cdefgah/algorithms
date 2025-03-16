using Cdefgah.SortingAlgorithms.Interfaces;
using Cdefgah.SortingAlgorithms.Utils;

namespace Cdefgah.SortingAlgorithms;

public sealed class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    public InsertionSorter() : this(null)
    {
     
    }

    public InsertionSorter(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    public void Sort(IList<T?> array)
    {
        ArgumentNullException.ThrowIfNull(array);
        InsertionSortProvider.InsertionSort(array, 0, array.Count - 1, comparer);
    }
}

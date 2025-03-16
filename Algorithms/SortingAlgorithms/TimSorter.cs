using Cdefgah.SortingAlgorithms.Interfaces;
using Cdefgah.SortingAlgorithms.Utils;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs TimSort on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class TimSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public TimSorter() : this(null)
    {
        
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public TimSorter(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    /// <summary>
    /// Performs the sorting. Sorting is done in-place.
    /// </summary>
    /// <param name="collection">The collection to sort.</param>
    public void Sort(IList<T?> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        const int runSize = 32;
        var helper = new T?[collection.Count];

        int n = collection.Count;
        for (int i = 0; i < n; i += runSize)
        {
            InsertionSortProvider.InsertionSort(collection, i, Math.Min((i + runSize - 1), (n - 1)), comparer);
        }

        for (int size = runSize; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1), (n - 1));
                if (mid < right)
                {
                    MergeProvider.Merge(collection, helper, left, mid, right, comparer);
                }
            }
        }
    }   
}

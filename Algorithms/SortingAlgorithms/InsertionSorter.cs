using Cdefgah.SortingAlgorithms.Interfaces;
using Cdefgah.SortingAlgorithms.Utils;

namespace Cdefgah.SortingAlgorithms;


/// <summary>
/// Performs InsertionSort on provided collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public InsertionSorter() : this(null)
    {
     
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public InsertionSorter(IComparer<T>? comparer = null)
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
        InsertionSortProvider.InsertionSort(collection, 0, collection.Count - 1, comparer);
    }
}

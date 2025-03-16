using Cdefgah.SortingAlgorithms.Interfaces;
using Cdefgah.SortingAlgorithms.Utils;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs MergeSort on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class MergeSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public MergeSorter() : this(null)
    {
        
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public MergeSorter(IComparer<T>? comparer = null)
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

        var helper = new T?[collection.Count];
        MergeSort(collection, helper, 0, collection.Count - 1);
    }

    private void MergeSort(IList<T?> array, IList<T?> helper, int low, int high)
    {
        if (low < high)
        {
            int middle = low + (high - low) / 2; 
            MergeSort(array, helper, low, middle);
            MergeSort(array, helper, middle + 1, high);

            MergeProvider.Merge(array, helper, low, middle, high, comparer);
        }
    } 
}

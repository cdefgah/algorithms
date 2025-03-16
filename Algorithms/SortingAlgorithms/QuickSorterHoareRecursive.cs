using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs a recursive QuickSort using the Hoare partitioning scheme on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class QuickSorterHoareRecursive<T> : QuickSorterHoareBase<T> where T : IComparable<T>
{
    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public QuickSorterHoareRecursive() : this(null)
    {

    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public QuickSorterHoareRecursive(IComparer<T>? comparer = null) : base(comparer)
    {

    }

    protected override void QuickSort(IList<T?> collection, int low, int high)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if (low < high)
        {
            var pivotIndex = Partition(collection, low, high);

            QuickSort(collection, low, pivotIndex);
            QuickSort(collection, pivotIndex + 1, high);
        }
    }
}

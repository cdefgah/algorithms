using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs a recursive QuickSort using the Lomuto partitioning scheme on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class QuickSorterLomutoRecursive<T> : QuickSorterLomutoBase<T> where T : IComparable<T>
{
    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public QuickSorterLomutoRecursive() : this(null)
    {

    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public QuickSorterLomutoRecursive(IComparer<T>? comparer = null) : base(comparer)
    {

    }

    protected override void QuickSort(IList<T?> collection, int low, int high)
    {
        ArgumentNullException.ThrowIfNull(collection);

        if (low < high)
        {
            int pivotIndex = Partition(collection, low, high);

            QuickSort(collection, low, pivotIndex - 1);
            QuickSort(collection, pivotIndex + 1, high);
        }
    }
}

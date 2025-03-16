using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs a non-recursive QuickSort using the Lomuto partitioning scheme on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class QuickSorterLomutoNonRecursive<T> : QuickSorterLomutoBase<T> where T : IComparable<T>
{
    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public QuickSorterLomutoNonRecursive() : this(null)
    {

    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public QuickSorterLomutoNonRecursive(IComparer<T>? comparer = null) : base(comparer)
    {

    }

    protected override void QuickSort(IList<T?> collection, int low, int high)
    {
        ArgumentNullException.ThrowIfNull(collection);

        Stack<(int, int)> stack = new();        
        stack.Push((low, high));

        while (stack.Count > 0)
        {
            (low, high) = stack.Pop();
            if (low >= high)
            {
                continue;
            }

            int pivotIndex = Partition(collection, low, high);

            stack.Push((low, pivotIndex - 1));
            stack.Push((pivotIndex + 1, high));
        }
    }
}

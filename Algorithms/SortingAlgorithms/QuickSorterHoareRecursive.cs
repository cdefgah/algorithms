using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

public sealed class QuickSorterHoareRecursive<T> : QuickSorterHoareBase<T> where T : IComparable<T>
{
    public QuickSorterHoareRecursive() : base()
    {

    }

    public QuickSorterHoareRecursive(IComparer<T>? comparer = null) : base(comparer)
    {

    }

    protected override void QuickSort(IList<T?> array, int low, int high)
    {
        ArgumentNullException.ThrowIfNull(array);

        if (low < high)
        {
            var pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex);
            QuickSort(array, pivotIndex + 1, high);
        }
    }
}

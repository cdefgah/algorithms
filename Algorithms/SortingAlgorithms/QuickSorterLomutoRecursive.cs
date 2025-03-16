using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

public sealed class QuickSorterLomutoRecursive<T> : QuickSorterLomutoBase<T> where T : IComparable<T>
{
    public QuickSorterLomutoRecursive() : base()
    {

    }

    public QuickSorterLomutoRecursive(IComparer<T>? comparer = null) : base(comparer)
    {

    }

    protected override void QuickSort(IList<T?> array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }
}

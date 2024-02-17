using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms.Base;

public abstract class QuickSorterBase<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        QuickSort(array, 0, array.Count - 1);
    }

    private void QuickSort(IList<T?> array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    protected abstract int Partition(IList<T?> array, int low, int high);
}

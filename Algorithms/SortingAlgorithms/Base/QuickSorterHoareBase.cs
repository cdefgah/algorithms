using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms.Base;

public abstract class QuickSorterHoareBase<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    protected QuickSorterHoareBase()
    {
        comparer = Comparer<T>.Default;
    }

    protected QuickSorterHoareBase(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    public void Sort(IList<T?> array)
    {
        QuickSort(array, 0, array.Count - 1);
    }

    protected abstract void QuickSort(IList<T?> array, int low, int high);

    protected int Partition(IList<T?> array, int low, int high)
    {
        T? pivot = array[(low + high) / 2];
        int i = low;
        int j = high;

        while (true)
        {
            while (comparer.Compare(array[i], pivot) < 0)
            {
                i++;
            }

            while (comparer.Compare(array[j], pivot) > 0)
            {
                j--;
            }

            if (i >= j)
            {
                return j;
            }

            (array[i], array[j]) = (array[j], array[i]);
            i++;
            j--;
        }
    }
}

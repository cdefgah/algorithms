using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms.Base;

public abstract class QuickSorterLomutoBase<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    protected QuickSorterLomutoBase(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    public void Sort(IList<T?> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);
        QuickSort(collection, 0, collection.Count - 1);
    }

    protected abstract void QuickSort(IList<T?> collection, int low, int high);

    protected virtual int Partition(IList<T?> collection, int low, int high)
    {
        ArgumentNullException.ThrowIfNull(collection);

        T? pivot = collection[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (comparer.Compare(collection[j], pivot) < 0)
            {
                i++;
                (collection[i], collection[j]) = (collection[j], collection[i]);
            }
        }

        // Move pivot element to its corrected position
        int correctedPivotIndex = i + 1;
        (collection[high], collection[correctedPivotIndex]) = (collection[correctedPivotIndex], collection[high]);

        return correctedPivotIndex;
    }
}
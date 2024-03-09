using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms.Base;

public abstract class QuickSorterLomutoBase<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        QuickSort(array, 0, array.Count - 1);
    }

    protected abstract void QuickSort(IList<T?> array, int low, int high);

    protected virtual int Partition(IList<T?> array, int low, int high)
    {
        T? pivot = array[high];
        int i = (low - 1);

        Comparer<T> comparer = Comparer<T>.Default;

        for (int j = low; j < high; j++)
        {
            if (comparer.Compare(array[j], pivot) < 0)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        // Move pivot element to its corrected position
        int correctedPivotIndex = i + 1;
        (array[high], array[correctedPivotIndex]) = (array[correctedPivotIndex], array[high]);

        return correctedPivotIndex;
    }
}
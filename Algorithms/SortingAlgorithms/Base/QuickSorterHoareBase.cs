using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms.Base;

public abstract class QuickSorterHoareBase<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        QuickSort(array, 0, array.Count - 1);
    }

    protected abstract void QuickSort(IList<T?> array, int low, int high);

    public static (int, int) Partition(IList<T?> array, int low, int high)
    {
        Random random = new();
        int pivotIndex = random.Next(low, high + 1);
        T? pivot = array[pivotIndex];

        int i = low - 1;
        int j = high + 1;

        while (true)
        {
            do
            {
                i++;
            } while (array[i]?.CompareTo(pivot) < 0);

            do
            {
                j--;
            } while (array[j]?.CompareTo(pivot) > 0);

            if (i >= j)
            {
                return (j, i);
            }

            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}

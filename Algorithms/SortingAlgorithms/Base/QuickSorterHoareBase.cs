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

        int i = low;
        int j = high;

        Comparer<T> comparer = Comparer<T>.Default;

        while (true)
        {
            while (i < high)
            {  
                if (comparer.Compare(pivot, array[i]) < 0)
                {
                    break;
                }

                i++;
            }

            while (j > low)
            {   
                if (comparer.Compare(array[j], pivot) < 0)
                {
                    break;
                }

                j--;
            }

            if (i >= j)
            {
                break;
            }

            (array[i], array[j]) = (array[j], array[i]);

            i++;
            j--;
        }

        if (i < pivotIndex)
        {
            (array[i], array[pivotIndex]) = (array[pivotIndex], array[i]);
            i++;
        }
        else if (pivotIndex < j)
        {
            (array[pivotIndex], array[j]) = (array[j], array[pivotIndex]);
            j--;
        }

        return (i, j);
    }
}

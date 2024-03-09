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
        int pivotIndex = random.Next(low, high + 1); // Adjusted, since high is inclusive 
        T? pivot = array[pivotIndex];

        int i = low; // Use low
        int j = high; // Adjusted, since high is inclusive now

        Comparer<T> comparer = Comparer<T>.Default;

        while (true)
        {
            while (i < high)
            {   // use high
                if (comparer.Compare(pivot, array[i]) < 0)
                {
                    break;
                }

                i++;
            }

            while (j > low)
            {   // use low
                if (comparer.Compare(array[j], pivot) < 0)
                {
                    break;
                }

                j--;
            }

            if (i >= j) break; // This condition alone is enough to exit


            (array[i], array[j]) = (array[j], array[i]);

            i++;
            j--;
        }

        // Do this only once, after the loop
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

using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        var helper = new T?[array.Count];

        MergeSort(array, helper, 0, array.Count - 1);
    }

    private static void MergeSort(IList<T?> array, IList<T?> helper, int low, int high)
    {
        if (low < high)
        {
            int middle = low + (high - low) / 2; 
            MergeSort(array, helper, low, middle);
            MergeSort(array, helper, middle + 1, high);

            Merge(array, helper, low, middle, high);
        }
    }

    private static void Merge(IList<T?> array, IList<T?> helper, int low, int middle, int high)
    {
        for (int i = low; i <= high; i++)
        {
            helper[i] = array[i];
        }

        int helperLeft = low;
        int helperRight = middle + 1;
        int current = low;

        Comparer<T> comparer = Comparer<T>.Default;

        while (helperLeft <= middle && helperRight <= high)
        {
            if (comparer.Compare(helper[helperLeft], helper[helperRight]) <= 0)
            {
                array[current] = helper[helperLeft];
                helperLeft++;
            }
            else
            {
                array[current] = helper[helperRight];
                helperRight++;
            }

            current++;
        }

        int remaining = middle - helperLeft;
        for (int i = 0; i <= remaining; i++)
        {
            array[current + i] = helper[helperLeft + i];
        }
    }
}

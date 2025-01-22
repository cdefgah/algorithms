using Cdefgah.SortingAlgorithms.Interfaces;
using Cdefgah.SortingAlgorithms.Utils;

namespace Cdefgah.SortingAlgorithms;

public sealed class MergeSorter<T> : ISorter<T> where T : IComparable<T>
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

            MergeProvider.Merge(array, helper, low, middle, high);
        }
    } 
}

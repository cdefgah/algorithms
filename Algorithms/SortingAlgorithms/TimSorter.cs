using Cdefgah.SortingAlgorithms.Interfaces;
using Cdefgah.SortingAlgorithms.Utils;

namespace Cdefgah.SortingAlgorithms;

public sealed class TimSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        const int RunSize = 32;

        var helper = new T?[array.Count];

        int n = array.Count;
        for (int i = 0; i < n; i += RunSize)
        {
            InsertionSortProvider.InsertionSort(array, i, Math.Min((i + RunSize - 1), (n - 1)));
        }

        for (int size = RunSize; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1), (n - 1));
                if (mid < right)
                {
                    MergeProvider.Merge(array, helper, left, mid, right);
                }
            }
        }
    }   
}

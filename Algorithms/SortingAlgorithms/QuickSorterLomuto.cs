using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

public sealed class QuickSorterLomuto<T> : QuickSorterBase<T> where T : IComparable<T>
{
   protected override int Partition(IList<T?> array, int low, int high)
    {
        T? pivot = array[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (Comparer<T>.Default.Compare(array[j], pivot) < 0)
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

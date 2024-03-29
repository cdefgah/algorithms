﻿using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

public sealed class QuickSorterHoareRecursive<T> : QuickSorterHoareBase<T> where T : IComparable<T>
{
    protected override void QuickSort(IList<T?> array, int low, int high)
    {
        if (low < high)
        {
            var pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex);
            QuickSort(array, pivotIndex + 1, high);
        }
    }
}

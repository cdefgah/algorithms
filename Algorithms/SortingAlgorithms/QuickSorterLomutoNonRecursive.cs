﻿using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

public sealed class QuickSorterLomutoNonRecursive<T> : QuickSorterLomutoBase<T> where T : IComparable<T>
{
    public QuickSorterLomutoNonRecursive() : base()
    {

    }

    public QuickSorterLomutoNonRecursive(IComparer<T>? comparer = null) : base(comparer)
    {

    }

    protected override void QuickSort(IList<T?> array, int low, int high)
    {
        Stack<(int, int)> stack = new();
        
        stack.Push((low, high));

        while (stack.Count > 0)
        {
            (low, high) = stack.Pop();
            if (low >= high)
            {
                continue;
            }

            int pivotIndex = Partition(array, low, high);

            stack.Push((low, pivotIndex - 1));
            stack.Push((pivotIndex + 1, high));
        }
    }
}

using Cdefgah.SortingAlgorithms.Base;

namespace Cdefgah.SortingAlgorithms;

public sealed class QuickSorterHoareNonRecursive<T> : QuickSorterHoareBase<T> where T : IComparable<T>
{
    public QuickSorterHoareNonRecursive() : base()
    {
        
    }

    public QuickSorterHoareNonRecursive(IComparer<T>? comparer = null) : base(comparer) 
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

            stack.Push((low, pivotIndex));
            stack.Push((pivotIndex+1, high));
        }
    }
}

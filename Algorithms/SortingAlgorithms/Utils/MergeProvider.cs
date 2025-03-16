namespace Cdefgah.SortingAlgorithms.Utils;

/// <summary>
/// Provides MergeSort functionality for various classes, that use this functionality.
/// </summary>
internal static class MergeProvider
{
    public static void Merge<T>(IList<T?> collection, 
                                IList<T?> helper, 
                                int low, 
                                int middle, 
                                int high, 
                                IComparer<T> comparer) where T : IComparable<T>
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(helper);
        ArgumentNullException.ThrowIfNull(comparer);

        for (int i = low; i <= high; i++)
        {
            helper[i] = collection[i];
        }

        int helperLeft = low;
        int helperRight = middle + 1;
        int current = low;

        while (helperLeft <= middle && helperRight <= high)
        {
            if (comparer.Compare(helper[helperLeft], helper[helperRight]) <= 0)
            {
                collection[current] = helper[helperLeft];
                helperLeft++;
            }
            else
            {
                collection[current] = helper[helperRight];
                helperRight++;
            }

            current++;
        }

        int remaining = middle - helperLeft;
        for (int i = 0; i <= remaining; i++)
        {
            collection[current + i] = helper[helperLeft + i];
        }
    }
}

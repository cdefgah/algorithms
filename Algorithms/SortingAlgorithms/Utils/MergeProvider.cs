namespace Cdefgah.SortingAlgorithms.Utils;

internal static class MergeProvider
{
    public static void Merge<T>(IList<T?> array, 
                                IList<T?> helper, 
                                int low, 
                                int middle, 
                                int high, 
                                IComparer<T> comparer) where T : IComparable<T>
    {
        for (int i = low; i <= high; i++)
        {
            helper[i] = array[i];
        }

        int helperLeft = low;
        int helperRight = middle + 1;
        int current = low;

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

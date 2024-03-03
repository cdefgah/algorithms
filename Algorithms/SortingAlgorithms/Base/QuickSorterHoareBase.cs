namespace Cdefgah.SortingAlgorithms.Base;

public abstract class QuickSorterHoareBase<T> : QuickSorterBase<T> where T : IComparable<T>
{
    protected override int Partition(IList<T?> array, int low, int high)
    {
        T? pivot = array[low];
        int i = low - 1;
        int j = high + 1;

        Comparer<T> comparer = Comparer<T>.Default;

        while (true)
        {
            do j--; while (j >= low && comparer.Compare(array[j], pivot) > 0);
            do i++; while (i <= high && comparer.Compare(array[i], pivot) < 0);

            if (i < j)
            {
                (array[i], array[j]) = (array[j], array[i]);
            }
            else
            {
                return j;
            }
        }
    }
}

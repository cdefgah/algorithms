using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

public sealed class BubbleSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    public BubbleSorter()
    {
        comparer = Comparer<T>.Default;
    }

    public BubbleSorter(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    public void Sort(IList<T?> array)
    {
        int n = array.Count;

        for (int i = 0; i < n; i++)
        {
            bool swapPerformed = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (comparer.Compare(array[j], array[j + 1]) > 0)
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    swapPerformed = true;
                }
            }

            // if there were no swaps, array is sorted
            if (!swapPerformed)
            {
                break;
            }
        }
    }
}

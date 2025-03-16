using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs BubbleSort on provided collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class BubbleSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public BubbleSorter() : this(null)
    {
        
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public BubbleSorter(IComparer<T>? comparer = null)
    {
        this.comparer = comparer ?? Comparer<T>.Default;
    }

    /// <summary>
    /// Performs the sorting. Sorting is done in-place.
    /// </summary>
    /// <param name="collection">The collection to sort.</param>
    public void Sort(IList<T?> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);

        int n = collection.Count;

        for (int i = 0; i < n; i++)
        {
            bool swapPerformed = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (comparer.Compare(collection[j], collection[j + 1]) > 0)
                {
                    (collection[j + 1], collection[j]) = (collection[j], collection[j + 1]);
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

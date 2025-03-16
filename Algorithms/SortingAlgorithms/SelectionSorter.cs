using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs SelectionSort on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public SelectionSorter() : this(null)
    {
        
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public SelectionSorter(IComparer<T>? comparer = null)
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

        for (int i = 0; i < n - 1; i++)
        {
            // Find the smallest element in an unsorted(sub-)array
            // and keep its index, assuming that the smallest element is the first element.
            int minValueIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (comparer.Compare(collection[j], collection[minValueIndex]) < 0)
                {
                    minValueIndex = j;
                }
            }


            // Swap the smallest element found with the first element in the unsorted (sub)array.
            if (minValueIndex != i)
            {
                (collection[i], collection[minValueIndex]) = (collection[minValueIndex], collection[i]);
            }
        }
    }
}

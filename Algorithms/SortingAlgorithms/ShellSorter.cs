using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

/// <summary>
/// Performs ShellSort on the specified collection.
/// </summary>
/// <typeparam name="T">Collection element type.</typeparam>
public sealed class ShellSorter<T> : ISorter<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    /// <summary>
    /// Default constructor, uses default comparer for the provided type.
    /// </summary>
    public ShellSorter() : this(null)
    {
        
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="comparer">A custom comparer to be used for sorting.</param>
    public ShellSorter(IComparer<T>? comparer = null)
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

        for (int interval = collection.Count / 2; interval > 0; interval /= 2)
        {
            for (int i = interval; i < collection.Count; i++)
            {
                var currentKey = collection[i];
                var k = i;
                while ( (k >= interval) && (comparer.Compare(collection[k - interval], currentKey) > 0) )
                {
                    collection[k] = collection[k - interval];
                    k -= interval;
                }

                collection[k] = currentKey;
            }
        }
    }
}

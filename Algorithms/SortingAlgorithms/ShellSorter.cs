using Cdefgah.SortingAlgorithms.Interfaces;

namespace Cdefgah.SortingAlgorithms;

public sealed class ShellSorter<T> : ISorter<T> where T : IComparable<T>
{
    public void Sort(IList<T?> array)
    {
        Comparer<T> comparer = Comparer<T>.Default;

        for (int interval = array.Count / 2; interval > 0; interval /= 2)
        {
            for (int i = interval; i < array.Count; i++)
            {
                var currentKey = array[i];
                var k = i;
                while ( (k >= interval) && (comparer.Compare(array[k - interval], currentKey) > 0) )
                {
                    array[k] = array[k - interval];
                    k -= interval;
                }

                array[k] = currentKey;
            }
        }
    }
}

namespace Cdefgah.SortingAlgorithms.Interfaces;

public interface ISorter<T> where T : IComparable<T>
{
    void Sort(IList<T?> collection);
}

namespace SortingAlgorithms.UnitTests.Support.Utils;

internal class ReverseIntComparer : IComparer<int>
{
    public int Compare(int x, int y) => y.CompareTo(x);
}

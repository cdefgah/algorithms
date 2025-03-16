using Cdefgah.SortingAlgorithms.UnitTests.Support;

namespace SortingAlgorithms.UnitTests.Support.Utils;

internal class ReverseSomeEntiryComparer : IComparer<SomeEntity>
{
    public int Compare(SomeEntity? x, SomeEntity? y)
    {
        if (y == null)
        {
            return -1;
        }
        
        return y.CompareTo(x);
    }
}

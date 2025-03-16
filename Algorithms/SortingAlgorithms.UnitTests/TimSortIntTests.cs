using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class TimSortIntTests : IntSorterTestsBase<TimSorter<int>>
{
    public TimSortIntTests() : base(comparer => new(comparer))
    {
        
    }
}

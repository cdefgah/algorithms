using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class InsertionSorterIntTests : IntSorterTestsBase<InsertionSorter<int>>
{
    public InsertionSorterIntTests() : base(comparer => new(comparer))
    {

    }
}

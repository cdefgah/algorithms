using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class SelectionSorterIntTests : IntSorterTestsBase<SelectionSorter<int>>
{
    public SelectionSorterIntTests() : base(comparer => new(comparer))
    {
        
    }
}

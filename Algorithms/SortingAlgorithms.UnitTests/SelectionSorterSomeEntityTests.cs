using Cdefgah.SortingAlgorithms.UnitTests.Support;
using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class SelectionSorterSomeEntityTests : SomeEntitySorterTestsBase<SelectionSorter<SomeEntity>>
{
    public SelectionSorterSomeEntityTests() : base(comparer => new(comparer))
    {
        
    }
}

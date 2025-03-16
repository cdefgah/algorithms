using Cdefgah.SortingAlgorithms.UnitTests.Support;
using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class ShellSorterSomeEntityTests : SomeEntitySorterTestsBase<ShellSorter<SomeEntity>>
{
    public ShellSorterSomeEntityTests() : base(comparer => new(comparer))
    {
        
    }
}

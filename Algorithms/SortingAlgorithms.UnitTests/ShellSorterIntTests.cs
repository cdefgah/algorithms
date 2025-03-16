using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class ShellSorterIntTests : IntSorterTestsBase<ShellSorter<int>>
{
    public ShellSorterIntTests() : base(comparer => new(comparer))
    {
        
    }
}

using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;
using Cdefgah.SortingAlgorithms.UnitTests.Support;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class QuickSorterLomutoRecursiveSomeEntityTests : SomeEntitySorterTestsBase<QuickSorterLomutoRecursive<SomeEntity>>
{
    public QuickSorterLomutoRecursiveSomeEntityTests() : base(comparer => new(comparer))
    {
        
    }
}

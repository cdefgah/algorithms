using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;
using Cdefgah.SortingAlgorithms.UnitTests.Support;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class QuickSorterLomutoNonRecursiveSomeEntityTests : SomeEntitySorterTestsBase<QuickSorterLomutoNonRecursive<SomeEntity>>
{
    public QuickSorterLomutoNonRecursiveSomeEntityTests() : base(comparer => new(comparer))
    {
        
    }
}

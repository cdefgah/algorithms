using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class QuickSorterLomutoNonRecursiveIntTests : IntSorterTestsBase<QuickSorterLomutoNonRecursive<int>>
{
    public QuickSorterLomutoNonRecursiveIntTests() : base(comparer => new(comparer))
    {
        
    }
}

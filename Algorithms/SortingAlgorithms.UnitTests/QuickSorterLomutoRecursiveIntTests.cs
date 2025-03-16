using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class QuickSorterLomutoRecursiveIntTests : IntSorterTestsBase<QuickSorterLomutoRecursive<int>>
{
    public QuickSorterLomutoRecursiveIntTests() : base(comparer => new(comparer))
    {
        
    }
}

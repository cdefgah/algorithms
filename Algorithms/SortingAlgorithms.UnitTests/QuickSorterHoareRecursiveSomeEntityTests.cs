﻿using Cdefgah.SortingAlgorithms.UnitTests.Support;
using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class QuickSorterHoareRecursiveSomeEntityTests : SomeEntitySorterTestsBase<QuickSorterHoareRecursive<SomeEntity>>
{
    public QuickSorterHoareRecursiveSomeEntityTests() : base(comparer => new(comparer))
    {
        
    }
}

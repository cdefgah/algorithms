﻿using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class QuickSorterHoareRecursiveIntTests : IntSorterTestsBase<QuickSorterHoareRecursive<int>>
{
    public QuickSorterHoareRecursiveIntTests() : base(comparer => new(comparer))
    {

    }
}

﻿using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed  class QuickSorterHoareNonRecursiveIntTests : IntSorterTestsBase<QuickSorterHoareNonRecursive<int>>
{
    public QuickSorterHoareNonRecursiveIntTests() : base(comparer => new(comparer))
    {

    }
}

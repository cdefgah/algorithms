﻿using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class MergeSorterIntTests : IntSorterTestsBase<MergeSorter<int>>
{
    public MergeSorterIntTests() : base(comparer => new(comparer))
    {

    }
}

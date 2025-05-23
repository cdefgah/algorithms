﻿using Cdefgah.SortingAlgorithms.UnitTests.Support;
using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class BubbleSorterSomeEntityTests : SomeEntitySorterTestsBase<BubbleSorter<SomeEntity>>
{
    public BubbleSorterSomeEntityTests() : base(comparer => new(comparer))
    {

    }
}

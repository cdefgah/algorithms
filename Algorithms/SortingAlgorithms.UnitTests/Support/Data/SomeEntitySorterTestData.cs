﻿// Declaring this alias, to make the code more readable
using SortingAlgorithms.UnitTests.Support.Utils;

using SE = Cdefgah.SortingAlgorithms.UnitTests.Support.SomeEntity;

namespace SortingAlgorithms.UnitTests.Support.Data;

internal sealed class SomeEntitySorterTestData : TheoryData<IComparer<SE>?, IList<SE?>, IList<SE?>>
{
    public SomeEntitySorterTestData()
    {
        var reverseSomeEntityComparer = new ReverseSomeEntiryComparer();

        Add(null, [], []);
        Add(reverseSomeEntityComparer, [], []);

        Add(null, [ null ], [ null ]);
        Add(reverseSomeEntityComparer, [null], [null]);

        Add(null, [ new SE(null, null) ], [ new SE(null, null) ]);
        Add(reverseSomeEntityComparer, [new SE(null, null)], [new SE(null, null)]);

        Add(null, [new SE(1, "a"), new SE(null, "a")], [new SE(null, "a"), new SE(1, "a")]);
        Add(reverseSomeEntityComparer, [new SE(1, "a"), new SE(null, "a")], [new SE(1, "a"), new SE(null, "a")]);

        Add(null, [new SE(null, "a"), new SE(null, "b")], [new SE(null, "a"), new SE(null, "b")]);
        Add(reverseSomeEntityComparer, [new SE(null, "a"), new SE(null, "b")], [new SE(null, "b"), new SE(null, "a")]);

        Add(null, [new SE(null, "b"), new SE(null, "a")], [new SE(null, "a"), new SE(null, "b")]);
        Add(reverseSomeEntityComparer, [new SE(null, "b"), new SE(null, "a")], [new SE(null, "b"), new SE(null, "a")]);

        Add(null, [new SE(null, "b"), new SE(null, "a"), new SE(null, null)], [new SE(null, null), new SE(null, "a"), new SE(null, "b")]);
        Add(reverseSomeEntityComparer, [new SE(null, "b"), new SE(null, "a"), new SE(null, null)], [new SE(null, "b"), new SE(null, "a"), new SE(null, null)]);

        Add(null, [new SE(-3, "w"), new SE(-2, "v"), new SE(-1, "y")], [new SE(-3, "w"), new SE(-2, "v"), new SE(-1, "y")]);
        Add(reverseSomeEntityComparer, [new SE(-3, "w"), new SE(-2, "v"), new SE(-1, "y")], [new SE(-1, "y"), new SE(-2, "v"), new SE(-3, "w")]);

        Add(null, [new SE(-3, "x"), new SE(-2, "b"), new SE(-2, "a")], [new SE(-3, "x"), new SE(-2, "a"), new SE(-2, "b")]);
        Add(reverseSomeEntityComparer, [new SE(-3, "x"), new SE(-2, "b"), new SE(-2, "a")], [new SE(-2, "b"), new SE(-2, "a"), new SE(-3, "x")]);

        Add(null, [new SE(-1, "c"), new SE(-2, "b"), new SE(-3, "a")], [new SE(-3, "a"), new SE(-2, "b"), new SE(-1, "c")]);
        Add(reverseSomeEntityComparer, [new SE(-1, "c"), new SE(-2, "b"), new SE(-3, "a")], [new SE(-1, "c"), new SE(-2, "b"), new SE(-3, "a")]);

        Add(null, [new SE(1, "x"), null, new SE(2, "a")], [null, new SE(1, "x"), new SE(2, "a")]);
        Add(reverseSomeEntityComparer, [new SE(1, "x"), null, new SE(2, "a")], [new SE(2, "a"), new SE(1, "x"), null]);

        Add(null, [new SE(3, "c"), new SE(2, "b"), new SE(1, "a")], [new SE(1, "a"), new SE(2, "b"), new SE(3, "c")]);
        Add(reverseSomeEntityComparer, [new SE(3, "c"), new SE(2, "b"), new SE(1, "a")], [new SE(3, "c"), new SE(2, "b"), new SE(1, "a")]);

        Add(null, [new SE(3, "a"), new SE(2, "b"), new SE(1, "c")], [new SE(1, "c"), new SE(2, "b"), new SE(3, "a")]);
        Add(reverseSomeEntityComparer, [new SE(3, "a"), new SE(2, "b"), new SE(1, "c")], [new SE(3, "a"), new SE(2, "b"), new SE(1, "c")]);

        Add(null, [new SE(1, "a"), new SE(2, "b"), new SE(3, "c"), new SE(4, "d")], [new SE(1, "a"), new SE(2, "b"), new SE(3, "c"), new SE(4, "d")]);
        Add(reverseSomeEntityComparer, [new SE(1, "a"), new SE(2, "b"), new SE(3, "c"), new SE(4, "d")], [new SE(4, "d"), new SE(3, "c"), new SE(2, "b"), new SE(1, "a")]);

        Add(null, [new SE(4, "a"), new SE(3, "b"), new SE(2, "c"), new SE(1, "d")], [new SE(1, "d"), new SE(2, "c"), new SE(3, "b"), new SE(4, "a")]);
        Add(reverseSomeEntityComparer, [new SE(4, "a"), new SE(3, "b"), new SE(2, "c"), new SE(1, "d")], [new SE(4, "a"), new SE(3, "b"), new SE(2, "c"), new SE(1, "d")]);

        Add(null, [new SE(4, "a"), new SE(4, "a"), new SE(4, "a"), new SE(4, "a")], [new SE(4, "a"), new SE(4, "a"), new SE(4, "a"), new SE(4, "a")]);
        Add(reverseSomeEntityComparer, [new SE(4, "a"), new SE(4, "a"), new SE(4, "a"), new SE(4, "a")], [new SE(4, "a"), new SE(4, "a"), new SE(4, "a"), new SE(4, "a")]);

        Add(null, [new SE(int.MaxValue, "a"), new SE(int.MinValue, "a"), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a")], 
                                  [new SE(int.MinValue, "a"), new SE(int.MinValue, "a"), new SE(int.MaxValue, "a"), new SE(int.MaxValue, "a")]);
        Add(reverseSomeEntityComparer, [new SE(int.MaxValue, "a"), new SE(int.MinValue, "a"), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a")],
                                  [new SE(int.MaxValue, "a"), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a"), new SE(int.MinValue, "a")]);

        Add(null, [new SE(int.MaxValue, null), new SE(int.MinValue, null), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a")],
                                  [new SE(int.MinValue, null), new SE(int.MinValue, "a"), new SE(int.MaxValue, null), new SE(int.MaxValue, "a")]);

        Add(reverseSomeEntityComparer, [new SE(int.MaxValue, null), new SE(int.MinValue, null), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a")],
                                  [new SE(int.MaxValue, "a"), new SE(int.MaxValue, null), new SE(int.MinValue, "a"), new SE(int.MinValue, null)]);

        Add(null, [new SE(int.MaxValue, "a"), new SE(1, "a"), new SE(int.MaxValue, null), new SE(2, "a")],
                                                        [new SE(1, "a"), new SE(2, "a"), new SE(int.MaxValue, null), new SE(int.MaxValue, "a")]);
        Add(reverseSomeEntityComparer, [new SE(int.MaxValue, "a"), new SE(1, "a"), new SE(int.MaxValue, null), new SE(2, "a")],
                                                        [new SE(int.MaxValue, "a"), new SE(int.MaxValue, null), new SE(2, "a"), new SE(1, "a")]);

        Add(null, [new SE(-1, "a"), new SE(-2, "b"), new SE(1, "c"), new SE(2, "d")], [new SE(-2, "b"), new SE(-1, "a"), new SE(1, "c"), new SE(2, "d")]);

        Add(reverseSomeEntityComparer, [new SE(-1, "a"), new SE(-2, "b"), new SE(1, "c"), new SE(2, "d")],
                                                                             [new SE(2, "d"), new SE(1, "c"), new SE(-1, "a"), new SE(-2, "b")]);

        Add(null, [new SE(-1, "a"), new SE(-1, null), new SE(null, "d"), null, null], [null, null, new SE(null, "d"), new SE(-1, null), new SE(-1, "a")]);
        Add(reverseSomeEntityComparer, [new SE(-1, "a"), new SE(-1, null), new SE(null, "d"), null, null], [new SE(-1, "a"), new SE(-1, null), new SE(null, "d"), null, null]);

        SE entity1 = new(null, null);
        SE entity2 = new(null, "a");
        SE entity3 = new(1, null);
        SE entity4 = new(1, "a");

        Add(null, [entity4, entity3, entity1, entity2], [entity1, entity2, entity3, entity4]);
        Add(reverseSomeEntityComparer, [entity4, entity3, entity1, entity2], [entity4, entity3, entity2, entity1]);

        Add(null, [entity4, entity2, entity4, entity4, entity3, entity1, entity2], [entity1, entity2, entity2, entity3, entity4, entity4, entity4]);
        Add(reverseSomeEntityComparer, [entity4, entity2, entity4, entity4, entity3, entity1, entity2], [entity4, entity4, entity4, entity3, entity2, entity2, entity1]);

        SE entity5 = new(null, "aA");
        SE entity6 = new(1, "Aa");
        SE entity7 = new(1, "aA");
        Add(null, [entity7, entity5, entity6], [entity5, entity6, entity7]);
        Add(reverseSomeEntityComparer, [entity7, entity5, entity6], [entity7, entity6, entity5]);
    }
}

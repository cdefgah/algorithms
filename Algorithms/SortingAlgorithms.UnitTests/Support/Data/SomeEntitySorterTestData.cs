// Declaring this alias, to make the code more readable
using SE = Cdefgah.SortingAlgorithms.UnitTests.Support.SomeEntity;

namespace SortingAlgorithms.UnitTests.Support.Data;

internal sealed class SomeEntitySorterTestData : TheoryData<IList<SE?>, IList<SE?>>
{
    public SomeEntitySorterTestData()
    {
        Add([], []);
        Add([ null ], [ null ]); 
        Add([ new SE(null, null) ], [ new SE(null, null) ]); 
        Add([new SE(1, "a"), new SE(null, "a")], [new SE(null, "a"), new SE(1, "a")]); 
        Add([new SE(null, "a"), new SE(null, "b")], [new SE(null, "a"), new SE(null, "b")]);
        Add([new SE(null, "b"), new SE(null, "a")], [new SE(null, "a"), new SE(null, "b")]);
        Add([new SE(null, "b"), new SE(null, "a"), new SE(null, null)], [new SE(null, null), new SE(null, "a"), new SE(null, "b")]);
        Add([new SE(-3, "w"), new SE(-2, "v"), new SE(-1, "y")], [new SE(-3, "w"), new SE(-2, "v"), new SE(-1, "y")]);
        Add([new SE(-3, "x"), new SE(-2, "b"), new SE(-2, "a")], [new SE(-3, "x"), new SE(-2, "a"), new SE(-2, "b")]);
        Add([new SE(-1, "c"), new SE(-2, "b"), new SE(-3, "a")], [new SE(-3, "a"), new SE(-2, "b"), new SE(-1, "c")]);
        Add([new SE(1, "x"), null, new SE(2, "a")], [null, new SE(1, "x"), new SE(2, "a")]);
        Add([new SE(3, "c"), new SE(2, "b"), new SE(1, "a")], [new SE(1, "a"), new SE(2, "b"), new SE(3, "c")]);
        Add([new SE(3, "a"), new SE(2, "b"), new SE(1, "c")], [new SE(1, "c"), new SE(2, "b"), new SE(3, "a")]);
        Add([new SE(1, "a"), new SE(2, "b"), new SE(3, "c"), new SE(4, "d")], [new SE(1, "a"), new SE(2, "b"), new SE(3, "c"), new SE(4, "d")]);
        Add([new SE(4, "a"), new SE(3, "b"), new SE(2, "c"), new SE(1, "d")], [new SE(1, "d"), new SE(2, "c"), new SE(3, "b"), new SE(4, "a")]);
        Add([new SE(4, "a"), new SE(4, "a"), new SE(4, "a"), new SE(4, "a")], [new SE(4, "a"), new SE(4, "a"), new SE(4, "a"), new SE(4, "a")]);
        Add([new SE(int.MaxValue, "a"), new SE(int.MinValue, "a"), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a")], 
                                  [new SE(int.MinValue, "a"), new SE(int.MinValue, "a"), new SE(int.MaxValue, "a"), new SE(int.MaxValue, "a")]);
        Add([new SE(int.MaxValue, null), new SE(int.MinValue, null), new SE(int.MaxValue, "a"), new SE(int.MinValue, "a")],
                                  [new SE(int.MinValue, null), new SE(int.MinValue, "a"), new SE(int.MaxValue, null), new SE(int.MaxValue, "a")]);
        Add([new SE(int.MaxValue, "a"), new SE(1, "a"), new SE(int.MaxValue, null), new SE(2, "a")],
                                                        [new SE(1, "a"), new SE(2, "a"), new SE(int.MaxValue, null), new SE(int.MaxValue, "a")]);
        Add([new SE(-1, "a"), new SE(-2, "b"), new SE(1, "c"), new SE(2, "d")], [new SE(-2, "b"), new SE(-1, "a"), new SE(1, "c"), new SE(2, "d")]);
        Add([new SE(-1, "a"), new SE(-1, null), new SE(null, "d"), null, null], [null, null, new SE(null, "d"), new SE(-1, null), new SE(-1, "a")]);

        SE entity1 = new(null, null);
        SE entity2 = new(null, "a");
        SE entity3 = new(1, null);
        SE entity4 = new(1, "a");

        Add([entity4, entity3, entity1, entity2], [entity1, entity2, entity3, entity4]);
        Add([entity4, entity2, entity4, entity4, entity3, entity1, entity2], [entity1, entity2, entity2, entity3, entity4, entity4, entity4]);

        SE entity5 = new(null, "aA");
        SE entity6 = new(1, "Aa");
        SE entity7 = new(1, "aA");
        Add([entity7, entity5, entity6], [entity5, entity6, entity7]);
    }
}

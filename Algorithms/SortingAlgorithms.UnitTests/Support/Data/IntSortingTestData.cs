namespace SortingAlgorithms.UnitTests.Support.Data;

internal class IntSortingTestData : TheoryData<IList<int>, IList<int>>
{
    public IntSortingTestData()
    {
        Add([], []); // empty list
        Add([1], [1]); // list with single positive element
        Add([-1], [-1]); // list with single negative element
        Add([1, 1], [1, 1]); // list with two duplicate positive elements
        Add([1, 2], [1, 2]); // list with two different ordered positive elements
        Add([2, 1], [1, 2]); // list with two different positive elements, ordered in reverse
        Add([-1, -1], [-1, -1]); // list with two duplicate negative elements
        Add([-2, -1], [-2, -1]); // list with two different ordered negative elements
        Add([-1, -1, -1], [-1, -1, -1]); // list with three duplicate negative elements
        Add([1, 1, 1], [1, 1, 1]); // list with three duplicate positive elements
        Add([1, 2, 1], [1, 1, 2]); // list with three different unordered elements, where 2 elements are the same
        Add([1, 1, 2], [1, 1, 2]); // list with three different ordered elements, where 2 elements are the same
        Add([2, 1, 1], [1, 1, 2]); // list with three different reverse ordered elements, where 2 elements are the same
        Add([1, 2, 3], [1, 2, 3]); // list with three different ordered elements
        Add([-3, 1, 2], [-3, 1, 2]); // list with three different ordered elements with negative numbers
        Add([-1, 3, -2], [-2, -1, 3]); // list with three different unordered elements with negative numbers
        Add([int.MaxValue, int.MinValue, 1], [int.MinValue, 1, int.MaxValue]); // unordered list with min and max int values
        Add([int.MinValue, -123, int.MaxValue], [int.MinValue, -123, int.MaxValue]); // ordered list with min and max int values
        Add([3, -11, 2, int.MinValue, 14, -8, int.MinValue, 0, int.MaxValue], [int.MinValue, int.MinValue, -11, -8, 0, 2, 3, 14, int.MaxValue]); // unordered list with min and max int values
        Add([int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue], [int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue]); // ordered list with min and max int values
        Add([int.MaxValue, 140000, 300, 20, 0, -30, -500, -99999, int.MinValue, int.MinValue], [int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue]); // reverse ordered list with min and max int values
        Add([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]); // ordered list with only positive elements
        Add([-10, -9, -8, -7, -6, -5, -4, -3, -2, -1], [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1]); // ordered list with only negative elements
        Add([-10, -9, -8, -7, -6, 0, 1, 2, 3, 4], [-10, -9, -8, -7, -6, 0, 1, 2, 3, 4]); // ordered list with mixed elements
        Add([10, 9, 8, 7, 6, 5, 4, 3, 2, 1], [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]); // reverse ordered list with only positive elements
        Add([-1, -2, -3, -4, -5, -6, -7, -8, -9, -10], [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1]); // reverse ordered list with only negative elements
        Add([5, 4, 3, 2, 1, 0, -1, -2, -3, -4], [-4, -3, -2, -1, 0, 1, 2, 3, 4, 5]); // reverse ordered list with mixed elements
    }
}

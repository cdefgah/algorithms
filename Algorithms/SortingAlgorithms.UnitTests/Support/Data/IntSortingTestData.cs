using SortingAlgorithms.UnitTests.Support.Utils;

namespace SortingAlgorithms.UnitTests.Support.Data;

internal sealed class IntSortingTestData : TheoryData<IComparer<int>?, IList<int>, IList<int>>
{
    public IntSortingTestData()
    {
        var reverseIntComparer = new ReverseIntComparer();

        // empty list
        Add(null, [], []); 
        Add(reverseIntComparer, [], []);

        // list with single positive element
        Add(null, [1], [1]); 
        Add(reverseIntComparer, [1], [1]);

        // list with single negative element
        Add(null, [-1], [-1]); 
        Add(reverseIntComparer, [-1], [-1]);

        // list with two duplicate positive elements
        Add(null, [1, 1], [1, 1]);
        Add(reverseIntComparer, [1, 1], [1, 1]);

        // list with two different ordered positive elements
        Add(null, [1, 2], [1, 2]);
        Add(reverseIntComparer, [1, 2], [2, 1]);

        // list with two different positive elements, ordered in reverse
        Add(null, [2, 1], [1, 2]);
        Add(reverseIntComparer, [2, 1], [2, 1]);

        // list with two duplicate negative elements
        Add(null, [-1, -1], [-1, -1]);
        Add(reverseIntComparer, [-1, -1], [-1, -1]);

        // list with two different ordered negative elements
        Add(null, [-2, -1], [-2, -1]);
        Add(reverseIntComparer, [-2, -1], [-1, -2]);

        // list with three duplicate negative elements
        Add(null, [-1, -1, -1], [-1, -1, -1]);
        Add(reverseIntComparer, [-1, -1, -1], [-1, -1, -1]);

        // list with three duplicate positive elements
        Add(null, [1, 1, 1], [1, 1, 1]);
        Add(reverseIntComparer, [1, 1, 1], [1, 1, 1]);

        // list with three different unordered elements, where 2 elements are the same
        Add(null, [1, 2, 1], [1, 1, 2]);
        Add(reverseIntComparer, [1, 2, 1], [2, 1, 1]);

        // list with three different ordered elements, where 2 elements are the same
        Add(null, [1, 1, 2], [1, 1, 2]);
        Add(reverseIntComparer, [1, 1, 2], [2, 1, 1]);

        // list with three different reverse ordered elements, where 2 elements are the same
        Add(null, [2, 1, 1], [1, 1, 2]);
        Add(reverseIntComparer, [2, 1, 1], [2, 1, 1]);

        // list with three different ordered elements
        Add(null, [1, 2, 3], [1, 2, 3]);
        Add(reverseIntComparer, [1, 2, 3], [3, 2, 1]);

        // list with three different ordered elements with negative numbers
        Add(null, [-3, 1, 2], [-3, 1, 2]);
        Add(reverseIntComparer, [-3, 1, 2], [2, 1, -3]);

        // list with three different unordered elements with negative numbers
        Add(null, [-1, 3, -2], [-2, -1, 3]);
        Add(reverseIntComparer, [-1, 3, -2], [3, -1, -2]);

        // Adding a list with non-sequential duplicates
        Add(null, [1, 3, 1, 2], [1, 1, 2, 3]);
        Add(reverseIntComparer, [1, 3, 1, 2], [3, 2, 1, 1]);

        // Adding a list with non-sequential duplicates
        Add(null, [1, 3, 1, 2, 1, 3], [1, 1, 1, 2, 3, 3]);
        Add(reverseIntComparer, [1, 3, 1, 2, 1, 3], [3, 3, 2, 1, 1, 1]);

        // Adding a list with zeroes
        Add(null, [0, -2, 0, 5, 0], [-2, 0, 0, 0, 5]);
        Add(reverseIntComparer, [0, -2, 0, 5, 0], [5, 0, 0, 0, -2]);

        // Adding a list with a specific pattern
        Add(null, [2, 4, 6, 8, 10], [2, 4, 6, 8, 10]);
        Add(reverseIntComparer, [2, 4, 6, 8, 10], [10, 8, 6, 4, 2]);

        // Adding a list with a specific pattern, in reverse order
        Add(null, [10, 8, 6, 4, 2], [2, 4, 6, 8, 10]);
        Add(reverseIntComparer, [10, 8, 6, 4, 2], [10, 8, 6, 4, 2]);

        // Adding a list with a specific down-up pattern
        Add(null, [10, 8, 6, 8, 10], [6, 8, 8, 10, 10]);
        Add(reverseIntComparer, [10, 8, 6, 8, 10], [10, 10, 8, 8, 6]);

        // Adding a list with a specific up-down pattern
        Add(null, [2, 4, 6, 8, 10, 8, 6, 4, 2], [2, 2, 4, 4, 6, 6, 8, 8, 10]);
        Add(reverseIntComparer, [2, 4, 6, 8, 10, 8, 6, 4, 2], [10, 8, 8, 6, 6, 4, 4, 2, 2]);

        // Adding list with sequential positive duplicates
        Add(null, [2, 2, 2, 3, 3, 3, 1, 1, 1], [1, 1, 1, 2, 2, 2, 3, 3, 3]);
        Add(reverseIntComparer, [2, 2, 2, 3, 3, 3, 1, 1, 1], [3, 3, 3, 2, 2, 2, 1, 1, 1]);

        // Adding list with sequential negative duplicates
        Add(null, [-2, -2, -2, -3, -3, -3, -1, -1, -1], [-3, -3, -3, -2, -2, -2, -1, -1, -1]);
        Add(reverseIntComparer, [-2, -2, -2, -3, -3, -3, -1, -1, -1], [-1, -1, -1, -2, -2, -2, -3, -3, -3]);

        // Adding list with sequential positive and negative duplicates
        Add(null, [-2, 2, -2, 3, -3, 3, 1, -1, 1], [-3, -2, -2, -1, 1, 1, 2, 3, 3]);
        Add(reverseIntComparer, [-2, 2, -2, 3, -3, 3, 1, -1, 1], [3, 3, 2, 1, 1, -1, -2, -2, -3]);

        // Adding a larger list with all elements being the same
        var sameElementsList = Enumerable.Repeat(5, 100).ToList();
        Add(null, sameElementsList, sameElementsList);
        Add(reverseIntComparer, sameElementsList, sameElementsList);

        // unordered list with min and max int values
        Add(null, [int.MaxValue, int.MinValue, 1], [int.MinValue, 1, int.MaxValue]);
        Add(reverseIntComparer, [int.MaxValue, int.MinValue, 1], [int.MaxValue, 1, int.MinValue]);

        // ordered list with min and max int values
        Add(null, [int.MinValue, -123, int.MaxValue], [int.MinValue, -123, int.MaxValue]);
        Add(reverseIntComparer, [int.MinValue, -123, int.MaxValue], [int.MaxValue, -123, int.MinValue]);

        // unordered list with min and max int values
        Add(null, [3, -11, 2, int.MinValue, 14, -8, int.MinValue, 0, int.MaxValue], [int.MinValue, int.MinValue, -11, -8, 0, 2, 3, 14, int.MaxValue]);
        Add(reverseIntComparer, [3, -11, 2, int.MinValue, 14, -8, int.MinValue, 0, int.MaxValue], [int.MaxValue, 14, 3, 2, 0, -8, -11, int.MinValue, int.MinValue]);

        // ordered list with min and max int values
        Add(null, [int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue], [int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue]);
        Add(reverseIntComparer, [int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue], [int.MaxValue, 140000, 300, 20, 0, -30, -500, -99999, int.MinValue, int.MinValue]);

        // reverse ordered list with min and max int values
        Add(null, [int.MaxValue, 140000, 300, 20, 0, -30, -500, -99999, int.MinValue, int.MinValue], [int.MinValue, int.MinValue, -99999, -500, -30, 0, 20, 300, 140000, int.MaxValue]);
        Add(reverseIntComparer, [int.MaxValue, 140000, 300, 20, 0, -30, -500, -99999, int.MinValue, int.MinValue], [int.MaxValue, 140000, 300, 20, 0, -30, -500, -99999, int.MinValue, int.MinValue]);

        // Adding a list with extreme values and duplicates
        Add(null, [int.MaxValue, int.MaxValue, int.MinValue, int.MinValue], [int.MinValue, int.MinValue, int.MaxValue, int.MaxValue]);
        Add(reverseIntComparer, [int.MaxValue, int.MaxValue, int.MinValue, int.MinValue], [int.MaxValue, int.MaxValue, int.MinValue, int.MinValue]);

        // ordered list with only positive elements
        Add(null, [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        Add(reverseIntComparer, [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]);

        // ordered list with only negative elements
        Add(null, [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1], [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1]);
        Add(reverseIntComparer, [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1], [-1, -2, -3, -4, -5, -6, -7, -8, -9, -10]);

        // ordered list with mixed elements
        Add(null, [-10, -9, -8, -7, -6, 0, 1, 2, 3, 4], [-10, -9, -8, -7, -6, 0, 1, 2, 3, 4]);
        Add(reverseIntComparer, [-10, -9, -8, -7, -6, 0, 1, 2, 3, 4], [4, 3, 2, 1, 0, -6, -7, -8, -9, -10]);

        // reverse ordered list with only positive elements
        Add(null, [10, 9, 8, 7, 6, 5, 4, 3, 2, 1], [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        Add(reverseIntComparer, [10, 9, 8, 7, 6, 5, 4, 3, 2, 1], [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]);

        // reverse ordered list with only negative elements
        Add(null, [-1, -2, -3, -4, -5, -6, -7, -8, -9, -10], [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1]);
        Add(reverseIntComparer, [-1, -2, -3, -4, -5, -6, -7, -8, -9, -10], [-1, -2, -3, -4, -5, -6, -7, -8, -9, -10]);

        // reverse ordered list with mixed elements
        Add(null, [5, 4, 3, 2, 1, 0, -1, -2, -3, -4], [-4, -3, -2, -1, 0, 1, 2, 3, 4, 5]);
        Add(reverseIntComparer, [5, 4, 3, 2, 1, 0, -1, -2, -3, -4], [5, 4, 3, 2, 1, 0, -1, -2, -3, -4]);

        // Adding large lists
        IEnumerable<int> largeIntDataSet = Enumerable.Range(1, 16384);
        List<int> orderedLargeNumbersList = [.. largeIntDataSet];
        List<int> reversedLargeNumbersList = [.. largeIntDataSet.Reverse()];

        Add(null, reversedLargeNumbersList, orderedLargeNumbersList);
        Add(reverseIntComparer, orderedLargeNumbersList, reversedLargeNumbersList);
    }
}

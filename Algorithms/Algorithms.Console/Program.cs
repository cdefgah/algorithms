using Cdefgah.SortingAlgorithms;

namespace Cdefgah.Algorithms;

public class Program
{
    static void Main(string[] args)
    {
        int[] array = [1, 3, 1, 2];
        QuickSorterHoareRecursive<int> sorter = new();
        sorter.Sort(array);

        string result = string.Join(',', array);

        Console.WriteLine(result);
    }
}

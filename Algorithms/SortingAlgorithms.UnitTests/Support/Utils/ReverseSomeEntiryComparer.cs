using Cdefgah.SortingAlgorithms.UnitTests.Support;

namespace SortingAlgorithms.UnitTests.Support.Utils;

[Serializable]
internal class ReverseSomeEntiryComparer : IComparer<SomeEntity>
{
    public int Compare(SomeEntity? x, SomeEntity? y) => -Comparer<SomeEntity>.Default.Compare(x, y);
}

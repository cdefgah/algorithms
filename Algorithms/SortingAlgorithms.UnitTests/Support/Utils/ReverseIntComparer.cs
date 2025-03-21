﻿namespace SortingAlgorithms.UnitTests.Support.Utils;

[Serializable]
internal class ReverseIntComparer : IComparer<int>
{
    public int Compare(int x, int y) => -Comparer<int>.Default.Compare(x, y);
}

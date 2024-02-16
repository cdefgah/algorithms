namespace Cdefgah.SortingAlgorithms.UnitTests.Support;

/// <summary>
/// Represents an entity with a comparable int value and a string value for test scripts.
/// </summary>
public sealed class SomeEntity : IComparable<SomeEntity>, IEquatable<SomeEntity>
{
    public SomeEntity(int? firstValue, string? secondValue)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
    }

    public int? FirstValue { get; } 
    public string? SecondValue { get; }

    public int CompareTo(SomeEntity? other)
    {
        // if passed object has the same reference
        if (ReferenceEquals(this, other))
        {
            return 0;
        }

        // null values are less than non-null values
        if (other is null)
        {
            return 1;
        }

        // comparing the first values
        int firstValueComparisonResult = Nullable.Compare(FirstValue, other.FirstValue);
        if (firstValueComparisonResult != 0)
        {
            return firstValueComparisonResult;
        }

        // if the first values are equal, comparing the second values
        return string.Compare(SecondValue, other.SecondValue, StringComparison.Ordinal);
    }

    public bool Equals(SomeEntity? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Nullable.Equals(FirstValue, other.FirstValue) &&
               string.Equals(SecondValue, other.SecondValue, StringComparison.Ordinal);
    }

    public override bool Equals(object? obj)
    {
        return obj is SomeEntity other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstValue, SecondValue);
    }

    public static bool operator ==(SomeEntity? left, SomeEntity? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(SomeEntity? left, SomeEntity? right)
    {
        return !Equals(left, right);
    }

    public override string ToString()
    {
        return $"SomeEntity [FirstValue={FirstValue}, SecondValue={SecondValue}]";
    }
}

using System.Diagnostics.CodeAnalysis;

internal class CheckEquality : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        throw new NotImplementedException();
    }

    public int GetHashCode([DisallowNull] string obj)
    {
        throw new NotImplementedException();
    }
}
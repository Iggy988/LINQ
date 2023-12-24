using System.Diagnostics.CodeAnalysis;

public class PetComparerById : IEqualityComparer<Pet>
{
    public bool Equals(Pet? x, Pet? y)
    {
        return x.Id == y.Id;
    }

    public int GetHashCode([DisallowNull] Pet obj)
    {
        return obj.Id;
    }
}

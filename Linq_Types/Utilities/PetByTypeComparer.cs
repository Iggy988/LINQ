

public class PetByTypeComparer : IComparer<Pet>
{
    public int Compare(Pet? x, Pet? y)
    {
        return x.PetType.CompareTo(y.PetType);
    }
}

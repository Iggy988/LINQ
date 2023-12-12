
public class Pet : IComparable<Pet>
{
    public int Id { get; }
    public string Name { get; }
    public PetType PetType { get; }
    public float Weight { get; }

    public Pet(int id, string name, PetType petType, float weight)
    {
        Id = id;
        Name = name;
        PetType = petType;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"id: {Id}, name: {Name}, pet type: {PetType}, weight: {Weight}";
    }

    public int CompareTo(Pet? other)
    {
        return Weight.CompareTo(other.Weight);
    }
}

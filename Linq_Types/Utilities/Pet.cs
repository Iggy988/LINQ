
public class Pet
{
    public int Id;
    public string Name;
    public PetType PetType;
    public float Weight;

    public Pet(int id, string name, PetType petType, float weight)
    {
        Id = id;
        Name = name;
        PetType = petType;
        Weight = weight;
    }
}

public class PetOwner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Pet[] Pets { get; set; }

    public PetOwner(int id, string name, Pet[] pets)
    {
        Id = id;
        Name = name;
        Pets = pets;
    }

    public override string ToString()
    {
       
        return $"id: {Id}, name: {Name}, pets: ";
    }
}
using System.Collections.Generic;

public class PetOwner
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public Pet[] Pets { get; set; }
    public IEnumerable<Pet> Pets;

    public PetOwner(int id, string name, IEnumerable<Pet> pets)
    {
        Id = id;
        Name = name;
        //Pets = pets;
        Pets = pets.Count() > 10 ? Enumerable.Empty<Pet>() : pets;
    }

    public override string ToString()
    {
       
        return $"id: {Id}, name: {Name}, pets: ";
    }
}
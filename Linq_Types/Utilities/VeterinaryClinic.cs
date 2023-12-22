internal class VeterinaryClinic
{
    public int Id { get; set; }
    public string Name { get; set; }

    public VeterinaryClinic(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
class Plane : IFlyable, IFuelable
{
    public void Fly()
    {
        Console.WriteLine("Flaying by motors");
    }

    public void Fuel()
    {
        Console.WriteLine("Fueling gas tank");
    }
}



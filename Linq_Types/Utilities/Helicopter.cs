class Helicopter : IFlyable, IFuelable
{
    public void Fly()
    {
        Console.WriteLine("Flaying by choppers");
    }

    public void Fuel()
    {
        Console.WriteLine("Fueling gas tank");
    }
}



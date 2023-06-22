using System;

public class ElectricGuitar : Guitar, Electric
{
    public ElectricGuitar(string name, int price) : base(name, price)
    {
    }

    public void brancher()
    {
        Console.WriteLine($"Electric guitar {name} is rocking!");
    }
}
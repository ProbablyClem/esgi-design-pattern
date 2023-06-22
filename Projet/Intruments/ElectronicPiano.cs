using System;

public class ElectronicPiano : Piano, Electric
{
    public ElectronicPiano(string name, int price) : base(name, price)
    {
    }

    public void brancher()
    {
        Console.WriteLine($"Electronic piano {name} is rocking!");
    }
}
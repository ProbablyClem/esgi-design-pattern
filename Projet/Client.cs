using System.Collections.Generic;

public class Client
{
    private string name { get; set; }
    private List<Instrument> instruments { get; set; } = new List<Instrument>();

    public Client(string name)
    {
        this.name = name;
    }
}
public abstract class Instrument
{
    protected string name { get; set; }
    protected int price { get; set; }

    public Instrument(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
}
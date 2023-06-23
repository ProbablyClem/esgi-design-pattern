using System;

public abstract class Instrument
{
    protected string name { get; set; }
    public int price { get; set; }

    public Instrument(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public Instrument duplique()
    {
        Instrument resultat;
        resultat = (Instrument)this.MemberwiseClone();
        return resultat;
    }

    public override string ToString()
    {
        return name + " : " + price;
    }

    public void affiche()
    {
        Console.WriteLine(this);
    }
}
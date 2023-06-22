public class FolkGuitar : Guitar, Acoustic
{
    public FolkGuitar(string name, int price) : base(name, price)
    {
    }

    public void ecouter()
    {
        System.Console.WriteLine("Ecouter FolkGuitar");
    }
}
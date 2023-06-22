public class AcousticPiano : Piano, Acoustic
{
    public AcousticPiano(string name, int price) : base(name, price)
    {
    }


    public void ecouter()
    {
        System.Console.WriteLine("Ecouter FolkGuitar");
    }
}
public class AcousticBuilder
{
    public static FolkGuitar BuildAcousticGuitar(string name, int price)
    {
        return new FolkGuitar(name, price);
    }
    public static AcousticPiano BuildAcousticPiano(string name, int price)
    {
        return new AcousticPiano(name, price);
    }
}
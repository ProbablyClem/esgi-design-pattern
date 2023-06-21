public class GuitarBuilder
{
    public ElectricGuitar BuildElectricGuitar(string name, int price)
    {
        return new ElectricGuitar(name, price);
    }

    public FolkGuitar BuildFolkGuitar(string name, int price)
    {
        return new FolkGuitar(name, price);
    }
}
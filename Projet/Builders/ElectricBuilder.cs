public class ElectricBuilder
{
    public ElectricGuitar BuildElectricGuitar(string name, int price)
    {
        return new ElectricGuitar(name, price);
    }

    public ElectronicPiano BuildElectronicPiano(string name, int price)
    {
        return new ElectronicPiano(name, price);
    }
}
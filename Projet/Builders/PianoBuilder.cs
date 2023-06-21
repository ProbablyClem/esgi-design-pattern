public class PianoBuilder
{
    public ElectronicPiano BuildElectronicPiano(string name, int price)
    {
        return new ElectronicPiano(name, price);
    }

    public ElectricGuitar BuildElectricGuitar(string name, int price)
    {
        return new ElectricGuitar(name, price);
    }
}
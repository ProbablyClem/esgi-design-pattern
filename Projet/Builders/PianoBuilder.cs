public class PianoBuilder
{
    public ElectronicPiano BuildElectronicPiano(string name, int price)
    {
        return new ElectronicPiano(name, price);
    }

    public AcousticPiano BuildAcousticPiano(string name, int price)
    {
        return new AcousticPiano(name, price);
    }
}
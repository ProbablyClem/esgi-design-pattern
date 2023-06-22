public class AcousticAdapter : Acoustic
{
    private Electric _electric;
    public AcousticAdapter(Electric electric)
    {
        _electric = electric;
    }
    public void ecouter()
    {
        _electric.brancher();
    }
}
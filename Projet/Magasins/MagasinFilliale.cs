public class MagasinFilliale : Magasin
{
    public override int getNombreInstruments()
    {
        return stock.GetInstruments().Count;
    }
}
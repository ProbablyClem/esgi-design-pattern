public abstract class Magasin
{
    public StockMagasin stock { get; set; }

    public Magasin()
    {
        stock = new StockMagasin();
    }

    public abstract int getNombreInstruments();
}
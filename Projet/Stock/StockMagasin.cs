public class StockMagasin : Stock
{
    public StockMagasin()
    {
        StockVierge stockVierge = StockVierge.Instance();
        foreach (var instrument in stockVierge.GetInstruments())
        {
            Add(instrument.duplique());
        }
    }
}
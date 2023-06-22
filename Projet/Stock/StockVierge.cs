public class StockVierge : Stock
{
    private static StockVierge _instance;
    private StockVierge() { }
    public static StockVierge Instance()
    {
        if (_instance == null)
        {
            _instance = new StockVierge();
        }
        return _instance;
    }
}
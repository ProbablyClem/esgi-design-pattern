public class CatalogueInstrument : Catalogue<Instrument, IterateurInstrument>
{
    public CatalogueInstrument()
    {
        //Utilisation du pattern prototype pour créer les instruments
        contenu = StockVierge.Instance().GetInstruments();
    }
}
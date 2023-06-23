using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockVierge stockVierge = StockVierge.Instance();
            InstrumentFactory instrumentFactory;
            instrumentFactory = new GuitarFactory();
            stockVierge.AddAll(instrumentFactory.MakeInstruments(10));
            instrumentFactory = new PianoFactory();
            stockVierge.AddAll(instrumentFactory.MakeInstruments(10));

            Magasin magasin = new MagasinFactory().createMagasinMere();
            Console.WriteLine(magasin.getNombreInstruments());

            //Adapter
            Acoustic acousticAdapter = new AcousticAdapter(new ElectricGuitar("Martin", 100));
            acousticAdapter.ecouter();

            //Iterator

            //On veut afficher les instruments du catalogue dont le prix est inférieur à 500
            CatalogueInstrument catalogueInstrument = new CatalogueInstrument();
            IterateurInstrument iterateurInstrument = catalogueInstrument.recherchePrixMax(500);
            Instrument instrument;
            iterateurInstrument.debut();
            instrument = iterateurInstrument.item();
            while (instrument != null)
            {
                instrument.affiche();
                iterateurInstrument.suivant();
                instrument = iterateurInstrument.item();
            }
            while (instrument != null)
            {
                instrument.affiche();
                iterateurInstrument.suivant();
                instrument = iterateurInstrument.item();
            }
        }
    }
}
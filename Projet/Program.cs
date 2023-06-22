using System;

namespace MyApp // Note: actual namespace depends on the project name.
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

            StockMagasin stockMagasin = new StockMagasin();
            stockMagasin.Print();


            //Adapter
            AcousticAdapter acousticAdapter = new AcousticAdapter(new ElectricGuitar("Martin", 100));
            acousticAdapter.ecouter();

        }
    }
}
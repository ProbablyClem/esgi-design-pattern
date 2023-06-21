using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = Stock.Instance();
            stock.AddAll(new GuitarFactory().MakeInstruments(10));
            stock.AddAll(new PianoFactory().MakeInstruments(10));
            stock.Print();
        }
    }
}
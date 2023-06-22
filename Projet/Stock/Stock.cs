using System;
using System.Collections.Generic;

public abstract class Stock
{

    private List<Instrument> _instruments = new List<Instrument>();
    public void Add(Instrument instrument)
    {
        _instruments.Add(instrument);
    }
    public void AddAll(List<Instrument> instruments)
    {
        foreach (Instrument instrument in instruments)
        {
            _instruments.Add(instrument);
        }
    }

    public List<Instrument> GetInstruments()
    {
        return _instruments;
    }
    public void Remove(Instrument instrument)
    {
        _instruments.Remove(instrument);
    }
    public void Print()
    {
        foreach (Instrument instrument in _instruments)
        {
            Console.WriteLine(instrument);
        }
    }
}
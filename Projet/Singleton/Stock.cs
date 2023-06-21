using System;
using System.Collections.Generic;

public class Stock
{
    private static Stock _instance;
    private Stock() { }
    public static Stock Instance()
    {
        if (_instance == null)
        {
            _instance = new Stock();
        }
        return _instance;
    }
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
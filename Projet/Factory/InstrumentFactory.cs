using System.Collections.Generic;

public abstract class InstrumentFactory
{
    public abstract List<Instrument> MakeInstruments(int quantity);
}
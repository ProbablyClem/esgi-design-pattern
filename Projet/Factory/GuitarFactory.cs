using System;
using System.Collections.Generic;

public class GuitarFactory : InstrumentFactory
{
    public override List<Instrument> MakeInstruments(int quantity)
    {
        Random random = new Random();
        List<Instrument> instruments = new List<Instrument>();
        for (int i = 0; i < quantity; i++)
        {
            var b = random.Next(2);
            GuitarBuilder GuitarBuilder = new GuitarBuilder();
            if (b == 0)
            {
                instruments.Add(GuitarBuilder.BuildElectricGuitar("Guitar", 1000));
            }
            else
            {
                instruments.Add(GuitarBuilder.BuildFolkGuitar("Guitar", 1000));
            }

        }
        return instruments;
    }
}
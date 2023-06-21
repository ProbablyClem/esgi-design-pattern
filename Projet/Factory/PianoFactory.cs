using System;
using System.Collections.Generic;

public class PianoFactory : InstrumentFactory
{
    public override List<Instrument> MakeInstruments(int quantity)
    {
        Random random = new Random();
        List<Instrument> instruments = new List<Instrument>();
        for (int i = 0; i < quantity; i++)
        {
            var b = random.Next(2);
            PianoBuilder pianoBuilder = new PianoBuilder();
            if (b == 0)
            {
                instruments.Add(pianoBuilder.BuildElectronicPiano("Piano", 1000));
            }
            else
            {
                instruments.Add(pianoBuilder.BuildAcousticPiano("Piano", 1000));
            }

        }
        return instruments;
    }
}
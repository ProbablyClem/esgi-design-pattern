using System.Collections.Generic;

public class MagasinMere : Magasin
{
    List<Magasin> filliales { get; set; } = new List<Magasin>();

    public void AddFilliale(Magasin filliale)
    {
        filliales.Add(filliale);
    }

    public override int getNombreInstruments()
    {
        int nombreInstruments = 0;
        foreach (Magasin filliale in filliales)
        {
            nombreInstruments += filliale.getNombreInstruments();
        }
        return nombreInstruments + stock.GetInstruments().Count;
    }

}
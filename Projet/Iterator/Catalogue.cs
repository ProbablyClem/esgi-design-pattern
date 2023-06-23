using System;
using System.Collections.Generic;

public abstract class Catalogue<TInstrument, TIterateur>
  where TInstrument : Instrument
  where TIterateur : Iterateur<TInstrument>, new()
{
    protected IList<TInstrument> contenu = new List<TInstrument>();

    public TIterateur recherchePrixMax(int prixMax)
    {
        TIterateur resultat = new TIterateur();
        resultat.prixMax = prixMax;
        resultat.contenu = contenu;
        return resultat;
    }
}

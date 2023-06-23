using System.Collections.Generic;

public abstract class Iterateur<TInstrument>
  where TInstrument : Instrument
{
    public int prixMax { protected get; set; }
    protected int index;
    public IList<TInstrument> contenu { protected get; set; }


    public void debut()
    {
        index = 0;
        int taille = contenu.Count;
        while ((index < taille) &&
          (contenu[index].price > prixMax))
            index++;
    }

    public void suivant()
    {
        int taille = contenu.Count;
        index++;
        while ((index < taille) &&
          (contenu[index].price > prixMax))
            index++;
    }

    public TInstrument item()
    {
        if (index < contenu.Count)
            return contenu[index];
        else
            return null;
    }
}

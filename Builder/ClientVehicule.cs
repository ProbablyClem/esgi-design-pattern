using System;

public abstract class ClientVehicule
{
    static void Main(string[] args)
    {
        Vendeur vendeur = new Vendeur();
        Liasse liasse = vendeur.construit();
        liasse.imprime();

        new ConstructeurLiasseVehiculePdf().construitBonDeCommande().resultat().imprime();
        new ConstructeurLiasseVehiculeHtml().construitDemandeImmactriculation().resultat().imprime();
    }
}
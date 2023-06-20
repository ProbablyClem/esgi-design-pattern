public class Vendeur
{
    public Liasse construit()
    {
        ConstructeurLiasseVehiculePdf constructeur = new ConstructeurLiasseVehiculePdf();
        return constructeur.construitBonDeCommande().construitDemandeImmactriculation().resultat();
    }
}
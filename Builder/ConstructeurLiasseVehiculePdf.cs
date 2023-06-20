public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{

    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new LiassePdf();
    }

    public override ConstructeurLiasseVehicule construitBonDeCommande()
    {
        liasse.ajouteDocument("Bon de commande PDF");
        return this;
    }

    public override ConstructeurLiasseVehicule construitDemandeImmactriculation()
    {
        liasse.ajouteDocument("Demande d'immatriculation PDF");
        return this;
    }
}
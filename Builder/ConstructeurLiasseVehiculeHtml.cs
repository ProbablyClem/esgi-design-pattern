public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new LiasseHtml();
    }
    public override ConstructeurLiasseVehicule construitBonDeCommande()
    {
        liasse.ajouteDocument("Bon de commande Html");
        return this;
    }

    public override ConstructeurLiasseVehicule construitDemandeImmactriculation()
    {
        liasse.ajouteDocument("Demande d'immatriculation Html");
        return this;
    }
}
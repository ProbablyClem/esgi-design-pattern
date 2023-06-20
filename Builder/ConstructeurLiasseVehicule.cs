public abstract class ConstructeurLiasseVehicule
{
    protected Liasse? liasse;
    public abstract ConstructeurLiasseVehicule construitBonDeCommande();

    public abstract ConstructeurLiasseVehicule construitDemandeImmactriculation();

    public Liasse resultat()
    {
        return liasse;
    }
}
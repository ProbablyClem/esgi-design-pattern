using System;

public class Utilisateur
{
    static void Main(string[] args)
    {
        Client client;
        client = new ClientComptant();
        client.nouvelleCommande(2000.0);
        client.nouvelleCommande(10000.0);
        client = new ClientCredit();
        client.nouvelleCommande(2000.0);
        client.nouvelleCommande(10000.0);
    }
}

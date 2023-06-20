using System;

public class LiasseHtml : Liasse
{
    public override void ajouteDocument(string document)
    {
        contenu.Add(document);
    }

    public override void imprime()
    {
        Console.WriteLine("Liasse HTML");
        foreach (string s in contenu)
        {
            Console.WriteLine(s);
        }
    }
}
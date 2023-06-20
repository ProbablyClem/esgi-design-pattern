using System;

public class LiassePdf : Liasse
{
    public override void ajouteDocument(string document)
    {
        contenu.Add(document);
    }

    public override void imprime()
    {
        Console.WriteLine("Liasse Pdf");
        foreach (string s in contenu)
        {
            Console.WriteLine(s);
        }
    }
}
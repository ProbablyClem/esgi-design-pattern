public class MagasinFactory
{
    public MagasinMere createMagasinMere()
    {
        MagasinMere magasinMere = new MagasinMere();
        magasinMere.AddFilliale(new MagasinFilliale());
        magasinMere.AddFilliale(new MagasinFilliale());

        MagasinMere magasinFilliale = new MagasinMere();
        magasinFilliale.AddFilliale(new MagasinFilliale());

        magasinMere.AddFilliale(magasinFilliale);

        return magasinMere;
    }
}
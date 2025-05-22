namespace DesignPatternWorkshop.Proxy;

public class Film : Animation
{
    public override void Clic()
    {
        Console.WriteLine("*Clique sur le film*");
    }

    public override void Draw()
    {
        Console.WriteLine("Dessin du Film...");
    }

    public void Load()
    {
        Console.WriteLine("Chargement du Film...");
    }

    public void Play()
    {
        Console.WriteLine("Lancement de la vidéo");
    }
}
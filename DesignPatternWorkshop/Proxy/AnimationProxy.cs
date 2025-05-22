namespace DesignPatternWorkshop.Proxy;

public class AnimationProxy : Animation 
{
    private readonly string _photo = "image.png";
    private Film film;
    
    public override void Clic()
    {
        if (film == null)
        {
            film = new Film();
            film.Load();
        }
        film.Play();
    }

    public override void Draw()
    {
        if (film != null)
        {
            film.Draw();
        }
        else
        {
            DrawPhoto();
        }
    }

    private void DrawPhoto()
    {
        Console.WriteLine($"Affichage de la photo : {_photo}");
    }
}
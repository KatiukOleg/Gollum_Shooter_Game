
namespace Gollum_Shooter_Game
{
    // enums
    enum Heroes
    {
        Gollum = 1,
        Frodo = 2
    }
    
    // classes
    public abstract class Heroe
    {
        public string Name { get; set; }
    }

    public class Gollum : Heroe, IScreamable
    {
        public void Scream()
        {
            System.Media.SoundPlayer gollumScreaming = new System.Media.SoundPlayer(@"Audio\Gollum_voice.wav");
            gollumScreaming.Play();
        }
    }

    public class Hobbit : Heroe, IScreamable
    {
        public void Scream()
        {
            System.Media.SoundPlayer hobbitScreaming = new System.Media.SoundPlayer(@"Audio\Frodo_voice.wav");
            hobbitScreaming.Play();
        }
    }


}


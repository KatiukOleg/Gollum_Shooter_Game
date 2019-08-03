using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gollum_Shooter_Game
{
    public static class GameSounds
    {
        static System.Media.SoundPlayer _welcomeTrack;
        static System.Media.SoundPlayer _winTrack;
        static System.Media.SoundPlayer _loseTrack;

        // general methods
        public static void PlayWelcomeTrack()
        {
            _welcomeTrack = new System.Media.SoundPlayer(@"Audio\bridge_to_Hazadum.wav");
            _welcomeTrack.Play();
        }

        public static void StopWelcomeTrack()
        {
            _welcomeTrack.Stop();
        }

        public static void PlayWinTrack()
        {
            _winTrack = new System.Media.SoundPlayer(@"Audio\Brave_Heart_Win.wav");
            _winTrack.Play();
        }

        public static void StopWinTrack()
        {
            if (_winTrack != null)
            {
                _winTrack.Stop();
            }  
        }

        public static void PlayLoseTrack()
        {
            _loseTrack = new System.Media.SoundPlayer(@"Audio\Brave_Heart_Lose.wav");
            _loseTrack.Play();
        }

        public static void StopLoseTrack()
        {
            if (_loseTrack != null)
            {
                _loseTrack.Stop();
            }   
        }
    }
}

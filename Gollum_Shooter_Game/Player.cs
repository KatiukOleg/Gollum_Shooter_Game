using System.Windows.Forms;

namespace Gollum_Shooter_Game
{
    // enums
    enum State
    {
        InGame,
        Won,
        Lost
    }

    // classes
    class Player
    {
        public delegate void ScoreStateHandler(string message);
        ScoreStateHandler scoreStateDel;

        public void RegisterHandler(ScoreStateHandler del)
        {
            scoreStateDel = del;
        }

        // instance members
        private int _score;
        private int _level = 1;
        private State state = State.InGame;
        
        // constructor
        public Player(int score)
        {
            _score = score;
            RegisterHandler(new Player.ScoreStateHandler(MainForm.Show_Message));
        }

        // property methods
        public int CurrentScore
        {
            get { return _score; }
            set { _score = value; }
        }

        public int CurrentLevel
        {
            get { return _level; }
            set { _level = value; }
        }

        public State CurrentState
        {
            get { return state; }
            set { state = value; }
        }

        // general methods
        public void IncrementScore(int score, Label Score, Label Level)
        {
            if (_score < 10)
            {
                _score += score;
                Score.Text = "Score:" + _score.ToString();
                Level.Text = "Level:" + _level.ToString();
                if (scoreStateDel != null)
                {
                    scoreStateDel.Invoke("Score increments to " + _score.ToString());
                }
            }
            else if (_score == 10 & _level == 1)
            {
                _score = 0;
                if (_level == 1)
                {
                    _level = 2;
                }

                if (scoreStateDel != null)
                {
                    scoreStateDel.Invoke("Congratulations! You reached next level!!!");
                }
                Score.Text = "Score:" + _score.ToString();
                Level.Text = "Level:" + _level.ToString();
            }
            else if (_score == 10 & _level == 2)
            {
                if (scoreStateDel != null)
                {
                    scoreStateDel.Invoke("Congratulations! You win!!!");
                    _level = 1;
                    _score = 0;
                    state = State.Won;
                }
            }
        }

        public void DecrementScore(int score, Label Score, Label Level)
        {
            if (score <= _score)
            {
                _score -= score;
                Score.Text = "Score:" + _score.ToString();
                Level.Text = "Level:" + _level.ToString();
                if (scoreStateDel != null)
                {
                    scoreStateDel.Invoke("Score decrements to " + _score.ToString());
                }
            }

            if (_score == 0)
            {
                if (scoreStateDel != null)
                {
                    scoreStateDel.Invoke("Game is over! Please try again.");
                    _level = 1;
                    state = State.Lost;
                }
            }
        }
    }
}

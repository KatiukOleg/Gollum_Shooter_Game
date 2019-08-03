using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Gollum_Shooter_Game
{
    public partial class MainForm : Form
    {
        Player player = new Player(0);
        static Stack<string> messages = new Stack<string>();

        public MainForm()
        {
            InitializeComponent();
            GameSounds.PlayWelcomeTrack();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Pictures\Places\Mirkwood3.jpg");
            GollumPictureBox1.Visible = true;
            lblScore.Visible = true;
            lblLevel.Visible = true;
            listBoxStatus.Visible = true;
            btnStart.Visible = false;
            lblIntro.Visible = false;
            //track.Stop();
            GameSounds.StopWelcomeTrack();
            btnRestart.Enabled = true;
            this.Cursor = Cursor.ArchedCursor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.CurrentState == State.InGame)
            {
                Random random = new Random();
                int x = random.Next(0, 600);
                int y = random.Next(100, 250);

                if (player.CurrentLevel == 1)
                {
                    GollumPictureBox1.Location = new Point(x, y);
                }
                else if (player.CurrentLevel == 2)
                {
                    PictureBox[] pictures = { GollumPictureBox1, FrodoPictureBox };
                    Random randomForPictures = new Random();
                    int index = randomForPictures.Next(0, 2);
                    
                    switch (index)
                    {
                        case 0: // Gollum
                            GollumPictureBox1.Visible = true;
                            FrodoPictureBox.Visible = false;
                            GollumPictureBox1.Location = new Point(x, y);
                            break;
                        case 1: // Frodo
                            FrodoPictureBox.Visible = true;
                            GollumPictureBox1.Visible = false;
                            FrodoPictureBox.Location = new Point(x, y);
                            break;
                    }
                }
            }
            else if (player.CurrentState == State.Lost)
            {
                timer1.Stop();
                ResetGameOptions(lblGameIsOver);
                Thread.Sleep(2000);
                GameSounds.PlayLoseTrack();
            }
            else if (player.CurrentState == State.Won)
            {
                timer1.Stop();
                ResetGameOptions(lblWin);
                Thread.Sleep(2000);
                GameSounds.PlayWinTrack();
            }
        }

        private void ResetGameOptions(Label label)
        {
            GollumPictureBox1.Visible = false;
            FrodoPictureBox.Visible = false;
            lblScore.Text = "Score:0";
            lblLevel.Text = "Level:1";
            label.Visible = true;
        }

        private void GollumPictureBox1_Click(object sender, EventArgs e)
        {
            player.IncrementScore(1, lblScore, lblLevel);
            listBoxStatus.Items.Clear();
            listBoxStatus.Items.AddRange(messages.ToArray());

            Gollum gollum = new Gollum();
            gollum.Scream();
        }

        private void FrodoPictureBox_Click(object sender, EventArgs e)
        {
            player.DecrementScore(1, lblScore, lblLevel);
            listBoxStatus.Items.Clear();
            listBoxStatus.Items.AddRange(messages.ToArray());

            Hobbit frodo = new Hobbit();
            frodo.Scream();
        }

        private void IntroTimer_Tick(object sender, EventArgs e)
        {
            if (lblIntro.Left < this.Width)
            {
                lblIntro.Left = lblIntro.Left + 10;
            }
            else
            {
                lblIntro.Left = 0;
            }
        }

        public static void Show_Message(string message)
        {
            messages.Push(message);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GollumPictureBox1.Visible = true;
            lblGameIsOver.Visible = false;
            lblWin.Visible = false;
            player.CurrentState = State.InGame;
            player.CurrentLevel = 1;
            player.CurrentScore = 0;
            lblScore.Text = "Score:0";
            lblLevel.Text = "Level:1";
            GameSounds.StopLoseTrack();
            GameSounds.StopWinTrack();
        }
    }
}

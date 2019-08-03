namespace Gollum_Shooter_Game
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GollumPictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.IntroTimer = new System.Windows.Forms.Timer(this.components);
            this.FrodoPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGameIsOver = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GollumPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrodoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(22, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(143, 37);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:0";
            this.lblScore.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(742, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(742, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GollumPictureBox1
            // 
            this.GollumPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.GollumPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GollumPictureBox1.Image")));
            this.GollumPictureBox1.Location = new System.Drawing.Point(314, 200);
            this.GollumPictureBox1.Name = "GollumPictureBox1";
            this.GollumPictureBox1.Size = new System.Drawing.Size(80, 174);
            this.GollumPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GollumPictureBox1.TabIndex = 3;
            this.GollumPictureBox1.TabStop = false;
            this.GollumPictureBox1.Visible = false;
            this.GollumPictureBox1.Click += new System.EventHandler(this.GollumPictureBox1_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Gold;
            this.lblIntro.Location = new System.Drawing.Point(22, 29);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(667, 41);
            this.lblIntro.TabIndex = 8;
            this.lblIntro.Text = "Lord of The Rings. Shooter Game";
            // 
            // IntroTimer
            // 
            this.IntroTimer.Enabled = true;
            this.IntroTimer.Interval = 200;
            this.IntroTimer.Tick += new System.EventHandler(this.IntroTimer_Tick);
            // 
            // FrodoPictureBox
            // 
            this.FrodoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FrodoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FrodoPictureBox.Image")));
            this.FrodoPictureBox.Location = new System.Drawing.Point(400, 200);
            this.FrodoPictureBox.Name = "FrodoPictureBox";
            this.FrodoPictureBox.Size = new System.Drawing.Size(126, 173);
            this.FrodoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrodoPictureBox.TabIndex = 5;
            this.FrodoPictureBox.TabStop = false;
            this.FrodoPictureBox.Visible = false;
            this.FrodoPictureBox.Click += new System.EventHandler(this.FrodoPictureBox_Click);
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.AllowDrop = true;
            this.listBoxStatus.BackColor = System.Drawing.Color.Black;
            this.listBoxStatus.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStatus.ForeColor = System.Drawing.Color.White;
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 24;
            this.listBoxStatus.Location = new System.Drawing.Point(12, 405);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(568, 52);
            this.listBoxStatus.TabIndex = 7;
            this.listBoxStatus.Visible = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevel.Location = new System.Drawing.Point(180, 33);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(143, 37);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level:1";
            this.lblLevel.Visible = false;
            // 
            // lblGameIsOver
            // 
            this.lblGameIsOver.AutoSize = true;
            this.lblGameIsOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameIsOver.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameIsOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameIsOver.Location = new System.Drawing.Point(307, 142);
            this.lblGameIsOver.Name = "lblGameIsOver";
            this.lblGameIsOver.Size = new System.Drawing.Size(262, 39);
            this.lblGameIsOver.TabIndex = 9;
            this.lblGameIsOver.Text = "Game is over!";
            this.lblGameIsOver.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRestart.Enabled = false;
            this.btnRestart.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(742, 333);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(129, 52);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "ReStart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Red;
            this.lblWin.Location = new System.Drawing.Point(364, 142);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(162, 39);
            this.lblWin.TabIndex = 11;
            this.lblWin.Text = "You Win!";
            this.lblWin.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 478);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblGameIsOver);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.FrodoPictureBox);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.GollumPictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(912, 516);
            this.MinimumSize = new System.Drawing.Size(912, 516);
            this.Name = "MainForm";
            this.Text = "Mordor calling!";
            ((System.ComponentModel.ISupportInitialize)(this.GollumPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrodoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox GollumPictureBox1;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Timer IntroTimer;
        private System.Windows.Forms.PictureBox FrodoPictureBox;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGameIsOver;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblWin;
    }
}


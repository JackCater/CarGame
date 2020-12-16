using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class CarRacingGame : Form
    {
        readonly Random enemyXPos = new Random();
        readonly Random extraMoveSpeed = new Random();
        readonly Random coinX = new Random();
        int iGameSpeed = 1;
        int iScore = 0;

        public CarRacingGame()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += OnKeyDownCarMove;
            this.KeyUp += OnKeyUpCarMove;
        }

        private void OnGameTimerTick(object sender, EventArgs e)
        {
            MoveLines(iGameSpeed);
            MoveEnemies(iGameSpeed);
            MoveCoins(iGameSpeed);
            CoinDetection();
            if (CollisionDetection())
            {
                timGameTimer.Stop();
                btnRestartGame.Visible = true;
            }            
        }

        void OnKeyUpCarMove(object sender, KeyEventArgs e)
        {
            iGameSpeed = 3;
        }

        void OnKeyDownCarMove(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    car.Left -= 10;
                    break;
                case Keys.Right:
                    car.Left += 10;
                    break;
                case Keys.Up:
                    iGameSpeed = 10;
                    break;
            } // end switch
        }

        bool CollisionDetection()
        {
            foreach (PictureBox p in Controls.OfType<PictureBox>())            
                if (p.Name.Contains("enemy"))
                    if (p.Bounds.IntersectsWith(car.Bounds))                    
                        return true;

            return false;            
        }

        void MoveCoins(int iGameSpeed)
        {
            foreach (PictureBox p in Controls.OfType<PictureBox>())
            {
                if (p.Name.Contains("Coin"))
                    if (p.Top >= Size.Height)                    
                        p.Location = new Point(coinX.Next(Size.Width), 0);                    
                    else                    
                        p.Top += iGameSpeed + extraMoveSpeed.Next(10);
            }
        }

        void CoinDetection()
        {
            foreach (PictureBox p in Controls.OfType<PictureBox>())
                if (p.Name.Contains("Coin"))                
                    if (p.Bounds.IntersectsWith(car.Bounds))
                    {
                        p.Location = new Point(coinX.Next(Size.Width), 0);
                        iScore++;
                        lblCoins.Text = "Score = " + iScore.ToString();
                    }                           
        }

        void MoveLines(int iGameSpeed)
        {
            foreach (PictureBox p in Controls.OfType<PictureBox>())
            {
                if (p.Name.Contains("picture"))
                    if (p.Top >= Size.Height)
                    {
                        p.Top = -100;
                        p.Visible = true;
                    }
                    else p.Top += iGameSpeed;
            }
        }

        void MoveEnemies(int iGameSpeed)
        {
            if (enemy1.Top >= Size.Height)
            {
                Point pos = new Point(enemyXPos.Next(0, 100), 0);
                enemy1.Location = pos;
            } // end if
            else enemy1.Top += iGameSpeed + extraMoveSpeed.Next(10);

            if (enemy2.Top >= Size.Height)
            {
                Point pos = new Point(enemyXPos.Next(120, 200), 0);
                enemy2.Location = pos;
            } // end if
            else enemy2.Top += iGameSpeed + extraMoveSpeed.Next(10);

            if (enemy3.Top >= Size.Height)
            {
                Point pos = new Point(enemyXPos.Next(220, 300), 0);
                enemy3.Location = pos;
            } // end if
            else enemy3.Top += iGameSpeed + extraMoveSpeed.Next(10);

            if (enemy4.Top >= Size.Height)
            {
                Point pos = new Point(enemyXPos.Next(320, 380), 0);
                enemy4.Location = pos;
            } // end if
            else enemy4.Top += iGameSpeed + extraMoveSpeed.Next(10);
        }

        private void OnRestartGameClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OnStartGameClick(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            timGameTimer.Start();
        }
    }
}

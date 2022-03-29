using PingPong.Object.Impl;
using PingPong.Object;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        Ball Ball;
        Wall UpperWall;
        Wall BottomWall;

        Paddle LeftPaddle;
        Paddle RightPaddle;
        List<GameObject> GameObjects;

        bool GameOver = false;

        private void Init() {
            GameObjects = new List<GameObject>();
            Ball = new Ball(new Point(this.pictureBox1.Width/2, (this.pictureBox1.Height - 300) / 2), 10, 10);
            GameObjects.Add(Ball);

            UpperWall = new Wall(new Point(0, 0), this.pictureBox1.Width, 50, Brushes.Black);
            GameObjects.Add(UpperWall);

            BottomWall = new Wall(new Point(0, this.pictureBox1.Height - 300), this.pictureBox1.Width, 50, Brushes.Black);
            GameObjects.Add(BottomWall);

            LeftPaddle = new Paddle(new Point(10, (this.pictureBox1.Height - 300) / 2), 10, 30, Brushes.Green);
            GameObjects.Add(LeftPaddle);

            RightPaddle = new Paddle(new Point(this.pictureBox1.Width - 50, (this.pictureBox1.Height - 300) / 2), 10, 30, Brushes.Blue);
            GameObjects.Add(RightPaddle);

            GameOver = false;
        }
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!this.timer1.Enabled) {
                return;
            }
            switch (e.KeyChar)
            {
                case 'w':
                    if (!LeftPaddle.CheckCollision(UpperWall)) {
                        LeftPaddle.IsMovingUp = true;
                        LeftPaddle.Moving();
                    } else {
                        LeftPaddle.IsMovingUp = false;
                        LeftPaddle.Moving();
                    }
                    break;
                case 's':
                    if (!LeftPaddle.CheckCollision(BottomWall)) {
                        LeftPaddle.IsMovingUp = false;
                        LeftPaddle.Moving();
                    } else {
                        LeftPaddle.IsMovingUp = true;
                        LeftPaddle.Moving();
                    }
                    break;
                case 'i':
                    if (!RightPaddle.CheckCollision(UpperWall)) {
                        RightPaddle.IsMovingUp = true;
                        RightPaddle.Moving();
                    } else {
                        RightPaddle.IsMovingUp = false;
                        RightPaddle.Moving();
                    }
                    break;
                case 'k':
                    if (!RightPaddle.CheckCollision(BottomWall)) {
                        RightPaddle.IsMovingUp = false;
                        RightPaddle.Moving();
                    } else {
                        RightPaddle.IsMovingUp = true;
                        RightPaddle.Moving();
                    }
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            pictureBox1.Refresh();

            if (Ball.CheckCollision(UpperWall)) {
                Ball.IsMovingUp = false;
            }

            if (Ball.CheckCollision(BottomWall)) {
                Ball.IsMovingUp = true;
            }

            if (Ball.CheckCollision(RightPaddle)) {
                Ball.IsMovingLeft = true;
            }

            if (Ball.CheckCollision(LeftPaddle)) {
                Ball.IsMovingLeft = false;
            }

            Ball.Moving();

            foreach (GameObject GameObject in GameObjects) {
                GameObject.Draw(pictureBox1);
            }

            CheckGameOver();
        }

        /// <summary>檢查是否遊戲結束</summary>
        private void CheckGameOver() {
            if (Ball.Position.X >= this.pictureBox1.Width - 45 && !GameOver) {
                EndGameProcess("左方勝");
            } else if (Ball.Position.X <= 5 && !GameOver) {
                EndGameProcess("右方勝");
            }
        }
        private void EndGameProcess(string ByMessage) {
            this.timer1.Enabled = false;
            GameOver = true;
            MessageBox.Show(ByMessage);
            this.button_start.Text = "再玩一次";
        }

        private void button_start_Click(object sender, EventArgs e) {

            if (this.button_start.Text == "再玩一次") {
                Init();
            }
            
            if (this.timer1.Enabled) {
                this.timer1.Enabled = false;
                this.button_start.Text = "暫停";
            } else {
                this.timer1.Enabled = true;
                this.button_start.Text = "繼續";
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            foreach (GameObject GameObject in GameObjects) {
                GameObject.Draw(pictureBox1);
            }
        }

        private void button_w_Click(object sender, EventArgs e) {
            System.Windows.Forms.SendKeys.Send("w");
        }

        private void button_s_Click(object sender, EventArgs e) {
            System.Windows.Forms.SendKeys.Send("s");
        }

        private void button_i_Click(object sender, EventArgs e) {
            System.Windows.Forms.SendKeys.Send("i");
        }

        private void button_k_Click(object sender, EventArgs e) {
            System.Windows.Forms.SendKeys.Send("k");
        }
    }
}

using PingPong.Action;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Object.Impl
{

    /// <summary> 球 </summary>
    public class Ball : GameObject, IAction
    {
        public bool IsMovingLeft { get; set; }
        public bool IsMovingUp { get; set; }

        private int Speed = 10;


        /// <summary> 建立球體，初始化時，會隨機決定移動方向 </summary>
        /// <param name="ByPosition">位置</param>
        /// <param name="ByWidth">物體寬</param>
        /// <param name="ByHeight">物體高</param>
        public Ball(Point ByPosition, int ByWidth, int ByHeight) : base("Ball", ByPosition, ByWidth, ByHeight, Brushes.Red) {
            Random Random = new Random();
            IsMovingLeft = Random.Next(2) == 1;
            IsMovingUp = Random.Next(2) == 1;
        }

        public override void Draw(PictureBox ByPictureBox)
        {
            using (var g = ByPictureBox.CreateGraphics())
            {
                Body.X = Position.X;
                Body.Y = Position.Y;
                g.FillEllipse(BodyColor, Body);
            }
        }

        /// <summary>移動，移動方向可以為上下左右</summary>
        public void Moving() {
            if (IsMovingUp) {
                MovingUp();
            } else {
                MovingDown();
            }

            if (IsMovingLeft) {
                MovingLeft();
            } else {
                MovingRight();
            }
        }

        private void MovingDown()
        {
            IsMovingUp = false;
            Position = new Point(Position.X, Position.Y + Speed);
        }
        private void MovingUp()
        {
            IsMovingUp = true;
            Position = new Point(Position.X, Position.Y - Speed);
        }

        private void MovingLeft()
        {
            IsMovingLeft = true;
            Position = new Point(Position.X - Speed, Position.Y);
        }

        private void MovingRight()
        {
            IsMovingLeft = false;
            Position = new Point(Position.X + Speed, Position.Y);
        }

        public override bool CheckCollision(GameObject ByGameObject) {
            bool IsCollection = base.CheckCollision(ByGameObject);
            if (IsCollection) {
                PlaySound();
            }
            return IsCollection;
        }

        private void PlaySound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"./Sound/sound.wav");
            simpleSound.Play();
        }
    }
}

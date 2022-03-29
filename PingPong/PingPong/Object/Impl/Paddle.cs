using PingPong.Action;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Object.Impl
{
    /// <summary>球拍</summary>
    public class Paddle : GameObject, IAction {

        public bool IsMovingUp { get; set; }
        public Paddle(Point ByPosition, int ByWidth, int ByHeight, Brush ByBodyColor) : base("Paddle", ByPosition, ByWidth, ByHeight, ByBodyColor) {
            IsMovingUp = false;
        }

        public override void Draw(PictureBox ByPictureBox) {
            using (var g = ByPictureBox.CreateGraphics()) {
                Body.X = Position.X;
                Body.Y = Position.Y;
                g.FillRectangle(BodyColor, Body);
            }
        }

        /// <summary>移動，只可以上下移動</summary>
        public void Moving() {
            if (IsMovingUp) {
                MovingUp();
            } else {
                MovingDown();
            }
        }

        private void MovingDown() {
            IsMovingUp = false;
            Position = new Point(Position.X, Position.Y + 5);
        }
        private void MovingUp() {
            IsMovingUp = true;
            Position = new Point(Position.X, Position.Y - 5);
        }
    }
}

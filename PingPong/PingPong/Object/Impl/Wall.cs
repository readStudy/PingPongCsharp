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
    /// <summary>牆</summary>
    public class Wall : GameObject
    {
        public Wall(Point ByPosition, int ByWidth, int ByHeight, Brush ByBodyColor) : base("Wall", ByPosition, ByWidth, ByHeight, ByBodyColor) {
        }

        public override void Draw(PictureBox ByPictureBox) {
            using (var g = ByPictureBox.CreateGraphics()) {
                Body.X = Position.X;
                Body.Y = Position.Y;
                g.FillRectangle(BodyColor, Body);
            }
        }
    }
}

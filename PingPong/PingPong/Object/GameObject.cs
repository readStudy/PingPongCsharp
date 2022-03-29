using PingPong.Action;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Object
{
    /// <summary> Game物件 </summary>
    public abstract class GameObject : IDrawable{
        
        /// <summary>此物件的位置</summary>
        public Point Position { get; set; }

        /// <summary>此物件的名稱</summary>
        public string Name { get; set; }

        /// <summary>此物件的體積，用來判斷是否有碰撞</summary>
        protected Rectangle Body;

        /// <summary>此物件的顏色</summary>
        protected Brush BodyColor;

        /// <summary> 建立物件 </summary>
        /// <param name="ByPosition">物體位置</param>
        /// <param name="ByWidth">物體寬</param>
        /// <param name="ByHeight">物體高</param>

        public GameObject(string ByName, Point ByPosition, int ByWidth, int ByHeight, Brush ByBodyColor) {
            Name = ByName;
            Position = ByPosition;
            Body = new Rectangle(Position.X, Position.Y, ByWidth, ByHeight);
            BodyColor = ByBodyColor;
        }

        public GameObject(string ByName, int ByWidth, int ByHeight, Brush ByBodyColor) : this(ByName, new Point(0, 0), ByWidth, ByHeight, ByBodyColor) {
        }

        /// <summary>抽象的畫圖方法，由子類實作</summary>
        /// <param name="ByPictureBox">傳入要顯示這個GameObject物件的PictureBox</param>
        public abstract void Draw(PictureBox ByPictureBox);

        /// <summary>檢查傳入的GameObject是否有和這個GameObject碰撞</summary>
        /// <param name="ByGameObject">傳入要檢查的GameObject</param>
        /// <returns></returns>
        public virtual bool CheckCollision(GameObject ByGameObject) {

            if (Body.IntersectsWith(ByGameObject.Body)) {
                return true;
            }

            return false;
        }
    }
}

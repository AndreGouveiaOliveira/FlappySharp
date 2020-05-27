using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappySharp
{
    class Sprite : PictureBox
    {
        Panel _zoneScene;
        Dictionary<string, Bitmap> _images;
        Rectangle _collision;
        int _xPos;
        int _yPos;
        int _calque;
        int _zOrder;
        bool _dragging;
        bool _selected;
        string _modificationZOrder;
        public Sprite(string nom, Size taille, Dictionary<string, Bitmap> images, int calque, int zOrder, Point position, Panel zoneScene)
        {
            base.SizeMode = PictureBoxSizeMode.StretchImage;

            base.Name = nom;
            base.Size = taille;
            base.Location = position;
            base.Image = images.Values.First();

            _collision = new Rectangle(new Point(0,0), new Size(taille.Width - 1, taille.Height - 1));

            _images = images;
            _calque = calque;
            _zOrder = zOrder;
            _zoneScene = zoneScene;

            base.MouseDown += pbx_MouseDown;
            base.MouseMove += pbx_MouseMove;
            base.MouseUp += pbx_MouseUp;
            base.Paint += pbx_Paint;
            base.Click += pbx_Click;

            AjouterControlPanel();
        }

        public void AjouterControlPanel()
        {
            _zoneScene.Controls.Add(this);
        }

        public void SuprControlPanel(bool removeSprite)
        {
            _zoneScene.Controls.Remove(this);
            if (removeSprite)
                this.Dispose();
        }

        public void MonterZOrder()
        {
            _modificationZOrder = "-";
        }
        public void DescendreZOrder()
        {
            _modificationZOrder = "-";
        }

        #region Event
        private void pbx_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;
            _collision = new Rectangle(base.Location, base.Size);
        }

        private void pbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void pbx_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }

        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Sprite)
            {
                e.Graphics.DrawRectangle(Pens.Black, _collision);
            }
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            if (sender is Sprite)
            {
                _selected = true;
            }
        }
        #endregion
    }
}

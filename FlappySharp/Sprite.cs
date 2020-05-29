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
        int _intervalEntreImage;
        int _rotation;
        bool _dragging;
        bool _selected;
        string _modificationZOrder;
        string _tagSprite;

        public int Calque { get => _calque; private set => _calque = value; }
        public int ZOrder { get => _zOrder; set => _zOrder = value; }
        public string ModificationZOrder { get => _modificationZOrder; set => _modificationZOrder = value; }
        public bool Selected { get => _selected; set => _selected = value; }
        public int IntervalEntreImage { get => _intervalEntreImage; set => _intervalEntreImage = value; }
        public string TagSprite { get => _tagSprite; set => _tagSprite = value; }
        public int Rotation { get => _rotation; set => _rotation = value; }
        public Dictionary<string, Bitmap> Images { get => _images; set => _images = value; }

        public Sprite(string nom, Size taille, Dictionary<string, Bitmap> images, int calque, int zOrder, Point position, Panel zoneScene)
        {
            base.SizeMode = PictureBoxSizeMode.StretchImage;

            base.Name = nom;
            base.Size = taille;
            base.Location = position;
            base.Image = images.Values.First();

            _collision = new Rectangle(new Point(0,0), new Size(taille.Width - 1, taille.Height - 1));

            Images = images;
            Calque = calque;
            ZOrder = zOrder;
            _zoneScene = zoneScene;

            base.MouseDown += pbx_MouseDown;
            base.MouseMove += pbx_MouseMove;
            base.MouseUp += pbx_MouseUp;
            base.Paint += pbx_Paint;
            base.Click += pbx_Click;

            AjoutControlPanel();
        }

        public void AjoutControlPanel()
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
            ModificationZOrder = "-";
        }

        public void DescendreZOrder()
        {
            ModificationZOrder = "+";
        }

        public void UpdateValue(string nom, Size taille, Point position, Dictionary<string,Bitmap> image, int intervalImage, int calque, int zOrder, string tag, int rotation)
        {
            base.Name = nom;
            base.Size = taille;
            base.Location = position;
            Images = image;
            IntervalEntreImage = intervalImage;
            Calque = calque;
            ZOrder = zOrder;
            TagSprite = tag;
            Rotation = rotation;
        }

        // :TODO Mettre la rotation et annimation de l'image

        #region Event
        private void pbx_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;
            _collision = new Rectangle(new Point(0,0), base.Size);
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
                e.Graphics.DrawRectangle(Pens.Transparent, _collision);
            }
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            if (sender is Sprite)
            {
                Selected = true;
            }
        }
        #endregion
    }
}

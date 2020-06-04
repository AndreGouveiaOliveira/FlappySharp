using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappySharp
{
    public class Sprite : PictureBox
    {
        Panel _zoneScene;
        Dictionary<string, Bitmap> _images;
        Rectangle _collision;
        Timer _tmp;
        int _xPos;
        int _yPos;
        int _calque;
        int _zOrder;
        int _intervalEntreImage;
        int _angleRotation;
        int _imageAnime;
        bool _dragging;
        bool _selected;
        string _modificationZOrder;
        string _tagSprite;
        string _cheminDossierImage;

        public int Calque { get => _calque; private set => _calque = value; }
        public int ZOrder { get => _zOrder; set => _zOrder = value; }
        public string ModificationZOrder { get => _modificationZOrder; set => _modificationZOrder = value; }
        public bool Selected { get => _selected; set => _selected = value; }
        public int IntervalEntreImage { get => _intervalEntreImage; set => _intervalEntreImage = value; }
        public string TagSprite { get => _tagSprite; set => _tagSprite = value; }
        public int AngleRotation { get => _angleRotation; set => _angleRotation = value; }
        public Dictionary<string, Bitmap> Images { get => _images; set => _images = value; }
        public string CheminDossierImage { get => _cheminDossierImage; set => _cheminDossierImage = value; }

        public Sprite(string nom, Size taille, Dictionary<string, Bitmap> images, int calque, int zOrder, Point position, Panel zoneScene)
        {
            base.SizeMode = PictureBoxSizeMode.StretchImage;

            base.Name = nom;
            base.Size = taille;
            base.Location = position;
            base.Image = images.Values.First();

            _collision = new Rectangle(new Point(0,0), new Size(taille.Width - 1, taille.Height - 1));
            _tmp = new Timer();

            Images = images;
            Calque = calque;
            ZOrder = zOrder;
            IntervalEntreImage = 1;
            _zoneScene = zoneScene;

            base.MouseDown += pbx_MouseDown;
            base.MouseMove += pbx_MouseMove;
            base.MouseUp += pbx_MouseUp;
            base.Paint += pbx_Paint;
            base.Click += pbx_Click;

            _tmp.Interval = 130;
            _tmp.Enabled = false;
            _tmp.Tick += tmp_Tick;

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

        //public void MonterZOrder()
        //{
        //    ModificationZOrder = "-";
        //}
        
        //public void DescendreZOrder()
        //{
        //    ModificationZOrder = "+";
        //}

        public void UpdateValue(string nom, Size taille, Point position, Dictionary<string,Bitmap> image, int intervalImage, int calque, int zOrder, string tag, int rotation)
        {
            base.Name = nom;
            base.Size = taille;
            base.Location = position;
            Images = image;
            IntervalEntreImage = intervalImage;
            _tmp.Interval = intervalImage;
            Calque = calque;
            ZOrder = zOrder;
            TagSprite = tag;
            AngleRotation = rotation;
        }

        public void DemareAnimation()
        {
            _tmp.Enabled = !_tmp.Enabled;
        }

        public void CreationDossier()
        {
            Directory.CreateDirectory(CheminDossierImage);
            foreach (var image in Images.Values)
            {
                image.Save(CheminDossierImage);
            }
        }


        // :TODO essayer de faire fonctionner la rotation avec l'animation
        // Fonctionne sans l'annimation
        //public void RotationImage()
        //{
        //    if (base.Image == null || Images == null)
        //        return;
        //    Image oldImage = base.Image;
        //    base.Image = Rotation(base.Image, new Point(base.Image.Width / 2, base.Image.Height / 2), AngleRotation);
        //    if (oldImage != null)
        //    {
        //        oldImage.Dispose();
        //    }
        //}
        // Ne fonctionne pas 
        //public void RotationImage()
        //{
        //    if (base.Image == null || Images == null)
        //        return;
        //    Image oldImage = Images.Values.ElementAt(_imageAnime);
        //    Images.Values.ElementAt(_imageAnime). = Rotation(base.Image, new Point(Images.Values.ElementAt(_imageAnime).Width / 2, Images.Values.ElementAt(_imageAnime).Height / 2), AngleRotation);
        //    if (oldImage != null)
        //    {
        //        oldImage.Dispose();
        //    }
        //}
        //private static Bitmap Rotation(Image image, Point pointRotation, float angle)
        //{
        //    if (image == null)
        //        throw new ArgumentException("image");
        //
        //    Bitmap bmpTourner = new Bitmap(image.Width, image.Height);
        //    bmpTourner.SetResolution(image.HorizontalResolution, image.VerticalResolution);
        //
        //    Graphics g = Graphics.FromImage(bmpTourner);
        //
        //    g.TranslateTransform(pointRotation.X, pointRotation.Y);
        //
        //    g.RotateTransform(angle);
        //
        //    g.TranslateTransform(-pointRotation.X, -pointRotation.Y);
        //
        //    g.DrawImage(image, new Point(0, 0));
        //
        //    return bmpTourner;
        //}

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

        private void tmp_Tick(object sender, EventArgs e)
        {
            base.Image = Images.Values.ElementAt(_imageAnime);
            if ((Images.Count - 1)  == _imageAnime)
            {
                _imageAnime = 0;
            }
            else
            {
                _imageAnime++;
            }
        }
        #endregion
    }
}

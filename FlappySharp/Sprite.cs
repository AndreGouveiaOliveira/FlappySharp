/*
 * Auteur       : André Gouveia de Oliveira
 * Professeur   : M. Pascal BONVIN
 * Experts      : M. Robin BOUILLE et M. Borys FOLOWMIETOW
 * Date         : 08 Juin 2020
 * Mandant      : CFPT-Informatique, Genève, Petit-Lancy
 * Projet       : FlappySharp
 * Version      : 1.0
 * Description  : Editeur de Jeu 2D développé dans le cadre d'un TPI de de CFC à l'école d'informatique de Genève.
 */

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
        Dictionary<string, Bitmap> _imagesRot;
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
        int _positionFinal;
        float _spriteVYMonte = 1f;
        float _spriteVYDescend = 1f;
        int _vitesseLateral = 1;

        public int Calque { get => _calque; private set => _calque = value; }
        public int ZOrder { get => _zOrder; set => _zOrder = value; }
        public string ModificationZOrder { get => _modificationZOrder; set => _modificationZOrder = value; }
        public bool Selected { get => _selected;  set => _selected = value; }
        public int IntervalEntreImage { get => _intervalEntreImage; private set => _intervalEntreImage = value; }
        public string TagSprite { get => _tagSprite; private set =>  _tagSprite = value; }
        public int AngleRotation {
            get => _angleRotation;
            set
            {
                _angleRotation = value;
                _imagesRot = new Dictionary<string, Bitmap>();
                foreach (var item in Images)
                {
                    _imagesRot.Add(item.Key, RotateImage(item.Value, _angleRotation));
                }
            }
        }
        public Dictionary<string, Bitmap> Images { get => _images; private set => _images = value; }
        public string CheminDossierImage { get => _cheminDossierImage; private set => _cheminDossierImage = value; }
        public Rectangle Collision { get => _collision; private set => _collision = value; }


        public Sprite(string nom, Size taille, Dictionary<string, Bitmap> images, int calque, int zOrder, Point position, Panel zoneScene)
        {
            base.SizeMode = PictureBoxSizeMode.StretchImage;

            base.Name = nom;
            base.Size = taille;
            base.Location = position;
            base.Image = images.Values.First();

            Collision = new Rectangle(position, new Size(taille.Width - 1, taille.Height - 1));
            _tmp = new Timer();

            Images = images;
            _imagesRot = new Dictionary<string, Bitmap>(Images);
            Calque = calque;
            ZOrder = zOrder;
            IntervalEntreImage = 1;
            _zoneScene = zoneScene;
            _positionFinal = base.Location.Y + 200;

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

        /// <summary>
        /// Permet d'ajouter le Sprite dans les controls du Panel
        /// </summary>
        public void AjoutControlPanel()
        {
            _zoneScene.Controls.Add(this);
        }

        /// <summary>
        /// Supprime le Sprite des controls ou totalement
        /// </summary>
        /// <param name="removeSprite">Definie s'il faut supprimer définitivement le Sprites</param>
        public void SuprControlPanel(bool removeSprite)
        {
            _zoneScene.Controls.Remove(this);
            if (removeSprite)
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// Ajoute dans le control de la forme frmSceneJeu le Sprite
        /// </summary>
        /// <param name="plateauJeu">la forme où on ajoute les Sprites</param>
        public void AjoutControlPlateauJeu(frmPlateauJeu plateauJeu)
        {
            plateauJeu.Controls.Add(this);
        }

        /// <summary>
        /// Met à jour les données du Sprite
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="taille"></param>
        /// <param name="position"></param>
        /// <param name="image"></param>
        /// <param name="intervalImage"></param>
        /// <param name="calque"></param>
        /// <param name="zOrder"></param>
        /// <param name="tag"></param>
        /// <param name="rotation"></param>
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

        /// <summary>
        /// Change le Enable du timer pour lancer l'animation
        /// </summary>
        public void DemareAnimation()
        {
            _tmp.Enabled = !_tmp.Enabled;
        }

        /// <summary>
        /// Crée un dossier pour le Sprite et enregistre les images du Sprite dans le dossier
        /// </summary>
        /// <param name="cheminDossier">chemin du dossier où on enregistre les images</param>
        public void CreationDossier(string cheminDossier)
        {
            CheminDossierImage = cheminDossier;
            Directory.CreateDirectory(Path.Combine(cheminDossier, base.Name));
            foreach (var image in Images)
            {
                Bitmap monImage = image.Value;
                monImage.Save(Path.Combine(Path.Combine(cheminDossier, base.Name), image.Key), monImage.RawFormat);
            }
        }

        /// <summary>
        /// Les Mouvement des Sprites avec "Player" et "Ennemie"
        /// </summary>
        public void Deplacement()
        {
            switch (TagSprite)
            {
                case "Player":
                    if (_positionFinal < 0)
                    {
                        _positionFinal = 0;
                    }

                    if (base.Location.Y > _positionFinal)
                    {
                        _spriteVYDescend = 1f;
                        base.Location = new Point(base.Location.X, base.Location.Y - (int)_spriteVYMonte);
                        _spriteVYMonte += 0.08f;
                    }
                    else
                    {
                        _spriteVYMonte = 1f;
                        _positionFinal = base.Location.Y + 200;
                        base.Location = new Point(base.Location.X, base.Location.Y + (int)_spriteVYDescend);
                        _spriteVYDescend += 0.08f;
                    }
                    Collision = new Rectangle(base.Location, base.Size);
                    break;

                case "Ennemie":
                    if (base.Location.X <= -base.Width)
                    {
                        base.Location = new Point(_zoneScene.Width, base.Location.Y);
                    }
                    else
                    {
                        base.Location = new Point(base.Location.X - _vitesseLateral, base.Location.Y);
                    }
                    Collision = new Rectangle(base.Location, base.Size);
                    break;
            }
        }

        /// <summary>
        ///  Calcule la position final pour le déplacement
        /// </summary>
        /// <param name="valeurFinal"></param>
        public void ChangePositionFinal(int valeurFinal)
        {
            _positionFinal = this.Location.Y - valeurFinal;
        }

        /// <summary>
        /// Active les évents des Sprites
        /// </summary>
        /// <param name="activerEnement">Dit s'il faut activer ou desactiver les évents</param>
        public void ActiverDesactiverEvenement(bool activerEnement)
        {
            if (activerEnement)
            {
                base.MouseDown += pbx_MouseDown;
                base.MouseMove += pbx_MouseMove;
                base.MouseUp += pbx_MouseUp;
                base.Click += pbx_Click;
            }
            else
            {
                base.MouseDown -= pbx_MouseDown;
                base.MouseMove -= pbx_MouseMove;
                base.MouseUp -= pbx_MouseUp;
                base.Click -= pbx_Click;
            }
        }

        /// <summary>
        /// Fait appelle à la méthode Rotation pour rotate l'image
        /// </summary>
        /// <param name="image">l'image à rotate</param>
        /// <param name="angle">l'angle de rotation</param>
        /// <returns></returns>
        private Bitmap RotateImage(Image image, float angle)
        {
            return Rotation(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }

        /// <summary>
        /// Fait la rotation de l'image
        /// </summary>
        /// <param name="image">l'image a rotate</param>
        /// <param name="pointRotation">l'endroit ou on fait la rotation</param>
        /// <param name="angle">l'angle de rotation</param>
        /// <returns></returns>
        private static Bitmap Rotation(Image image, PointF pointRotation, float angle)
        {        
            Bitmap bmpTourner = new Bitmap(image.Width, image.Height);
            bmpTourner.SetResolution(image.HorizontalResolution, image.VerticalResolution);
        
            Graphics g = Graphics.FromImage(bmpTourner);
        
            g.TranslateTransform(pointRotation.X, pointRotation.Y);
        
            g.RotateTransform(angle);
        
            g.TranslateTransform(-pointRotation.X, -pointRotation.Y);
        
            g.DrawImage(image, new Point(0, 0));
        
            return bmpTourner;
        }

        #region Event
        /// <summary>
        /// Change la variable dragging et crée un nouveau rectangle pour la collision 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;
            Collision = new Rectangle(base.Location, base.Size);
        }

        /// <summary>
        /// Change la variable dragging et xPos et yPos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        /// <summary>
        /// Change la valeur la valeur de la position du Sprite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }

        /// <summary>
        /// Dessine le rectangle autour du Sprite pour la collision
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Sprite)
            {
                e.Graphics.DrawRectangle(Pens.Transparent, Collision);
            }
        }

        /// <summary>
        /// Change variable selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Click(object sender, EventArgs e)
        {
            if (sender is Sprite)
            {
                Selected = true;
            }
        }

        /// <summary>
        /// Fait l'annimation du Sprite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmp_Tick(object sender, EventArgs e)
        {
            base.Image = _imagesRot.Values.ElementAt(_imageAnime);
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

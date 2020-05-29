using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappySharp
{
    public partial class frmMain : Form
    {
        Jeu jeu;
        Dictionary<string, Bitmap> images;
        Sprite _spriteSelected;
        int zOrder;

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;

            jeu = new Jeu();
            images = new Dictionary<string, Bitmap>();
        }

        private void pbxAjoutFlappy_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("test", new Bitmap(pbxAjoutFlappy.Image));
            images.Add("test1", new Bitmap(@"C:\Users\Dev\Desktop\Flapy\Flapy\Flappy_1.jpg"));
            images.Add("test2", new Bitmap(@"C:\Users\Dev\Desktop\Flapy\Flapy\Flappy_2.jpg"));
            images.Add("test3", new Bitmap(@"C:\Users\Dev\Desktop\Flapy\Flapy\Flappy_3.jpg"));
            //Sprite s = new Sprite("test", new Size(50, 50), images, 1, 1, new Point(50, 50), spSceneParam.Panel1);
            jeu.AddSprite("test", new Size(50, 50), new Point(50, 50), images, 1, spSceneParam.Panel1);
        }

        private void pbxAjoutFond_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("test", new Bitmap(pbxAjoutFond.Image));
            Sprite s = new Sprite("test", new Size(100, 100), images, 1, 1, new Point(50, 50), spSceneParam.Panel1);
        }

        private void pbxAjoutSol_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("test", new Bitmap(pbxAjoutSol.Image));
            Sprite s = new Sprite("test", new Size(100, 100), images, 1, 1, new Point(50, 50), spSceneParam.Panel1);
        }

        private void pbxAjoutTuyau_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("test", new Bitmap(pbxAjoutTuyau.Image));
            Sprite s = new Sprite("test", new Size(100, 100), images, 1, 1, new Point(50, 50), spSceneParam.Panel1);
        }

        private void pbxAjoutSprite_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            //images.Add("test", new Bitmap()); // :TODO Mettre les images select dans la form ajout
            Sprite s = new Sprite("test", new Size(100, 100), images, 1, 1, new Point(50, 50), spSceneParam.Panel1);
        }

        private void btnUpZOrder_Click(object sender, EventArgs e)
        {
            zOrder = -1;
        }

        private void btnDownZOrder_Click(object sender, EventArgs e)
        {
            zOrder = 1;
        }

        private void btnSauveModif_Click(object sender, EventArgs e)
        {
            jeu.UpdateValueSpriteSelected(tbxNom.Text, new Size(Convert.ToInt32(tbxLargeur.Text), Convert.ToInt32(tbxHauteur.Text)), new Point(Convert.ToInt32(tbxPosX.Text), Convert.ToInt32(tbxPosY.Text)), images, Convert.ToInt32(tbxIntervalImage.Text), (int)nudCalque.Value, zOrder, cbxTag.Text, (int)nudRotation.Value);
            zOrder = 0;
        }

        private void btnSupr_Click(object sender, EventArgs e)
        {
            _spriteSelected.SuprControlPanel(true);
            jeu.Sprites.Remove(_spriteSelected);
            tbxNom.Text = "";
            nudCalque.Value = 0;
            tbxHauteur.Text = "";
            tbxLargeur.Text = "";
            tbxPosX.Text = "";
            tbxPosY.Text = "";
            lbxImages.Items.Clear();
            tbxIntervalImage.Text = "";
            cbxTag.Text = "";
            nudRotation.Value = 0;
            btnSupr.Enabled = false;
        }

        private void tmp_Tick(object sender, EventArgs e)
        {
            if (_spriteSelected != jeu.GetValueSpriteSelected())
            {
                _spriteSelected = jeu.GetValueSpriteSelected();
                tbxNom.Text = _spriteSelected.Name;
                nudCalque.Value = _spriteSelected.Calque;
                tbxHauteur.Text = _spriteSelected.Height.ToString();
                tbxLargeur.Text = _spriteSelected.Width.ToString();
                tbxPosX.Text = _spriteSelected.Location.X.ToString();
                tbxPosY.Text = _spriteSelected.Location.Y.ToString();
                lbxImages.Items.Clear();
                foreach (var image in _spriteSelected.Images.Keys)
                {
                    lbxImages.Items.Add(image);
                }
                tbxIntervalImage.Text = _spriteSelected.IntervalEntreImage.ToString();
                cbxTag.Text = _spriteSelected.TagSprite;
                nudRotation.Value = _spriteSelected.Rotation;
                btnSupr.Enabled = true;
            }

            if (tbxNom.Text == null || tbxHauteur.Text == null || tbxLargeur.Text == null || tbxPosX.Text == null || tbxPosY.Text == null || lbxImages.Items.Count == 0 || tbxIntervalImage.Text == null || cbxTag.Text == null)
            {
                btnSauveModif.Enabled = false;
            }
            else
            {
                btnSauveModif.Enabled = true;
            }
        }
    }
}

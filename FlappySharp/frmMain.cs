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
        int zOrder;
        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;

            jeu = new Jeu();
        }

        private void pbxAjoutFlappy_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("test", new Bitmap(pbxAjoutFlappy.Image));
            images.Add("test1", new Bitmap(@"C:\Users\Dev\Desktop\Flapy\Flapy\Flappy_1.jpg"));
            images.Add("test2", new Bitmap(@"C:\Users\Dev\Desktop\Flapy\Flapy\Flappy_2.jpg"));
            images.Add("test3", new Bitmap(@"C:\Users\Dev\Desktop\Flapy\Flapy\Flappy_3.jpg"));
            Sprite s = new Sprite("test", new Size(50, 50), images, 1, 1, new Point(50, 50), spSceneParam.Panel1);
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
            //jeu.UpdateValueSpriteSelected(tbxName.Text, new Size(Convert.ToInt32(tbxWidth.Text), Convert.ToInt32(tbxHeight.Text)), new Point(Convert.ToInt32(tbxPosX.Text), Convert.ToInt32(tbxPosY.Text)), image, Convert.ToInt32(tbxIntervalImage.Text), Convert.ToInt32(tbxCalque.Text), zOrder, cbxTag.Text, (int)nudDegreRotation.Value);
            //zOrder = 0;
            //UpdateList();
        }
    }
}

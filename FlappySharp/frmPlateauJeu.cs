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
    public partial class frmPlateauJeu : Form
    {
        List<Sprite> _sprites;
        public List<Sprite> Sprites { get => _sprites; set => _sprites = value; }

        public frmPlateauJeu()
        {
            InitializeComponent();
        }

        private void frmPlateauJeu_Load(object sender, EventArgs e)
        {
            foreach (var sprite in Sprites)
            {
                sprite.AddControlPlateauJeu(this);
                sprite.DemareAnimation();
            }
            tmp.Enabled = true;
        }

        private void tmp_Tick(object sender, EventArgs e)
        {
            foreach (var sprite in Sprites)
            {
                sprite.Deplacement();
            }
            CheckCollision();
            lblFps.Text = "FPS : " + (1000 / tmp.Interval);
        }

        private void frmPlateauJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmp.Enabled = false;
            foreach (var sprite in Sprites)
            {
                sprite.DemareAnimation();
            }
        }

        private void CheckCollision()
        {
            foreach (var spritePlayer in Sprites)
            {
                if (spritePlayer.TagSprite == "Player")
                {
                    foreach (var spriteCollision in Sprites)
                    {           
                        Rectangle rect = Rectangle.Intersect(spriteCollision.Collision, spritePlayer.Collision);
                        if (!rect.IsEmpty && spritePlayer.TagSprite != spriteCollision.TagSprite && spriteCollision.Calque == spritePlayer.Calque)
                        {
                            this.Close();   
                        }
                    }
                }
            }
        }

        private void frmPlateauJeu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                foreach (var sprite in Sprites)
                {
                    if (sprite.TagSprite == "Player")
                    {
                        sprite.ChangeValeurfinal(80);
                    }
                }
            }
        }
    }
}

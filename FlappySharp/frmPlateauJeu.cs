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

        /// <summary>
        /// Ajoute les Sprites dans les controls de la forme et demare l'animation des Sprite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlateauJeu_Load(object sender, EventArgs e)
        {
            foreach (var sprite in Sprites)
            {
                sprite.AjoutControlPlateauJeu(this);
                sprite.DemareAnimation();
            }
            tmp.Enabled = true;
        }

        /// <summary>
        /// Check la collision entre Sprites
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmp_Tick(object sender, EventArgs e)
        {
            foreach (var sprite in Sprites)
            {
                sprite.Deplacement();
            }
            CheckCollision();
            lblFps.Text = "FPS : " + (1000 / tmp.Interval);
        }

        /// <summary>
        /// Arrete l'annimation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlateauJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmp.Enabled = false;
            foreach (var sprite in Sprites)
            {
                sprite.DemareAnimation();
            }
        }

        /// <summary>
        /// Regarde la collision entre les Sprites
        /// </summary>
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

        /// <summary>
        /// Quand le button up est appuyé le player saute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlateauJeu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                foreach (var sprite in Sprites)
                {
                    if (sprite.TagSprite == "Player")
                    {
                        sprite.ChangePositionFinal(80);
                    }
                }
            }
        }
    }
}

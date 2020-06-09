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
using System.IO;
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
        }

        /// <summary>
        /// Crée un Sprite par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAjoutFlappy_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("Flappy_1.png", new Bitmap(Properties.Resources.Flappy_1));
            images.Add("Flappy_2.png", new Bitmap(Properties.Resources.Flappy_2));
            images.Add("Flappy_3.png", new Bitmap(Properties.Resources.Flappy_3));
            jeu.AddSprite("Flappy", new Size(50, 50), new Point(0, 0), images, 1, spSceneParam.Panel1);
        }

        /// <summary>
        /// Crée un Sprite par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAjoutFond_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("Fond.jpg", new Bitmap(Properties.Resources.Fond));
            jeu.AddSprite("Fond", new Size(100, 100), new Point(0, 0), images, 1, spSceneParam.Panel1);
        }

        /// <summary>
        /// Crée un Sprite par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAjoutSol_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("Sol.jpg", new Bitmap(Properties.Resources.Sol));
            jeu.AddSprite("Sol", new Size(100, 100), new Point(0, 0), images, 1, spSceneParam.Panel1);
        }

        /// <summary>
        /// Crée un Sprite par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAjoutTuyau_Click(object sender, EventArgs e)
        {
            Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
            images.Add("Tuyau.jpg", new Bitmap(Properties.Resources.Tuyau));
            jeu.AddSprite("Tuyau", new Size(100, 100), new Point(0, 0), images, 1, spSceneParam.Panel1);
        }

        /// <summary>
        /// Crée un Sprite par rapport au valeur choisie par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAjoutSprite_Click(object sender, EventArgs e)
        {
            frmAjoutSprite frmAjout = new frmAjoutSprite();

            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                jeu.AddSprite(frmAjout.GetNom(), frmAjout.GetTaille(), frmAjout.GetPosition(), frmAjout.GetImages(), frmAjout.GetCalque(), spSceneParam.Panel1);
            }
        }

        /// <summary>
        /// Diminue le ZOrder de 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpZOrder_Click(object sender, EventArgs e)
        {
            zOrder = -1;
        }

        /// <summary>
        /// Augemente le ZOrder de 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownZOrder_Click(object sender, EventArgs e)
        {
            zOrder = 1;
        }

        /// <summary>
        /// Sauvegarde les modifications apporter au Sprite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauveModif_Click(object sender, EventArgs e)
        {
            jeu.UpdateValueSpriteSelected(tbxNom.Text, new Size(Convert.ToInt32(tbxLargeur.Text), Convert.ToInt32(tbxHauteur.Text)), new Point(Convert.ToInt32(tbxPosX.Text), Convert.ToInt32(tbxPosY.Text)), images, Convert.ToInt32(tbxIntervalImage.Text), (int)nudCalque.Value, zOrder, cbxTag.Text, (int)nudRotation.Value);
            zOrder = 0;
        }

        /// <summary>
        /// Supprime le Sprite et met a vide tout les champs des Sprites
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Verifie si le sprite selectionner à changer et met les valeurs dans les champs du Sprite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                images = _spriteSelected.Images;
                foreach (var image in _spriteSelected.Images.Keys)
                {
                    lbxImages.Items.Add(image);
                }
                tbxIntervalImage.Text = _spriteSelected.IntervalEntreImage.ToString();
                cbxTag.Text = _spriteSelected.TagSprite;
                nudRotation.Value = _spriteSelected.AngleRotation;
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

        /// <summary>
        /// Ouvre la forme pour jouer au jeu 2D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlateauJeu plateauJeu = new frmPlateauJeu();
            plateauJeu.Sprites = jeu.Sprites;
            foreach (var sprite in plateauJeu.Sprites)
            {
                sprite.ActiverDesactiverEvenement(false);
            }

            plateauJeu.ShowDialog();
            foreach (var sprite in plateauJeu.Sprites)
            {
                sprite.ActiverDesactiverEvenement(true);
            }
            jeu.RefreshControl();
        }

        /// <summary>
        /// Fait l'enregistrement des Sprites
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreationProjet creationProjet = new frmCreationProjet();
            if (jeu.Sprites.Count != 0)
            {
                if (jeu.NomProjet == null)
                {
                    if (creationProjet.ShowDialog() == DialogResult.OK)
                    {
                        jeu.CreationDossierProjet(creationProjet.GetCheminDossier(), creationProjet.GetNomProjet());
                    }
                }

                if (jeu.CheminDossierProjet != null)
                {
                    jeu.XMLSerialize();
                }
            }
            else
            {
                MessageBox.Show("Il faut avoir des Sprites sur la scène pour sauvegarde le projet");
            }
        }

        /// <summary>
        /// Ouvre le chiffier xml pour crée les Sprite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdXml.ShowDialog() == DialogResult.OK)
            {
                jeu.CreateSpriteAfterDeserialize(spSceneParam.Panel1, ofdXml.FileName);
            }
        }

        /// <summary>
        /// Ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmAjoutSprite : Form
    {
        Dictionary<string, Bitmap> _images;
        Point _position;
        Size _taille;
        string _nom;
        int _calque;

        public frmAjoutSprite()
        {
            InitializeComponent();
            _images = new Dictionary<string, Bitmap>();
            _position = new Point(0, 0);
            _taille = new Size(0, 0);
        }

        /// <summary>
        /// Verifie si le champs est vide et change la valeur de la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (tbxName.Text != string.Empty)
                _nom = tbxName.Text;
            VerifieValeurVide();
        }

        /// <summary>
        /// Verifie si le champs est vide et change la valeur de la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPosX_TextChanged(object sender, EventArgs e)
        {
            if (tbxPosX.Text != string.Empty)
                _position.X = Convert.ToInt32(tbxPosX.Text);
            VerifieValeurVide();
        }

        /// <summary>
        /// Verifie si le champs est vide et change la valeur de la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPosY_TextChanged(object sender, EventArgs e)
        {
            if (tbxPosY.Text != string.Empty)
                _position.Y = Convert.ToInt32(tbxPosY.Text);
            VerifieValeurVide();
        }

        /// <summary>
        /// Verifie si le champs est vide et change la valeur de la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxHauteur_TextChanged(object sender, EventArgs e)
        {
            if (tbxHauteur.Text != string.Empty)
                _taille.Height = Convert.ToInt32(tbxHauteur.Text);
            VerifieValeurVide();
        }

        /// <summary>
        /// Verifie si le champs est vide et change la valeur de la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxLargeur_TextChanged(object sender, EventArgs e)
        {
            if (tbxLargeur.Text != string.Empty)
                _taille.Width = Convert.ToInt32(tbxLargeur.Text);
            VerifieValeurVide();
        }

        /// <summary>
        /// Verifie si le champs est vide et change la valeur de la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxCalque_TextChanged(object sender, EventArgs e)
        {
            if (tbxCalque.Text != string.Empty)
                _calque = Convert.ToInt32(tbxCalque.Text);
            VerifieValeurVide();
        }

        /// <summary>
        /// Ajoute dans la liste une image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnAjoutImage_Click(object sender, EventArgs e)
        {
            if (lfd.ShowDialog() == DialogResult.OK)
            {
                foreach (var fichier in lfd.FileNames)
                {
                    _images.Add(Path.GetFileName(fichier), new Bitmap(fichier));
                    lbxImage.Items.Add(Path.GetFileName(fichier));
                }
            }
            VerifieValeurVide();
        }

        /// <summary>
        /// Verifie si le caractère est un chiffre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifieNombre(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Verifie si les champs sont vide oui ou non et active le button ok en fonction
        /// </summary>
        private void VerifieValeurVide()
        {
            if (tbxName.Text == string.Empty || tbxPosX.Text == string.Empty || tbxPosY.Text == string.Empty || tbxLargeur.Text == string.Empty || tbxHauteur.Text == string.Empty || tbxCalque.Text == string.Empty || lbxImage.Items.Count == 0)
            {
                btnOk.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
            }
        }

        /// <summary>
        /// Reourne le nom du Sprite
        /// </summary>
        /// <returns>Nom du Sprite</returns>
        public string GetNom()
        {
            return _nom;
        }

        /// <summary>
        /// Reourne le calque du Sprite
        /// </summary>
        /// <returns>Calque du Sprite</returns>
        public int GetCalque()
        {
            return _calque;
        }

        /// <summary>
        /// Reourne la position du Sprite
        /// </summary>
        /// <returns>Position du Sprite</returns>
        public Point GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Reourne la taille du Sprite
        /// </summary>
        /// <returns>Taille du Sprite</returns>
        public Size GetTaille()
        {
            return _taille;
        }

        /// <summary>
        /// Reourne les images du Sprite
        /// </summary>
        /// <returns>Images du Sprite</returns>
        public Dictionary<string,Bitmap> GetImages()
        {
            return _images;
        }
    }
}

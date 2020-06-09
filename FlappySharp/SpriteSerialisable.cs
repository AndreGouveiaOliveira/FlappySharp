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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappySharp
{
    public class SpriteSerialisable
    {
        Point _position;
        Size _taille;
        List<string> _nomImages;
        string _cheminDossier;
        string _tagSprite;
        string _nom;
        int _calque;
        int _zOrder;
        int _intervalEntreImage;
        int _angleRotation;

        public Point Position { get => _position; set => _position = value; }
        public Size Taille { get => _taille; set => _taille = value; }
        public List<string> NomImages { get => _nomImages; set => _nomImages = value; }
        public string CheminDossier { get => _cheminDossier; set => _cheminDossier = value; }
        public string TagSprite { get => _tagSprite; set => _tagSprite = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Calque { get => _calque; set => _calque = value; }
        public int ZOrder { get => _zOrder; set => _zOrder = value; }
        public int IntervalEntreImage { get => _intervalEntreImage; set => _intervalEntreImage = value; }
        public int AngleRotation { get => _angleRotation; set => _angleRotation = value; }

        public SpriteSerialisable()
        {

        }

        /// <summary>
        /// Met les valeur à jour
        /// </summary>
        /// <param name="nomImages"></param>
        /// <param name="cheminDossier"></param>
        /// <param name="nom"></param>
        /// <param name="position"></param>
        /// <param name="taille"></param>
        /// <param name="calque"></param>
        /// <param name="zOrder"></param>
        /// <param name="intervalEntreImage"></param>
        /// <param name="angleRotation"></param>
        /// <param name="tagSprite"></param>
        public void SetValue(List<string> nomImages, string cheminDossier, string nom, Point position, Size taille, int calque, int zOrder, int intervalEntreImage, int angleRotation, string tagSprite)
        {
            Position = position;
            Taille = taille;
            NomImages = nomImages;
            CheminDossier = cheminDossier;
            TagSprite = tagSprite;
            Nom = nom;
            Calque = calque;
            ZOrder = zOrder;
            IntervalEntreImage = intervalEntreImage;
            AngleRotation = angleRotation;
        }
    }
}

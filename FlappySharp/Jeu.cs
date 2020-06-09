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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlappySharp
{
    [Serializable()]
    class Jeu
    {
        List<Sprite> _sprites;
        List<SpriteSerialisable> _spriteSerialisables;

        Sprite _spriteSelected;

        string _nomProjet;
        string _cheminDossierProjet;

        internal List<Sprite> Sprites { get => _sprites; set => _sprites = value; }
        public string NomProjet { get => _nomProjet; set => _nomProjet = value; }
        public string CheminDossierProjet { get => _cheminDossierProjet; set => _cheminDossierProjet = value; }

        public Jeu()
        {
            Sprites = new List<Sprite>();
            _spriteSerialisables = new List<SpriteSerialisable>();
        }

        /// <summary>
        /// Crée un nouveau Sprite et ajoute dans la liste des Sprites
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="taille"></param>
        /// <param name="position"></param>
        /// <param name="images"></param>
        /// <param name="calque"></param>
        /// <param name="panelScene"></param>
        public void AddSprite(string nom, Size taille, Point position, Dictionary<string, Bitmap> images, int calque, Panel panelScene)
        {
            int zOrder = 0;

            if (Sprites.Count != 0 && Sprites.Where((sprite) => sprite.Calque == calque).Count() != 0)
            {
                zOrder = Sprites.Where((sprite) => sprite.Calque == calque).OrderByDescending(sprite => sprite.ZOrder).First().ZOrder;
                zOrder++;
            }

            Sprites.Add(new Sprite(CheckNomExist(nom), taille, images, calque, zOrder, position, panelScene));

            RefreshControl();
        }

        /// <summary>
        /// Met à jour l'affichage des Sprites
        /// </summary>
        public void RefreshControl()
        {
            Sprites.ForEach(sprite => sprite.SuprControlPanel(false));

            Sprites = Sprites.OrderBy(s => s.Calque).ThenBy(s => s.ZOrder).ToList<Sprite>();

            Sprites.ForEach(sprite => sprite.AjoutControlPanel());
        }

        /// <summary>
        /// Change le zOrder du Sprite
        /// </summary>
        /// <param name="spriteZOrderChanger">Le sprite dont le zOrder à changer</param>
        private void ModifZOrder(Sprite spriteZOrderChanger)
        {
            if (Sprites.Count != 0)
            {
                foreach (var spiteChangementZOrder in Sprites)
                {
                    if (spriteZOrderChanger.Name != spiteChangementZOrder.Name && spriteZOrderChanger.ZOrder == spiteChangementZOrder.ZOrder && spriteZOrderChanger.Calque == spiteChangementZOrder.Calque)
                    {
                        if (spriteZOrderChanger.ModificationZOrder == "+")
                        {
                            spiteChangementZOrder.ZOrder -= 1;
                            spriteZOrderChanger.ModificationZOrder = null;
                        }
                        else if (spriteZOrderChanger.ModificationZOrder == "-")
                        {
                            spiteChangementZOrder.ZOrder += 1;
                            spriteZOrderChanger.ModificationZOrder = null;
                        }
                    }
                }
            }
            RefreshControl();
        }

        /// <summary>
        /// Met à jour les valeurs du sprite selectionner
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="size"></param>
        /// <param name="location"></param>
        /// <param name="images"></param>
        /// <param name="intervalImage"></param>
        /// <param name="calque"></param>
        /// <param name="zOrder"></param>
        /// <param name="tag"></param>
        /// <param name="rotation"></param>
        public void UpdateValueSpriteSelected(string nom, Size size, Point location, Dictionary<string, Bitmap> images, int intervalImage, int calque, int zOrder, string tag, int rotation)
        {
            if (_spriteSelected.Calque == calque)
            {
                if (_spriteSelected.ZOrder < _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, _spriteSelected.ZOrder + zOrder, tag, rotation);
                    _spriteSelected.ModificationZOrder = "+";
                    ModifZOrder(_spriteSelected);
                }

                if (_spriteSelected.ZOrder > _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, _spriteSelected.ZOrder + zOrder, tag, rotation);
                    _spriteSelected.ModificationZOrder = "-";
                    ModifZOrder(_spriteSelected);
                }

                if (_spriteSelected.ZOrder == _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, zOrder, tag, rotation);

                    RefreshControl();
                }
            }
            else
            {
                zOrder = 0;

                if (Sprites.Count != 0 && Sprites.Where((sprite) => sprite.Calque == calque).Count() != 0)
                {
                    zOrder = Sprites.Where((sprite) => sprite.Calque == calque).OrderByDescending(sprite => sprite.ZOrder).First().ZOrder;
                    zOrder++;
                }
                _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, zOrder, tag, rotation);

                RefreshControl();
            }
        }

        /// <summary>
        /// Récupère les données du Sprite selectionner
        /// </summary>
        /// <returns></returns>
        public Sprite GetValueSpriteSelected()
        {
            foreach (var sprite in Sprites)
            {
                if (sprite.Selected && sprite != _spriteSelected)
                {
                    _spriteSelected = sprite;
                    _spriteSelected.Selected = false;
                }
            }

            return _spriteSelected;
        }

        /// <summary>
        /// Permet de vérifier si le nom du Sprite qu'on ajoute existe
        /// </summary>
        /// <param name="checkNomSprite">Le nom du sprite à verifier</param>
        /// <returns></returns>
        private string CheckNomExist(string checkNomSprite)
        {
            string nomModifier = checkNomSprite;
            int compteur = 1;
            if (Sprites.Count != 0)
            {
                while (Sprites.Where((sprite) => sprite.Name == nomModifier).Count() != 0)
                {
                    nomModifier = checkNomSprite + compteur;
                    compteur++;
                }
            }
            return nomModifier;
        }

        public void CreationDossierProjet(string cheminDossierProjet, string nomProjet)
        {
            NomProjet = nomProjet;
            CheminDossierProjet = cheminDossierProjet;
            Directory.CreateDirectory(Path.Combine(cheminDossierProjet, nomProjet));
            foreach (var sprite in Sprites)
            {
                sprite.CreationDossier(Path.Combine(cheminDossierProjet, nomProjet));
            }
        }

        /// <summary>
        /// Transforme la liste de sprite en liste de spirteSerialisable et serialise la liste de spriteSerialisable
        /// </summary>
        public void XMLSerialize()
        {
            foreach (var sprite in Sprites)
            {
                SpriteSerialisable spriteSerialise = new SpriteSerialisable();

                List<string> nomImages = new List<string>();

                foreach (var nomImage in sprite.Images.Keys)
                {
                    nomImages.Add(nomImage);
                }

                spriteSerialise.SetValue(nomImages, sprite.CheminDossierImage, sprite.Name, sprite.Location, sprite.Size, sprite.Calque, sprite.ZOrder, sprite.IntervalEntreImage, sprite.AngleRotation, sprite.TagSprite);

                _spriteSerialisables.Add(spriteSerialise);
            }

            Stream stream = File.Open(Path.Combine(CheminDossierProjet, Path.Combine(NomProjet, NomProjet + ".xml")), FileMode.Create);
            XmlSerializer formatter = new XmlSerializer(typeof(List<SpriteSerialisable>));
            formatter.Serialize(stream, _spriteSerialisables);
            stream.Close();
        }

        /// <summary>
        /// Transforme la liste de spriteSerialisable en liste de sprite
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="cheminXml"></param>
        public void CreateSpriteAfterDeserialize(Panel panel, string cheminXml)
        {
            _spriteSerialisables.Clear();
            foreach (var sprite in Sprites)
            {
                sprite.SuprControlPanel(true);
            }
            Dictionary<string, Bitmap> images;
            _spriteSerialisables = XMLDeserialize(cheminXml);
            foreach (var spriteSerialize in _spriteSerialisables)
            {
                _cheminDossierProjet = spriteSerialize.CheminDossier;
                images = new Dictionary<string, Bitmap>();

                foreach (var nomImage in spriteSerialize.NomImages)
                {
                    images.Add(nomImage, new Bitmap(Path.Combine(spriteSerialize.CheminDossier, Path.Combine(spriteSerialize.Nom, nomImage))));
                }

                Sprites.Add(new Sprite(spriteSerialize.Nom, spriteSerialize.Taille, images, spriteSerialize.Calque, spriteSerialize.ZOrder, spriteSerialize.Position, panel));
            }
            RefreshControl();
        }

        /// <summary>
        /// Deserialise le fichier
        /// </summary>
        /// <param name="cheminXml"></param>
        /// <returns></returns>
        public List<SpriteSerialisable> XMLDeserialize(string cheminXml)
        {
            Stream stream = File.Open(cheminXml, FileMode.Open);
            XmlSerializer formatter = new XmlSerializer(typeof(List<SpriteSerialisable>));
            List<SpriteSerialisable> obj = (List<SpriteSerialisable>)formatter.Deserialize(stream);
            stream.Close();
            return obj;
        }
    }
}

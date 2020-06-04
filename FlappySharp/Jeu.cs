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

        public Jeu()
        {
            Sprites = new List<Sprite>();
            _spriteSerialisables = new List<SpriteSerialisable>();
        }

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

        public void RefreshControl()
        {
            Sprites.ForEach(sprite => sprite.SuprControlPanel(false));

            Sprites = Sprites.OrderBy(s => s.Calque).ThenBy(s => s.ZOrder).ToList<Sprite>();

            Sprites.ForEach(sprite => sprite.AjoutControlPanel());
        }

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

        public void UpdateValueSpriteSelected(string nom, Size size, Point location, Dictionary<string, Bitmap> images, int intervalImage, int calque, int zOrder, string tag, int rotation)
        {
            if (_spriteSelected.Calque == calque)
            {
                if (_spriteSelected.ZOrder < _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, _spriteSelected.ZOrder + zOrder, tag, rotation);
                    //_spriteSelected.DescendreZOrder();
                    _spriteSelected.ModificationZOrder = "+";
                    ModifZOrder(_spriteSelected);
                }

                if (_spriteSelected.ZOrder > _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, _spriteSelected.ZOrder + zOrder, tag, rotation);
                    //_spriteSelected.MonterZOrder();
                    _spriteSelected.ModificationZOrder = "-";
                    ModifZOrder(_spriteSelected);
                }

                if (_spriteSelected.ZOrder == _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, zOrder, tag, rotation);
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
            _nomProjet = nomProjet;
            _cheminDossierProjet = cheminDossierProjet;
            Directory.CreateDirectory(cheminDossierProjet + nomProjet);
        }

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
            Stream stream = File.Open(_cheminDossierProjet + _nomProjet+".xml", FileMode.Create);
            XmlSerializer formatter = new XmlSerializer(typeof(List<SpriteSerialisable>));
            formatter.Serialize(stream, _spriteSerialisables);
            stream.Close();
        }

        public List<SpriteSerialisable> XMLDeserialize()
        {
            Stream stream = File.Open("shapeList.xml", FileMode.Open);
            XmlSerializer formatter = new XmlSerializer(typeof(List<SpriteSerialisable>));
            List<SpriteSerialisable> obj = (List<SpriteSerialisable>)formatter.Deserialize(stream);
            stream.Close();
            return obj;
        }

        public void CreateSpriteAfterDeserialize(Panel panel)
        {
            Dictionary<string, Bitmap> images;
            _spriteSerialisables = XMLDeserialize();
            foreach (var spriteSerialize in _spriteSerialisables)
            {
                images = new Dictionary<string, Bitmap>();

                foreach (var nomImage in spriteSerialize.NomImages)
                {
                    images.Add(nomImage, new Bitmap(spriteSerialize.CheminDossier + nomImage));
                }

                Sprites.Add(new Sprite(spriteSerialize.Nom, spriteSerialize.Taille, images, spriteSerialize.Calque, spriteSerialize.ZOrder, spriteSerialize.Position, panel));

                foreach (var sprite in Sprites)
                {
                    if (spriteSerialize.Nom == sprite.Name)
                    {
                        sprite.UpdateValue(spriteSerialize.Nom, spriteSerialize.Taille, spriteSerialize.Position, images, spriteSerialize.IntervalEntreImage, spriteSerialize.Calque, spriteSerialize.ZOrder, spriteSerialize.TagSprite, spriteSerialize.AngleRotation);
                    }
                }
            }
            RefreshControl();
        }
    }
}

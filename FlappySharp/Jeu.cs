using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappySharp
{
    class Jeu
    {
        List<Sprite> _sprites;

        Sprite _spriteSelected;

        internal List<Sprite> Sprites { get => _sprites; set => _sprites = value; }

        public Jeu()
        {
            Sprites = new List<Sprite>();
        }

        public void AddSprite(string nom, Size taille, Point position, Dictionary<string, Bitmap> images, int calque, Panel panelScene)
        {
            int zOrder = 0;

            if (Sprites.Count != 0 && Sprites.Where((sprite) => sprite.Calque == calque).Count() != 0)
            {
                zOrder = Sprites.Where((sprite) => sprite.Calque == calque).OrderByDescending(sprite => sprite.ZOrder).First().ZOrder;
                zOrder++;
            }

            Sprites.Add(new Sprite(nom, taille, images, calque, zOrder, position, panelScene));

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
                    _spriteSelected.DescendreZOrder();
                    ModifZOrder(_spriteSelected);
                }

                if (_spriteSelected.ZOrder > _spriteSelected.ZOrder + zOrder)
                {
                    _spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, _spriteSelected.ZOrder + zOrder, tag, rotation);
                    _spriteSelected.MonterZOrder();
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
    }
}

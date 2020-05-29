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

        Sprite spriteSelected;

        public Jeu()
        {
            _sprites = new List<Sprite>();
        }

        public void AddSprite(string nom, Size taille, Point position, Dictionary<string,Bitmap> images, int calque, Panel panelScene)
        {
            int zOrder = 0;

            if (_sprites.Count != 0 && _sprites.Where((sprite) => sprite.Calque == calque).Count() != 0)
            {
                zOrder = _sprites.Where((sprite) => sprite.Calque == calque).OrderByDescending(sprite => sprite.ZOrder).First().ZOrder;
                zOrder++;
            }

            _sprites.Add(new Sprite(nom, taille, images, calque, zOrder, position, panelScene));

            RefreshControl();
        }

        public void RefreshControl()
        {
            _sprites.ForEach(sprite => sprite.SuprControlPanel(false));

            _sprites = _sprites.OrderBy(s => s.Calque).ThenBy(s => s.ZOrder).ToList<Sprite>();

            _sprites.ForEach(sprite => sprite.AjoutControlPanel());
        }

        private void ModifZOrder(Sprite spriteZOrderChanger)
        {
            if (_sprites.Count != 0)
            {
                foreach (var spiteChangementZOrder in _sprites)
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

        public void UpdateValueSpriteSelected(string nom, Size size, Point location, Dictionary<string,Bitmap> images, int intervalImage, int calque, int zOrder, string tag, int rotation)
        {
            if (spriteSelected.Calque == calque)
            {
                if (spriteSelected.ZOrder < spriteSelected.ZOrder + zOrder)
                {
                    spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, spriteSelected.ZOrder + zOrder, tag, rotation);
                    spriteSelected.DescendreZOrder();
                    ModifZOrder(spriteSelected);
                }

                if (spriteSelected.ZOrder > spriteSelected.ZOrder + zOrder)
                {
                    spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, spriteSelected.ZOrder + zOrder, tag, rotation);
                    spriteSelected.MonterZOrder();
                    ModifZOrder(spriteSelected);
                }

                if (spriteSelected.ZOrder == spriteSelected.ZOrder + zOrder)
                {
                    spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, zOrder, tag, rotation);
                }
            }
            else
            {
                zOrder = 0;

                if (_sprites.Count != 0 && _sprites.Where((sprite) => sprite.Calque == calque).Count() != 0)
                {
                    zOrder = _sprites.Where((sprite) => sprite.Calque == calque).OrderByDescending(sprite => sprite.ZOrder).First().ZOrder;
                    zOrder++;
                }
                spriteSelected.UpdateValue(nom, size, location, images, intervalImage, calque, zOrder, tag, rotation);

                RefreshControl();
            }
        }

        public Sprite GetValueSpriteSelected()
        {
            foreach (var sprite in _sprites)
            {
                if (sprite.Selected && sprite != spriteSelected)
                {
                    spriteSelected = sprite;
                    spriteSelected.Selected = false;
                }
            }
            return spriteSelected;
        }
    }
}

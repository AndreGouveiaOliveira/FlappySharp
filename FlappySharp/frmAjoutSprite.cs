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

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (tbxName.Text != string.Empty)
                _nom = tbxName.Text;
            VerifieValeurVide();
        }

        private void tbxPosX_TextChanged(object sender, EventArgs e)
        {
            if (tbxPosX.Text != string.Empty)
                _position.X = Convert.ToInt32(tbxPosX.Text);
            VerifieValeurVide();
        }

        private void tbxPosY_TextChanged(object sender, EventArgs e)
        {
            if (tbxPosY.Text != string.Empty)
                _position.Y = Convert.ToInt32(tbxPosY.Text);
            VerifieValeurVide();
        }

        private void tbxHauteur_TextChanged(object sender, EventArgs e)
        {
            if (tbxHauteur.Text != string.Empty)
                _taille.Height = Convert.ToInt32(tbxHauteur.Text);
            VerifieValeurVide();
        }

        private void tbxLargeur_TextChanged(object sender, EventArgs e)
        {
            if (tbxLargeur.Text != string.Empty)
                _taille.Width = Convert.ToInt32(tbxLargeur.Text);
            VerifieValeurVide();
        }

        private void tbxCalque_TextChanged(object sender, EventArgs e)
        {
            if (tbxCalque.Text != string.Empty)
                _calque = Convert.ToInt32(tbxCalque.Text);
            VerifieValeurVide();
        }

        // trouver ce bout de code sur https://www.aspsnippets.com/Articles/Windows-Forms-WinForms-OpenFileDialog-Box-Tutorial-with-example-in-C-and-VBNet.aspx#:~:text=In%20order%20to%20select%20a%20Multiple%20Files%2C%20the%20Multiselect%20property,in%20the%20Windows%20Forms%20MessageBox.
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

        private void VerifieNombre(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

        public string GetNom()
        {
            return _nom;
        }

        public int GetCalque()
        {
            return _calque;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public Size GetTaille()
        {
            return _taille;
        }

        public Dictionary<string,Bitmap> GetImages()
        {
            return _images;
        }
    }
}

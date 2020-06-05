using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappySharp
{
    public partial class frmCreationProjet : Form
    {
        public frmCreationProjet()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (tbxCheminDossier.Text != string.Empty && tbxNomProjet.Text != string.Empty)
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void btnCheminDossier_Click(object sender, EventArgs e)
        {
            if (fbdDossierProjet.ShowDialog() == DialogResult.OK)
            {
                tbxCheminDossier.Text = fbdDossierProjet.SelectedPath;
            }
        }

        public string GetNomProjet()
        {
            return tbxNomProjet.Text;
        }

        public string GetCheminDossier()
        {
            return tbxCheminDossier.Text;
        }
    }
}

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

        /// <summary>
        /// Active ou Desactive le button OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Recupere le chemin du dossier selectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheminDossier_Click(object sender, EventArgs e)
        {
            if (fbdDossierProjet.ShowDialog() == DialogResult.OK)
            {
                tbxCheminDossier.Text = fbdDossierProjet.SelectedPath;
            }
        }

        /// <summary>
        /// Retourne le nom du projet 
        /// </summary>
        /// <returns>Nom du projet</returns>
        public string GetNomProjet()
        {
            return tbxNomProjet.Text;
        }

        /// <summary>
        /// Retourne le chemin du dossier
        /// </summary>
        /// <returns>Chemin du dossier</returns>
        public string GetCheminDossier()
        {
            return tbxCheminDossier.Text;
        }
    }
}

namespace FlappySharp
{
    partial class frmCreationProjet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNomProjet = new System.Windows.Forms.TextBox();
            this.tbxCheminDossier = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheminDossier = new System.Windows.Forms.Button();
            this.fbdDossierProjet = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbxNomProjet
            // 
            this.tbxNomProjet.Location = new System.Drawing.Point(12, 25);
            this.tbxNomProjet.Name = "tbxNomProjet";
            this.tbxNomProjet.Size = new System.Drawing.Size(204, 20);
            this.tbxNomProjet.TabIndex = 0;
            this.tbxNomProjet.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // tbxCheminDossier
            // 
            this.tbxCheminDossier.Location = new System.Drawing.Point(12, 75);
            this.tbxCheminDossier.Name = "tbxCheminDossier";
            this.tbxCheminDossier.ReadOnly = true;
            this.tbxCheminDossier.Size = new System.Drawing.Size(204, 20);
            this.tbxCheminDossier.TabIndex = 1;
            this.tbxCheminDossier.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(12, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(118, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom du projet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chemin du dossier :";
            // 
            // btnCheminDossier
            // 
            this.btnCheminDossier.Location = new System.Drawing.Point(105, 101);
            this.btnCheminDossier.Name = "btnCheminDossier";
            this.btnCheminDossier.Size = new System.Drawing.Size(111, 23);
            this.btnCheminDossier.TabIndex = 6;
            this.btnCheminDossier.Text = "Slectionner dossier";
            this.btnCheminDossier.UseVisualStyleBackColor = true;
            this.btnCheminDossier.Click += new System.EventHandler(this.btnCheminDossier_Click);
            // 
            // CreationProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 183);
            this.Controls.Add(this.btnCheminDossier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxCheminDossier);
            this.Controls.Add(this.tbxNomProjet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreationProjet";
            this.Text = "Création projet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNomProjet;
        private System.Windows.Forms.TextBox tbxCheminDossier;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheminDossier;
        private System.Windows.Forms.FolderBrowserDialog fbdDossierProjet;
    }
}
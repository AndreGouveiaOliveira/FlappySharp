namespace FlappySharp
{
    partial class frmAjoutSprite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutSprite));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAjoutImage = new System.Windows.Forms.Button();
            this.tbxPosX = new System.Windows.Forms.TextBox();
            this.tbxPosY = new System.Windows.Forms.TextBox();
            this.tbxLargeur = new System.Windows.Forms.TextBox();
            this.tbxHauteur = new System.Windows.Forms.TextBox();
            this.tbxCalque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxImage = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lfd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(10, 22);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(168, 20);
            this.tbxName.TabIndex = 0;
            // 
            // btnAjoutImage
            // 
            this.btnAjoutImage.Location = new System.Drawing.Point(10, 355);
            this.btnAjoutImage.Name = "btnAjoutImage";
            this.btnAjoutImage.Size = new System.Drawing.Size(168, 23);
            this.btnAjoutImage.TabIndex = 1;
            this.btnAjoutImage.Text = "Ajouter une image";
            this.btnAjoutImage.UseVisualStyleBackColor = true;
            // 
            // tbxPosX
            // 
            this.tbxPosX.Location = new System.Drawing.Point(34, 67);
            this.tbxPosX.Name = "tbxPosX";
            this.tbxPosX.Size = new System.Drawing.Size(144, 20);
            this.tbxPosX.TabIndex = 2;
            // 
            // tbxPosY
            // 
            this.tbxPosY.Location = new System.Drawing.Point(34, 93);
            this.tbxPosY.Name = "tbxPosY";
            this.tbxPosY.Size = new System.Drawing.Size(144, 20);
            this.tbxPosY.TabIndex = 3;
            // 
            // tbxLargeur
            // 
            this.tbxLargeur.Location = new System.Drawing.Point(58, 170);
            this.tbxLargeur.Name = "tbxLargeur";
            this.tbxLargeur.Size = new System.Drawing.Size(120, 20);
            this.tbxLargeur.TabIndex = 5;
            // 
            // tbxHauteur
            // 
            this.tbxHauteur.Location = new System.Drawing.Point(58, 144);
            this.tbxHauteur.Name = "tbxHauteur";
            this.tbxHauteur.Size = new System.Drawing.Size(120, 20);
            this.tbxHauteur.TabIndex = 4;
            // 
            // tbxCalque
            // 
            this.tbxCalque.Location = new System.Drawing.Point(12, 217);
            this.tbxCalque.Name = "tbxCalque";
            this.tbxCalque.Size = new System.Drawing.Size(166, 20);
            this.tbxCalque.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hauteur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Taille";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Largeur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Calque";
            // 
            // lbxImage
            // 
            this.lbxImage.FormattingEnabled = true;
            this.lbxImage.Location = new System.Drawing.Point(10, 254);
            this.lbxImage.Name = "lbxImage";
            this.lbxImage.Size = new System.Drawing.Size(168, 95);
            this.lbxImage.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(10, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(10, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lfd
            // 
            this.lfd.FileName = "openFileDialog1";
            // 
            // frmAjoutSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbxImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCalque);
            this.Controls.Add(this.tbxLargeur);
            this.Controls.Add(this.tbxHauteur);
            this.Controls.Add(this.tbxPosY);
            this.Controls.Add(this.tbxPosX);
            this.Controls.Add(this.btnAjoutImage);
            this.Controls.Add(this.tbxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAjoutSprite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout Sprite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAjoutImage;
        private System.Windows.Forms.TextBox tbxPosX;
        private System.Windows.Forms.TextBox tbxPosY;
        private System.Windows.Forms.TextBox tbxLargeur;
        private System.Windows.Forms.TextBox tbxHauteur;
        private System.Windows.Forms.TextBox tbxCalque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog lfd;
    }
}
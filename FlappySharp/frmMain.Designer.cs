namespace FlappySharp
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spSceneParam = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxHauteur = new System.Windows.Forms.TextBox();
            this.tbxLargeur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDownZOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpZOrder = new System.Windows.Forms.Button();
            this.nudCalque = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPosX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPosY = new System.Windows.Forms.TextBox();
            this.btnAjoutImages = new System.Windows.Forms.Button();
            this.btnSauveModif = new System.Windows.Forms.Button();
            this.btnSupr = new System.Windows.Forms.Button();
            this.nudRotation = new System.Windows.Forms.NumericUpDown();
            this.lbxImages = new System.Windows.Forms.ListBox();
            this.cbxTag = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIntervalImage = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tmp = new System.Windows.Forms.Timer(this.components);
            this.pbxAjoutSprite = new System.Windows.Forms.PictureBox();
            this.pbxAjoutTuyau = new System.Windows.Forms.PictureBox();
            this.pbxAjoutSol = new System.Windows.Forms.PictureBox();
            this.pbxAjoutFond = new System.Windows.Forms.PictureBox();
            this.pbxAjoutFlappy = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSceneParam)).BeginInit();
            this.spSceneParam.Panel2.SuspendLayout();
            this.spSceneParam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalque)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutTuyau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutFond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutFlappy)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spSceneParam);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbxAjoutSprite);
            this.splitContainer1.Panel2.Controls.Add(this.pbxAjoutTuyau);
            this.splitContainer1.Panel2.Controls.Add(this.pbxAjoutSol);
            this.splitContainer1.Panel2.Controls.Add(this.pbxAjoutFond);
            this.splitContainer1.Panel2.Controls.Add(this.pbxAjoutFlappy);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 550);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 1;
            // 
            // spSceneParam
            // 
            this.spSceneParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spSceneParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spSceneParam.Location = new System.Drawing.Point(0, 0);
            this.spSceneParam.Name = "spSceneParam";
            // 
            // spSceneParam.Panel2
            // 
            this.spSceneParam.Panel2.Controls.Add(this.groupBox1);
            this.spSceneParam.Panel2.Controls.Add(this.groupBox2);
            this.spSceneParam.Panel2.Controls.Add(this.groupBox3);
            this.spSceneParam.Panel2.Controls.Add(this.btnAjoutImages);
            this.spSceneParam.Panel2.Controls.Add(this.btnSauveModif);
            this.spSceneParam.Panel2.Controls.Add(this.btnSupr);
            this.spSceneParam.Panel2.Controls.Add(this.nudRotation);
            this.spSceneParam.Panel2.Controls.Add(this.lbxImages);
            this.spSceneParam.Panel2.Controls.Add(this.cbxTag);
            this.spSceneParam.Panel2.Controls.Add(this.label10);
            this.spSceneParam.Panel2.Controls.Add(this.label9);
            this.spSceneParam.Panel2.Controls.Add(this.label5);
            this.spSceneParam.Panel2.Controls.Add(this.label4);
            this.spSceneParam.Panel2.Controls.Add(this.label1);
            this.spSceneParam.Panel2.Controls.Add(this.tbxIntervalImage);
            this.spSceneParam.Panel2.Controls.Add(this.tbxNom);
            this.spSceneParam.Size = new System.Drawing.Size(1002, 461);
            this.spSceneParam.SplitterDistance = 738;
            this.spSceneParam.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxHauteur);
            this.groupBox1.Controls.Add(this.tbxLargeur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 51);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taille";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Largeur";
            // 
            // tbxHauteur
            // 
            this.tbxHauteur.Location = new System.Drawing.Point(173, 19);
            this.tbxHauteur.Name = "tbxHauteur";
            this.tbxHauteur.Size = new System.Drawing.Size(56, 20);
            this.tbxHauteur.TabIndex = 2;
            // 
            // tbxLargeur
            // 
            this.tbxLargeur.Location = new System.Drawing.Point(55, 19);
            this.tbxLargeur.Name = "tbxLargeur";
            this.tbxLargeur.Size = new System.Drawing.Size(56, 20);
            this.tbxLargeur.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hauteur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDownZOrder);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnUpZOrder);
            this.groupBox2.Controls.Add(this.nudCalque);
            this.groupBox2.Location = new System.Drawing.Point(10, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 74);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calque et ZOrder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Calque";
            // 
            // btnDownZOrder
            // 
            this.btnDownZOrder.Location = new System.Drawing.Point(178, 42);
            this.btnDownZOrder.Name = "btnDownZOrder";
            this.btnDownZOrder.Size = new System.Drawing.Size(47, 23);
            this.btnDownZOrder.TabIndex = 24;
            this.btnDownZOrder.Text = "Down";
            this.btnDownZOrder.UseVisualStyleBackColor = true;
            this.btnDownZOrder.Click += new System.EventHandler(this.btnDownZOrder_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "ZOrder";
            // 
            // btnUpZOrder
            // 
            this.btnUpZOrder.Location = new System.Drawing.Point(178, 13);
            this.btnUpZOrder.Name = "btnUpZOrder";
            this.btnUpZOrder.Size = new System.Drawing.Size(47, 23);
            this.btnUpZOrder.TabIndex = 23;
            this.btnUpZOrder.Text = "Up";
            this.btnUpZOrder.UseVisualStyleBackColor = true;
            this.btnUpZOrder.Click += new System.EventHandler(this.btnUpZOrder_Click);
            // 
            // nudCalque
            // 
            this.nudCalque.Location = new System.Drawing.Point(59, 31);
            this.nudCalque.Name = "nudCalque";
            this.nudCalque.Size = new System.Drawing.Size(55, 20);
            this.nudCalque.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbxPosX);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbxPosY);
            this.groupBox3.Location = new System.Drawing.Point(10, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 39);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "X";
            // 
            // tbxPosX
            // 
            this.tbxPosX.Location = new System.Drawing.Point(25, 13);
            this.tbxPosX.Name = "tbxPosX";
            this.tbxPosX.Size = new System.Drawing.Size(86, 20);
            this.tbxPosX.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // tbxPosY
            // 
            this.tbxPosY.Location = new System.Drawing.Point(142, 13);
            this.tbxPosY.Name = "tbxPosY";
            this.tbxPosY.Size = new System.Drawing.Size(86, 20);
            this.tbxPosY.TabIndex = 5;
            // 
            // btnAjoutImages
            // 
            this.btnAjoutImages.Location = new System.Drawing.Point(141, 176);
            this.btnAjoutImages.Name = "btnAjoutImages";
            this.btnAjoutImages.Size = new System.Drawing.Size(105, 23);
            this.btnAjoutImages.TabIndex = 22;
            this.btnAjoutImages.Text = "Ajouter des images";
            this.btnAjoutImages.UseVisualStyleBackColor = true;
            // 
            // btnSauveModif
            // 
            this.btnSauveModif.Enabled = false;
            this.btnSauveModif.Location = new System.Drawing.Point(117, 419);
            this.btnSauveModif.Name = "btnSauveModif";
            this.btnSauveModif.Size = new System.Drawing.Size(137, 32);
            this.btnSauveModif.TabIndex = 21;
            this.btnSauveModif.Text = "Sauvegarder Modification";
            this.btnSauveModif.UseVisualStyleBackColor = true;
            this.btnSauveModif.Click += new System.EventHandler(this.btnSauveModif_Click);
            // 
            // btnSupr
            // 
            this.btnSupr.Enabled = false;
            this.btnSupr.Location = new System.Drawing.Point(3, 419);
            this.btnSupr.Name = "btnSupr";
            this.btnSupr.Size = new System.Drawing.Size(108, 32);
            this.btnSupr.TabIndex = 20;
            this.btnSupr.Text = "Supprimer";
            this.btnSupr.UseVisualStyleBackColor = true;
            this.btnSupr.Click += new System.EventHandler(this.btnSupr_Click);
            // 
            // nudRotation
            // 
            this.nudRotation.Location = new System.Drawing.Point(183, 393);
            this.nudRotation.Name = "nudRotation";
            this.nudRotation.Size = new System.Drawing.Size(63, 20);
            this.nudRotation.TabIndex = 19;
            // 
            // lbxImages
            // 
            this.lbxImages.FormattingEnabled = true;
            this.lbxImages.Location = new System.Drawing.Point(10, 129);
            this.lbxImages.Name = "lbxImages";
            this.lbxImages.Size = new System.Drawing.Size(236, 43);
            this.lbxImages.TabIndex = 18;
            // 
            // cbxTag
            // 
            this.cbxTag.FormattingEnabled = true;
            this.cbxTag.Location = new System.Drawing.Point(109, 366);
            this.cbxTag.Name = "cbxTag";
            this.cbxTag.Size = new System.Drawing.Size(137, 21);
            this.cbxTag.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rotation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Intervale entre les images (milisecond)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // tbxIntervalImage
            // 
            this.tbxIntervalImage.Location = new System.Drawing.Point(198, 205);
            this.tbxIntervalImage.Name = "tbxIntervalImage";
            this.tbxIntervalImage.Size = new System.Drawing.Size(48, 20);
            this.tbxIntervalImage.TabIndex = 6;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(53, 15);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(193, 20);
            this.tbxNom.TabIndex = 0;
            // 
            // tmp
            // 
            this.tmp.Enabled = true;
            this.tmp.Interval = 1000;
            this.tmp.Tick += new System.EventHandler(this.tmp_Tick);
            // 
            // pbxAjoutSprite
            // 
            this.pbxAjoutSprite.Image = global::FlappySharp.Properties.Resources.add;
            this.pbxAjoutSprite.Location = new System.Drawing.Point(363, 6);
            this.pbxAjoutSprite.Name = "pbxAjoutSprite";
            this.pbxAjoutSprite.Size = new System.Drawing.Size(70, 70);
            this.pbxAjoutSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAjoutSprite.TabIndex = 4;
            this.pbxAjoutSprite.TabStop = false;
            this.pbxAjoutSprite.Click += new System.EventHandler(this.pbxAjoutSprite_Click);
            // 
            // pbxAjoutTuyau
            // 
            this.pbxAjoutTuyau.Image = global::FlappySharp.Properties.Resources.tube_1;
            this.pbxAjoutTuyau.Location = new System.Drawing.Point(276, 6);
            this.pbxAjoutTuyau.Name = "pbxAjoutTuyau";
            this.pbxAjoutTuyau.Size = new System.Drawing.Size(70, 70);
            this.pbxAjoutTuyau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAjoutTuyau.TabIndex = 3;
            this.pbxAjoutTuyau.TabStop = false;
            this.pbxAjoutTuyau.Click += new System.EventHandler(this.pbxAjoutTuyau_Click);
            // 
            // pbxAjoutSol
            // 
            this.pbxAjoutSol.Image = global::FlappySharp.Properties.Resources.Terrain_1;
            this.pbxAjoutSol.Location = new System.Drawing.Point(188, 6);
            this.pbxAjoutSol.Name = "pbxAjoutSol";
            this.pbxAjoutSol.Size = new System.Drawing.Size(70, 70);
            this.pbxAjoutSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAjoutSol.TabIndex = 2;
            this.pbxAjoutSol.TabStop = false;
            this.pbxAjoutSol.Click += new System.EventHandler(this.pbxAjoutSol_Click);
            // 
            // pbxAjoutFond
            // 
            this.pbxAjoutFond.Image = global::FlappySharp.Properties.Resources.Arrière_plan_1;
            this.pbxAjoutFond.Location = new System.Drawing.Point(99, 6);
            this.pbxAjoutFond.Name = "pbxAjoutFond";
            this.pbxAjoutFond.Size = new System.Drawing.Size(70, 70);
            this.pbxAjoutFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAjoutFond.TabIndex = 1;
            this.pbxAjoutFond.TabStop = false;
            this.pbxAjoutFond.Click += new System.EventHandler(this.pbxAjoutFond_Click);
            // 
            // pbxAjoutFlappy
            // 
            this.pbxAjoutFlappy.Image = global::FlappySharp.Properties.Resources.Flappy_3;
            this.pbxAjoutFlappy.Location = new System.Drawing.Point(11, 6);
            this.pbxAjoutFlappy.Name = "pbxAjoutFlappy";
            this.pbxAjoutFlappy.Size = new System.Drawing.Size(70, 70);
            this.pbxAjoutFlappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAjoutFlappy.TabIndex = 0;
            this.pbxAjoutFlappy.TabStop = false;
            this.pbxAjoutFlappy.Click += new System.EventHandler(this.pbxAjoutFlappy_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 574);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "FlappySharp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spSceneParam.Panel2.ResumeLayout(false);
            this.spSceneParam.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSceneParam)).EndInit();
            this.spSceneParam.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalque)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutTuyau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutFond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAjoutFlappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer spSceneParam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHauteur;
        private System.Windows.Forms.TextBox tbxLargeur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDownZOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpZOrder;
        private System.Windows.Forms.NumericUpDown nudCalque;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPosX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPosY;
        private System.Windows.Forms.Button btnAjoutImages;
        private System.Windows.Forms.Button btnSauveModif;
        private System.Windows.Forms.Button btnSupr;
        private System.Windows.Forms.NumericUpDown nudRotation;
        private System.Windows.Forms.ListBox lbxImages;
        private System.Windows.Forms.ComboBox cbxTag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIntervalImage;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.PictureBox pbxAjoutSprite;
        private System.Windows.Forms.PictureBox pbxAjoutTuyau;
        private System.Windows.Forms.PictureBox pbxAjoutSol;
        private System.Windows.Forms.PictureBox pbxAjoutFond;
        private System.Windows.Forms.PictureBox pbxAjoutFlappy;
        private System.Windows.Forms.Timer tmp;
    }
}


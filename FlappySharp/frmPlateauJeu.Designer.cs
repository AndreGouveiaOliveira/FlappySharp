namespace FlappySharp
{
    partial class frmPlateauJeu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlateauJeu));
            this.tmp = new System.Windows.Forms.Timer(this.components);
            this.lblFps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmp
            // 
            this.tmp.Interval = 16;
            this.tmp.Tick += new System.EventHandler(this.tmp_Tick);
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(12, 9);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(33, 13);
            this.lblFps.TabIndex = 0;
            this.lblFps.Text = "FPS :";
            // 
            // frmPlateauJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 431);
            this.Controls.Add(this.lblFps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPlateauJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlateauJeu_FormClosing);
            this.Load += new System.EventHandler(this.frmPlateauJeu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPlateauJeu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmp;
        private System.Windows.Forms.Label lblFps;
    }
}
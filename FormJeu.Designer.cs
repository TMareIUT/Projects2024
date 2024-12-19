namespace Puissance4
{
    partial class FormJeu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblVictoire = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblVictoireRouge = new System.Windows.Forms.Label();
            this.lblVictoireJaune = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(874, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTour.Location = new System.Drawing.Point(307, 42);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(304, 39);
            this.lblTour.TabIndex = 1;
            this.lblTour.Text = "Au tour du joueur ";
            this.lblTour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVictoire
            // 
            this.lblVictoire.AutoSize = true;
            this.lblVictoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictoire.Location = new System.Drawing.Point(370, 869);
            this.lblVictoire.Name = "lblVictoire";
            this.lblVictoire.Size = new System.Drawing.Size(124, 36);
            this.lblVictoire.TabIndex = 2;
            this.lblVictoire.Text = "Victoire";
            // 
            // btnRetour
            // 
            this.btnRetour.AutoSize = true;
            this.btnRetour.Location = new System.Drawing.Point(81, 869);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 45);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Location = new System.Drawing.Point(880, 869);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(75, 45);
            this.btnRejouer.TabIndex = 4;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Visible = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // lblVictoireRouge
            // 
            this.lblVictoireRouge.AutoSize = true;
            this.lblVictoireRouge.Location = new System.Drawing.Point(112, 42);
            this.lblVictoireRouge.Name = "lblVictoireRouge";
            this.lblVictoireRouge.Size = new System.Drawing.Size(14, 16);
            this.lblVictoireRouge.TabIndex = 5;
            this.lblVictoireRouge.Text = "0";
            this.lblVictoireRouge.Visible = false;
            // 
            // lblVictoireJaune
            // 
            this.lblVictoireJaune.AutoSize = true;
            this.lblVictoireJaune.Location = new System.Drawing.Point(240, 41);
            this.lblVictoireJaune.Name = "lblVictoireJaune";
            this.lblVictoireJaune.Size = new System.Drawing.Size(14, 16);
            this.lblVictoireJaune.TabIndex = 6;
            this.lblVictoireJaune.Text = "0";
            this.lblVictoireJaune.Visible = false;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblVictoireJaune);
            this.Controls.Add(this.lblVictoireRouge);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblVictoire);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormJeu";
            this.Text = "FormJeu";
            this.Load += new System.EventHandler(this.FormJeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblVictoire;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblVictoireRouge;
        private System.Windows.Forms.Label lblVictoireJaune;
    }
}
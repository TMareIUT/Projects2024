namespace Puissance4
{
    partial class FormParametrage
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblModeDeJeux = new System.Windows.Forms.Label();
            this.lblTailleTableau = new System.Windows.Forms.Label();
            this.pnlMdJ = new System.Windows.Forms.Panel();
            this.rdoJvJ = new System.Windows.Forms.RadioButton();
            this.rdoJvIA = new System.Windows.Forms.RadioButton();
            this.pnlTdT = new System.Windows.Forms.Panel();
            this.rdoPerso = new System.Windows.Forms.RadioButton();
            this.rdoClassique = new System.Windows.Forms.RadioButton();
            this.btnValider = new System.Windows.Forms.Button();
            this.nudHauteur = new System.Windows.Forms.NumericUpDown();
            this.nudLargeur = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMdJ.SuspendLayout();
            this.pnlTdT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHauteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargeur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(82, 41);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(290, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Configuration du jeux";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblModeDeJeux
            // 
            this.lblModeDeJeux.AutoSize = true;
            this.lblModeDeJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeDeJeux.Location = new System.Drawing.Point(56, 113);
            this.lblModeDeJeux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeDeJeux.Name = "lblModeDeJeux";
            this.lblModeDeJeux.Size = new System.Drawing.Size(130, 25);
            this.lblModeDeJeux.TabIndex = 1;
            this.lblModeDeJeux.Text = "Mode de jeux";
            // 
            // lblTailleTableau
            // 
            this.lblTailleTableau.AutoSize = true;
            this.lblTailleTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTailleTableau.Location = new System.Drawing.Point(234, 113);
            this.lblTailleTableau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTailleTableau.Name = "lblTailleTableau";
            this.lblTailleTableau.Size = new System.Drawing.Size(155, 25);
            this.lblTailleTableau.TabIndex = 2;
            this.lblTailleTableau.Text = "Taille du tableau";
            // 
            // pnlMdJ
            // 
            this.pnlMdJ.Controls.Add(this.rdoJvJ);
            this.pnlMdJ.Controls.Add(this.rdoJvIA);
            this.pnlMdJ.Location = new System.Drawing.Point(64, 156);
            this.pnlMdJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMdJ.Name = "pnlMdJ";
            this.pnlMdJ.Size = new System.Drawing.Size(112, 61);
            this.pnlMdJ.TabIndex = 3;
            // 
            // rdoJvJ
            // 
            this.rdoJvJ.AutoSize = true;
            this.rdoJvJ.Location = new System.Drawing.Point(10, 41);
            this.rdoJvJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoJvJ.Name = "rdoJvJ";
            this.rdoJvJ.Size = new System.Drawing.Size(106, 17);
            this.rdoJvJ.TabIndex = 1;
            this.rdoJvJ.TabStop = true;
            this.rdoJvJ.Text = "Joueur vs Joueur";
            this.rdoJvJ.UseVisualStyleBackColor = true;
            // 
            // rdoJvIA
            // 
            this.rdoJvIA.AutoSize = true;
            this.rdoJvIA.Checked = true;
            this.rdoJvIA.Location = new System.Drawing.Point(10, 4);
            this.rdoJvIA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoJvIA.Name = "rdoJvIA";
            this.rdoJvIA.Size = new System.Drawing.Size(84, 17);
            this.rdoJvIA.TabIndex = 0;
            this.rdoJvIA.TabStop = true;
            this.rdoJvIA.Text = "Joueur vs IA";
            this.rdoJvIA.UseVisualStyleBackColor = true;
            // 
            // pnlTdT
            // 
            this.pnlTdT.Controls.Add(this.rdoPerso);
            this.pnlTdT.Controls.Add(this.rdoClassique);
            this.pnlTdT.Location = new System.Drawing.Point(251, 157);
            this.pnlTdT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTdT.Name = "pnlTdT";
            this.pnlTdT.Size = new System.Drawing.Size(112, 61);
            this.pnlTdT.TabIndex = 4;
            // 
            // rdoPerso
            // 
            this.rdoPerso.AutoSize = true;
            this.rdoPerso.Location = new System.Drawing.Point(10, 41);
            this.rdoPerso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPerso.Name = "rdoPerso";
            this.rdoPerso.Size = new System.Drawing.Size(85, 17);
            this.rdoPerso.TabIndex = 1;
            this.rdoPerso.TabStop = true;
            this.rdoPerso.Text = "Personnalisé";
            this.rdoPerso.UseVisualStyleBackColor = true;
            this.rdoPerso.CheckedChanged += new System.EventHandler(this.rdoPerso_CheckedChanged);
            // 
            // rdoClassique
            // 
            this.rdoClassique.AutoSize = true;
            this.rdoClassique.Checked = true;
            this.rdoClassique.Location = new System.Drawing.Point(10, 4);
            this.rdoClassique.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoClassique.Name = "rdoClassique";
            this.rdoClassique.Size = new System.Drawing.Size(70, 17);
            this.rdoClassique.TabIndex = 0;
            this.rdoClassique.TabStop = true;
            this.rdoClassique.Text = "Classique";
            this.rdoClassique.UseVisualStyleBackColor = true;
            this.rdoClassique.CheckedChanged += new System.EventHandler(this.rdoClassique_CheckedChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(188, 284);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(60, 19);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // nudHauteur
            // 
            this.nudHauteur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudHauteur.Location = new System.Drawing.Point(251, 232);
            this.nudHauteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHauteur.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHauteur.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudHauteur.Name = "nudHauteur";
            this.nudHauteur.Size = new System.Drawing.Size(38, 20);
            this.nudHauteur.TabIndex = 6;
            this.nudHauteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHauteur.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudHauteur.Visible = false;
            // 
            // nudLargeur
            // 
            this.nudLargeur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudLargeur.Location = new System.Drawing.Point(326, 232);
            this.nudLargeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudLargeur.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLargeur.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLargeur.Name = "nudLargeur";
            this.nudLargeur.Size = new System.Drawing.Size(38, 20);
            this.nudLargeur.TabIndex = 7;
            this.nudLargeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLargeur.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudLargeur.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(301, 236);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // FormParametrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 327);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.nudLargeur);
            this.Controls.Add(this.nudHauteur);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.pnlTdT);
            this.Controls.Add(this.pnlMdJ);
            this.Controls.Add(this.lblTailleTableau);
            this.Controls.Add(this.lblModeDeJeux);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormParametrage";
            this.Text = "Puissance4 - parametrage";
            this.pnlMdJ.ResumeLayout(false);
            this.pnlMdJ.PerformLayout();
            this.pnlTdT.ResumeLayout(false);
            this.pnlTdT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHauteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblModeDeJeux;
        private System.Windows.Forms.Label lblTailleTableau;
        private System.Windows.Forms.Panel pnlMdJ;
        private System.Windows.Forms.RadioButton rdoJvJ;
        private System.Windows.Forms.RadioButton rdoJvIA;
        private System.Windows.Forms.Panel pnlTdT;
        private System.Windows.Forms.RadioButton rdoPerso;
        private System.Windows.Forms.RadioButton rdoClassique;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.NumericUpDown nudHauteur;
        private System.Windows.Forms.NumericUpDown nudLargeur;
        private System.Windows.Forms.Label lblX;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


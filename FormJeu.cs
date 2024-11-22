using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BiblioClass;

namespace Puissance4
{
    public partial class FormJeu : Form
    {
        private FormParametrage frmParam;
        private int Columns = 0;
        private int Rows = 0;
        private bool joueur = false;
        public FormJeu()
        {
            InitializeComponent();
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            // ouvrir la fenetre au centre en haut de l'écran
            Rectangle workingArea = Screen.GetWorkingArea(this);
            int x = (workingArea.Width - this.Width) / 2;
            this.Location = new Point(x, 0);

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            frmParam = (FormParametrage)this.Owner;
            Columns = frmParam.PartieEnCours.plateau.largeur;
            Rows = frmParam.PartieEnCours.plateau.hauteur;
            lblVictoire.Text = "";
            if (frmParam.PartieEnCours.modeDeJeu) lblTour.Text = "Au tour du joueur jaune";
            else lblTour.Text = "";
            MAJInterface();
        }

        // Fonction pour redimensionner une image à une taille spécifiée
        public Image ResizeImage(Image image, int largeur, int hauteur)
        {
            Bitmap imageRedimensionnee = new Bitmap(largeur, hauteur);
            using (Graphics graphics = Graphics.FromImage(imageRedimensionnee))
            {
                graphics.DrawImage(image, 0, 0, largeur, hauteur);
            }
            return imageRedimensionnee;
        }
        public void MAJInterface()
        {
            Image imageSource = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "PlateauPerso.png"));
            Image pionJauneSource = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "PionJaune.png"));
            Image pionRougeSource = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "PionRouge.png"));
            int repetMax = Rows;
            if (Rows < Columns) repetMax = Columns;

            int nouvelleLargeure = 60 + ((10 - repetMax) * 5);
            int nouvelleHauteure = 60 + ((10 - repetMax) * 5);

            Image plateauVide = ResizeImage(imageSource, nouvelleLargeure, nouvelleHauteure);
            Image pionJaune = ResizeImage(pionJauneSource, nouvelleLargeure, nouvelleHauteure);
            Image pionRouge = ResizeImage(pionRougeSource, nouvelleLargeure, nouvelleHauteure);

            // Créez une image vide avec les dimensions calculées
            int largeurImageFinale = plateauVide.Width * Columns;
            int hauteurImageFinale = plateauVide.Height * Rows;
            Bitmap imageFinale = new Bitmap(largeurImageFinale, hauteurImageFinale);

            // Créez un objet Graphics à partir de l'image finale
            using (Graphics graphics = Graphics.FromImage(imageFinale))
            {
                // Répétez l'image source sur l'image finale
                for (int i = 0, hauteur = Rows - 1; hauteur >= 0; hauteur--, i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (frmParam.PartieEnCours.plateau.tab[i, j] == 1)
                        {
                            graphics.DrawImage(pionJaune, j * pionJaune.Width, hauteur * pionJaune.Height);
                        }
                        else if(frmParam.PartieEnCours.plateau.tab[i, j] == 2)
                            graphics.DrawImage(pionRouge, j * pionRouge.Width, hauteur * pionRouge.Height);
                        else
                        {
                            graphics.DrawImage(plateauVide, j * plateauVide.Width, hauteur * plateauVide.Height);
                        }
                    }
                }
                graphics.Dispose();
            }

            // Affichez l'image finale dans le PictureBox
            pictureBox1.Image = imageFinale;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            // Calculez les coordonnées pour centrer la PictureBox
            int x = (ClientSize.Width - pictureBox1.Width) / 2;
            int y = (ClientSize.Height - pictureBox1.Height) / 2;

            // Définissez la position de la PictureBox
            pictureBox1.Location = new Point(x, y);


            imageSource.Dispose();
            plateauVide.Dispose();
            pionJaune.Dispose();
            pionRouge.Dispose();
            //imageFinale.Dispose();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.SuspendLayout();
            if (frmParam.PartieEnCours.plateau.estVide()) joueur = false;
            if (frmParam.PartieEnCours.modeDeJeu)
            {
                for (int i = 0; i < Columns; i++)
                {
                    string couleurJoueur = joueur ? "Rouge" : "Jaune";
                    lblTour.Text = $"Au tour du joueur {couleurJoueur}";
                    Rectangle partieCible = new Rectangle(i * pictureBox1.Width / Columns, 0, pictureBox1.Width / Columns, pictureBox1.Height);

                    if (partieCible.Contains(e.Location) && !frmParam.PartieEnCours.colonnePleine(i) && !frmParam.PartieEnCours.plateau.Victoire(joueur) && !frmParam.PartieEnCours.plateau.Victoire(!joueur))
                    {
                        frmParam.PartieEnCours.plateau.PlacerUnPion(frmParam.PartieEnCours.plateau, i, joueur);
                        MAJInterface();      
                        if (frmParam.PartieEnCours.plateau.Victoire(joueur)) lblVictoire.Text = $"Victoire du joueur {couleurJoueur}";
                        joueur = !joueur;
                        if (frmParam.PartieEnCours.plateau.estPlein())
                        {
                            btnRejouer.Visible = true;
                            lblVictoire.Text = "Match Nul";
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Columns; i++)
                {
                    Rectangle partieCible = new Rectangle(i * pictureBox1.Width / Columns, 0, pictureBox1.Width / Columns, pictureBox1.Height);
                    if (partieCible.Contains(e.Location) && !frmParam.PartieEnCours.colonnePleine(i) && !frmParam.PartieEnCours.plateau.Victoire(joueur) && !frmParam.PartieEnCours.plateau.Victoire(!joueur))
                    {
                        joueur = false;
                        frmParam.PartieEnCours.plateau.PlacerUnPion(frmParam.PartieEnCours.plateau, i, joueur);
                        if (frmParam.PartieEnCours.plateau.estPlein())
                        {
                            btnRejouer.Visible = true;
                            lblVictoire.Text = "Match Nul";
                        }
                        if (frmParam.PartieEnCours.plateau.Victoire(joueur)) lblVictoire.Text = $"Victoire du joueur Jaune";
                        else if (!frmParam.PartieEnCours.modeDeJeu)
                        {
                            joueur = true;
                            frmParam.PartieEnCours.MinMax(frmParam.PartieEnCours.plateau, 4, true);
                            frmParam.PartieEnCours.plateau.PlacerUnPion(frmParam.PartieEnCours.plateau, frmParam.PartieEnCours.plateau.meilleurCoup, true);
                            if (frmParam.PartieEnCours.plateau.Victoire(joueur)) lblVictoire.Text = $"Victoire du joueur Rouge";
                            if (frmParam.PartieEnCours.plateau.estPlein())
                            {
                                btnRejouer.Visible = true;
                                lblVictoire.Text = "Match Nul";
                            }
                        }
                        MAJInterface();
                    } 
                }
            }
            if (frmParam.PartieEnCours.plateau.Victoire(joueur) || frmParam.PartieEnCours.plateau.Victoire(!joueur)) btnRejouer.Visible = true ;
            pictureBox1.ResumeLayout();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormParametrage frmParam = new FormParametrage();
            frmParam.Show();
            this.Hide();
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            bool mode = frmParam.PartieEnCours.modeDeJeu;
            int hauteur = frmParam.PartieEnCours.plateau.hauteur;
            int largeur = frmParam.PartieEnCours.plateau.largeur;
            if (frmParam.PartieEnCours.plateau.Victoire(true)) frmParam.PartieEnCours.victoireRouge++;
            else
            {
                if (frmParam.PartieEnCours.plateau.Victoire(false)) frmParam.PartieEnCours.victoireJaune++;
            }
                frmParam.PartieEnCours = new Partie(mode, hauteur, largeur, frmParam.PartieEnCours.victoireRouge, frmParam.PartieEnCours.victoireJaune);
            lblVictoireRouge.Text = frmParam.PartieEnCours.victoireRouge.ToString();
            lblVictoireRouge.Visible = true;
            lblVictoireJaune.Text = frmParam.PartieEnCours.victoireJaune.ToString();
            lblVictoireJaune.Visible = true;
            lblVictoire.Text = "";
            btnRejouer.Visible = false;
            MAJInterface();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass
{
    public class Suivant
    {
        public List<Grille> liste = new List<Grille>();
        public List<int> colonne = new List<int>();
        public Suivant(Grille plateau, bool joueur)
        {
            if (!plateau.Victoire(joueur) && !plateau.Victoire(!joueur))
            {
                for (int i = 0; i < plateau.largeur; i++)
                {
                    if (plateau.remplissage[i] < plateau.hauteur)
                    {
                        Grille plateauSuivant = plateau.Copy();
                        plateau.PlacerUnPion(plateauSuivant, i, joueur);
                        liste.Add(plateauSuivant);
                        colonne.Add(i);
                    }
                }
            }
        }
    }
}

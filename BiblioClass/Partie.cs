using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiblioClass
{
    public class Partie
    {
        private Grille _plateau;
        private bool _modeDeJeu; // False IA True 1v1
        private int _victoireRouge;
        private int _victoireJaune;

        //Constructeur
        public Partie()
        {
            _modeDeJeu = false;
            _plateau = new Grille();
            _victoireRouge = 0;
            _victoireJaune = 0;
        }

        public Partie(bool mode, int hauteur, int largeur, int victoireRouge, int victoireJaune)
        {
            _modeDeJeu = mode;
            _plateau = new Grille(hauteur,largeur);
            _victoireRouge = victoireRouge;
            _victoireJaune = victoireJaune;
        }

        //Getter
        public bool modeDeJeu
        {
            get
            {
                return _modeDeJeu;
            }
        }

        public Grille plateau
        {
            get
            {
                return _plateau;
            }
        }

        public int victoireRouge
        {
            get
            {
                return _victoireRouge;
            }
            set
            {
                _victoireRouge = value;
            }
        }

        public int victoireJaune
        {
            get
            {
                return _victoireJaune;
            }
            set
            {
                _victoireJaune = value;
            }
        }

        //Méthode
        public void ModifierMode(bool Mode)
        {
            _modeDeJeu = Mode;
        }

        public void ModifierPlateau(int hauteur, int largeur)
        {
            _plateau=new Grille(hauteur, largeur);
        }
        
        public bool colonnePleine(int colonne)
        {
            if (_plateau.remplissage[colonne] < _plateau.hauteur) return false;
            return true;
        }
        public int Eval(Grille _plateau, bool joueur)
        {
            int align3true = _plateau.PionsAlign3(true);
            int align3false = _plateau.PionsAlign3(false);
            int align2true = _plateau.PionsAlign2(true);
            int align2false = _plateau.PionsAlign2(false);
            if (align3true != 0)
                return -100 * align3true;
            else if (align3false != 0)
                return 100 * align3false;
            else if (align2true != 0)
                return -10 * align2true;
            else if (align2false != 0)
                return 10 * align2false;
            else return 0;
        }

        public int MinMax(Grille _plateau, int profondeur, bool joueur)
        {
            if (_plateau.Victoire(true)) return -1000;
            else if (_plateau.Victoire(false)) return 1000;
            else if (profondeur > 0)
            {
                int minPoids = int.MaxValue; // Valeur maximale possible
                int maxPoids = int.MinValue; // Valeur minimale possible
                int count = 0;
                Suivant suivant = new Suivant(_plateau, joueur);
                if (joueur)
                {
                    foreach (Grille grille in suivant.liste)
                    {
                        int rec = MinMax(grille, profondeur - 1, !joueur);
                        if (rec < minPoids)
                        {
                            minPoids = rec;
                            _plateau.meilleurCoup = suivant.colonne[count];
                        }
                        count++;
                    }
                    return minPoids;
                }
                else
                {
                    foreach (Grille grille in suivant.liste)
                    {
                        int rec = MinMax(grille, profondeur - 1, !joueur);
                        if (rec > maxPoids)
                        {
                            maxPoids = rec;
                            _plateau.meilleurCoup = suivant.colonne[count];
                        }
                        count++;
                    }
                    return maxPoids;
                }
            }
            else if (profondeur == 0)
            {
                return Eval(_plateau, joueur);
            }
            else
            {
                Console.WriteLine("Erreur de profondeur");
                return 0;
            }
        }
    }
}


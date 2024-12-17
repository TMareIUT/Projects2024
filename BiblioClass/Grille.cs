using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass
{
    public class Grille
    {
        private int[,] _tab;
        public int _hauteur, _largeur;
        private Dictionary<int, int> _remplissage = new Dictionary<int, int>(); // Indique le nombre de pions dans chaque colonne
        private int _poids = 0; // de base pas 0
        private int _meilleurCoup = 0; // Représente la colonne du meilleur coup 
        private int _profondeur = 0;

        //Constructeur
        public Grille()
        {
            _tab = new int[_hauteur = 6, _largeur = 7];
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur; j++)
                {
                    _tab[i, j] = 0;
                }
            }
            InitialisationRemplissage(); // Initialise les colonnes comme vide
        }
        public Grille(int hau, int lar)
        {
            _tab = new int[_hauteur = hau, _largeur = lar];
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur; j++)
                {
                    _tab[i, j] = 0;
                }
            }
            InitialisationRemplissage(); // Initialise les colonnes comme vide
        }

        //Getters et Setters
        public int[,] tab
        {
            get
            {
                return _tab;
            }
        }

        public int hauteur
        {
            get
            {
                return _hauteur;
            }
            set
            {
                _hauteur = value;
            }
        }
        public int largeur
        {
            get
            {
                return _largeur;
            }
            set
            {
                _largeur = value;
            }
        }

        public Dictionary<int, int> remplissage
        {
            get
            {
                return _remplissage;
            }
        }

        public int meilleurCoup
        {
            get
            {
                return _meilleurCoup;
            }
            set
            {
                _meilleurCoup = value;
            }
        }

        public void InitialisationRemplissage()
        {
            for (int i = 0; i < _largeur; i++) _remplissage.Add(i, 0);
        }

        public Grille Copy()
        {
            Grille copy = (Grille)this.MemberwiseClone();
            copy._tab = (int[,])this._tab.Clone();
            copy._remplissage = new Dictionary<int, int>(this._remplissage);
            copy._poids = this._poids;
            copy._meilleurCoup = this._meilleurCoup;
            copy._profondeur = this._profondeur;
            return copy;
        }

        // Vérifie si un joueur a aligné 4 pions dans la grille
        public virtual bool Victoire(bool joueur)
        {
            int nbJoueur = joueur ? 2 : 1;

            // Vérification horizontale
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur - 3; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i, j + 1] == nbJoueur) &&
                        (_tab[i, j + 2] == nbJoueur) &&
                        (_tab[i, j + 3] == nbJoueur))
                    {
                        return true;
                    }

                }
            }

            // Vérification verticale
            for (int i = 0; i < _hauteur - 3; i++)
            {
                for (int j = 0; j < _largeur; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i + 1, j] == nbJoueur) &&
                        (_tab[i + 2, j] == nbJoueur) &&
                        (_tab[i + 3, j] == nbJoueur))
                    {
                        return true;
                    }
                }
            }

            // Vérification diagonale ascendante
            for (int i = 0; i < _hauteur - 3; i++)
            {
                for (int j = 0; j < _largeur - 3; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i + 1, j + 1] == nbJoueur) &&
                        (_tab[i + 2, j + 2] == nbJoueur) &&
                        (_tab[i + 3, j + 3] == nbJoueur))
                    {
                        return true;
                    }
                }
            }

            // Vérification diagonale descendante
            for (int i = 3; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur - 3; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i - 1, j + 1] == nbJoueur) &&
                        (_tab[i - 2, j + 2] == nbJoueur) &&
                        (_tab[i - 3, j + 3] == nbJoueur))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public virtual int PionsAlign3(bool joueur)
        {
            int nbJoueur = joueur ? 2 : 1;
            int nbAlign = 0;
            // Vérification horizontale
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur - 2; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i, j + 1] == nbJoueur) &&
                        (_tab[i, j + 2] == nbJoueur))
                    {
                        nbAlign++;
                    }

                }
            }

            // Vérification verticale
            for (int i = 0; i < _hauteur - 2; i++)
            {
                for (int j = 0; j < _largeur; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i + 1, j] == nbJoueur) &&
                        (_tab[i + 2, j] == nbJoueur))
                    {
                        nbAlign++;
                    }
                }
            }

            // Vérification diagonale ascendante
            for (int i = 0; i < _hauteur - 2; i++)
            {
                for (int j = 0; j < _largeur - 2; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i + 1, j + 1] == nbJoueur) &&
                        (_tab[i + 2, j + 2] == nbJoueur))
                    {
                        nbAlign++;
                    }
                }
            }

            // Vérification diagonale descendante
            for (int i = 3; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur - 2; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i - 1, j + 1] == nbJoueur) &&
                        (_tab[i - 2, j + 2] == nbJoueur))
                    {
                        nbAlign++;
                    }
                }
            }
            return nbAlign;
        }

        public virtual int PionsAlign2(bool joueur)
        {
            int nbJoueur = joueur ? 2 : 1;
            int nbAlign = 0;
            // Vérification horizontale
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur - 1; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i, j + 1] == nbJoueur))
                    {
                        nbAlign++;
                    }

                }
            }

            // Vérification verticale
            for (int i = 0; i < _hauteur - 1; i++)
            {
                for (int j = 0; j < _largeur; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i + 1, j] == nbJoueur))
                    {
                        nbAlign++;
                    }
                }
            }

            // Vérification diagonale ascendante
            for (int i = 0; i < _hauteur - 1; i++)
            {
                for (int j = 0; j < _largeur - 1; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i + 1, j + 1] == nbJoueur))
                    {
                        nbAlign++;
                    }
                }
            }

            // Vérification diagonale descendante
            for (int i = 3; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur - 1; j++)
                {
                    if ((_tab[i, j] == nbJoueur) &&
                        (_tab[i - 1, j + 1] == nbJoueur))
                    {
                        nbAlign++;
                    }
                }
            }
            return nbAlign;
        }
        public void PlacerUnPion(Grille plateau, int colonne, bool joueur)  // IA automatique joueur 1
        {
            int nbJoueur = joueur ? 2 : 1;
            if (plateau._remplissage[colonne] < plateau._hauteur)
            {
                plateau._tab[plateau._remplissage[colonne], colonne] = nbJoueur;
                plateau._remplissage[colonne]++;
            }
        }

        public bool estPlein()
        {
            for (int i = 0; i < _largeur; i++)
            {
                if (_remplissage[i] < _hauteur)
                {
                    return false;
                }
            }
            return true;
        }

        public bool estVide()
        {
            for (int i = 0; i < _largeur; i++)
            {
                if (_remplissage[i] > 0)
                {
                    return false;
                }
            }
            return true;
        }

    }

    public class GrilleMock : Grille
    {
        private Func<bool, int> _pionsAlign3;
        private Func<bool, int> _pionsAlign2;
        private Func<bool, bool> _victoire;

        public GrilleMock(
            Func<bool, int> pionsAlign3 = null,
            Func<bool, int> pionsAlign2 = null,
            Func<bool, bool> victoire = null)
        {
            _pionsAlign3 = pionsAlign3 ?? (joueur => 0);
            _pionsAlign2 = pionsAlign2 ?? (joueur => 0);
            _victoire = victoire ?? (joueur => false);
        }

        public override int PionsAlign3(bool joueur) => _pionsAlign3(joueur);
        public override int PionsAlign2(bool joueur) => _pionsAlign2(joueur);
        public override bool Victoire(bool joueur) => _victoire(joueur);
    }
    // -10 pour victoire joueur2 true   +10 pour victoire joueur1 false
}
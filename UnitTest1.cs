
namespace BiblioClass
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test1_VerifVictoire_JoueurFalseJoueur1_Verticale()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[0, 0] = 1;
            GrilleDeTest.tab[0, 1] = 1;
            GrilleDeTest.tab[0, 2] = 1;
            GrilleDeTest.tab[0, 3] = 1;

            bool resultat = GrilleDeTest.Victoire(false); //false == Joueur 1 == valeur dans tableau 1

            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void Test2_VerifVictoire_JoueurTrueJoueur2_Verticale()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[2, 1] = 2;
            GrilleDeTest.tab[2, 2] = 2;
            GrilleDeTest.tab[2, 3] = 2;
            GrilleDeTest.tab[2, 4] = 2;

            bool resultat = GrilleDeTest.Victoire(true); //true == Joueur 2 == valeur dans tableau 2

            Assert.AreEqual(true, resultat);
        }


        [TestMethod]
        public void Test3_VerifVictoire_JoueurFalseJoueur1_Horizontale()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[0, 0] = 1;
            GrilleDeTest.tab[1, 0] = 1;
            GrilleDeTest.tab[2, 0] = 1;
            GrilleDeTest.tab[3, 0] = 1;

            bool resultat = GrilleDeTest.Victoire(false); //false == Joueur 1 == valeur dans tableau 1

            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void Test4_VerifVictoire_JoueurTrueJoueur2_Horizontale()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[1, 2] = 2;
            GrilleDeTest.tab[2, 2] = 2;
            GrilleDeTest.tab[3, 2] = 2;
            GrilleDeTest.tab[4, 2] = 2;

            bool resultat = GrilleDeTest.Victoire(true); //true == Joueur 2 == valeur dans tableau 2

            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void Test5_VerifVictoire_JoueurFalseJoueur1_Diagonale()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[0, 0] = 1;
            GrilleDeTest.tab[1, 1] = 1;
            GrilleDeTest.tab[2, 2] = 1;
            GrilleDeTest.tab[3, 3] = 1;

            bool resultat = GrilleDeTest.Victoire(false); //false == Joueur 1 == valeur dans tableau 1

            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void Test6_VerifVictoire_JoueurTrueJoueur2_Diagonale()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[2, 2] = 2;
            GrilleDeTest.tab[3, 3] = 2;
            GrilleDeTest.tab[4, 4] = 2;
            GrilleDeTest.tab[5, 5] = 2;

            bool resultat = GrilleDeTest.Victoire(true); //true == Joueur 2 == valeur dans tableau 2

            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void Test7_VerifPasDeVictoire_JoueurFalseJoueur1()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[0, 0] = 1;
            GrilleDeTest.tab[5, 1] = 1;
            GrilleDeTest.tab[4, 4] = 1;
            GrilleDeTest.tab[0, 3] = 1;

            bool resultat = GrilleDeTest.Victoire(false); //false == Joueur 1 == valeur dans tableau 1

            Assert.AreEqual(false, resultat);
        }

        [TestMethod]
        public void Test8_VerifPasVictoire_JoueurTrueJoueur2()
        {
            Grille GrilleDeTest = new Grille();

            GrilleDeTest.tab[0, 0] = 2;
            GrilleDeTest.tab[2, 2] = 2;
            GrilleDeTest.tab[1, 3] = 2;
            GrilleDeTest.tab[2, 4] = 2;

            bool resultat = GrilleDeTest.Victoire(true); //true == Joueur 2 == valeur dans tableau 2

            Assert.AreEqual(false, resultat);
        }
    }
}
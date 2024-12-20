namespace Test_MS_test;
using Puissance4;
using BiblioClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class Test_MS_test
{
    [TestMethod]
    public void Test_ConstructeurParDefaut()
    {
        // Arrange
        Partie partie = new Partie();

        // Act & Assert
        Assert.IsNotNull(partie.plateau, "Le plateau ne devrait pas être nul.");
        Assert.AreEqual(false, partie.modeDeJeu, "Le mode de jeu par défaut devrait être false.");
        Assert.AreEqual(0, partie.victoireRouge, "Les victoires rouges devraient être initialisées à 0.");
        Assert.AreEqual(0, partie.victoireJaune, "Les victoires jaunes devraient être initialisées à 0.");
    }

    [TestMethod]
    public void Test_ModifierMode()
    {
        // Arrange
        Partie partie = new Partie();

        // Act
        partie.ModifierMode(true);

        // Assert
        Assert.AreEqual(true, partie.modeDeJeu, "Le mode de jeu devrait être modifié à true.");
    }

    [TestMethod]
    public void Test_ModifierPlateau()
    {
        // Arrange
        Partie partie = new Partie();

        // Act
        partie.ModifierPlateau(10, 8);

        // Assert
        Assert.AreEqual(10, partie.plateau.hauteur, "La hauteur du plateau devrait être modifiée à 10.");
        Assert.AreEqual(8, partie.plateau.largeur, "La largeur du plateau devrait être modifiée à 8.");
    }

    [TestMethod]
    public void Test_ColonnePleine()
    {
        // Arrange
        Partie partie = new Partie();
        partie.plateau.remplissage[0] = partie.plateau.hauteur;

        // Act
        bool result = partie.colonnePleine(0);

        // Assert
        Assert.IsTrue(result, "La colonne devrait être pleine.");
    }


    [TestMethod]
    public void Test_MinMax()
    {
        // Arrange
        Partie partie = new Partie();
        GrilleMock grille = new GrilleMock(
            victoire: joueur => false,
            pionsAlign3: joueur => joueur ? 1 : 0
        );

        // Act
        int result = partie.MinMax(grille, 3, true);

        // Assert
        Assert.IsTrue(result < 0, "Le résultat du MinMax devrait être négatif pour le joueur actuel.");
    }
}
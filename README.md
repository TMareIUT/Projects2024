### Projects2024
Projets des étudiants en BUT Info Alternant 2024-2025

# Projet de Développement d'un casse brique
Langage de programmation : python

## Arborescence du projet :

ALEXANDRE-BONNEMENT-DAVID-ROGER_PROJET/
├── main.py               # Point d'entrée du jeu
├── config/
│   └── settings.py       # Configuration globale (dimensions de l'écran, couleurs, vitesse, etc.)
├── assets/
│   ├── images/           # Images des briques, de la balle, du paddle, etc.
│   ├── sounds/           # Effets sonores pour collisions et musique de fond
│   └── fonts/            # Polices pour le texte
├── core/
│   ├── game.py           # Classe principale pour gérer la boucle de jeu et les événements
│   ├── utils.py          # Fonctions utilitaires
├── entities/
│   ├── paddle.py         # Classe pour le paddle
│   ├── ball.py           # Classe pour la balle
│   └── brick.py          # Classe pour les briques
├── levels/
│   ├── levelX.json      # Définition des briques pour un niveau
│   └── levelLoader.py   # Chargeur des fichiers de niveau
├── ui/
│   ├── menu.py           # Gestion du menu principal (start, settings, quit)
│   ├── hud.py            # Interface utilisateur en jeu (score, vies restantes)
│   └── gameOver.py      # Affichage de l'écran de fin de partie
└── README.md             # Documentation pour le projet


## Tâches à Réaliser :

#### 1.	Code et Commentaire :
-	Développez le jeu en respectant les normes de codage.
-	Commentez le code de manière claire et explicative.
#### 2.	Cahier des charges :
-	Rédigez un cahier des charges décrivant les fonctionnalités, les règles du jeu, les objectifs et les spécifications techniques.
#### 3.	Plan de Test :
-	Élaborez un plan de test détaillé, y compris les scénarios de test, les données de test et les critères d'acceptation. (Plan de test simplifié, sans analyses des risques, juste l’ensemble de vos tests, les critère d’acceptations, et la validation du test)
#### 4.	Documentation Technique :
-	Créez une documentation technique complète expliquant l'architecture du jeu et la structure du code.
#### 5.	Tests Unitaires :
-	Implémentez des tests unitaires pour valider le bon fonctionnement du code du jeu.
#### 6.	GitHub :
-	Créez un répertoire sur GitHub : https://github.com/TMareIUT/Projects2024/  
[Vos Noms de Famille]_Projet
Faites en un fork et poussez régulièrement le code source, la documentation, le plan de test et les tests unitaires. N’hésitez pas à faire de multiples Pull-Request.
#### 7.	Revue de Code :
-	Effectuez une revue de code en utilisant les pull-request sur GitHub pour examiner le code de vos collègues et fournir des commentaires constructifs.